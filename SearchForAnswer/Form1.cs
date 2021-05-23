using NativeApi;
using SearchEngine;
using SearchEngine.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForAnswer
{
    public partial class Form1 : Form
    {
        public event MethodInvoker onClipboardUpdate;
        public ISearchEngine currentEngine;
        private Point BoxDefLoc;
        private Size WindowDefSize;
        public Form1()
        {
            InitializeComponent();
            onClipboardUpdate += Form1_onClipboardUpdate;
            CheckForIllegalCrossThreadCalls = false;
            BoxDefLoc = searchbox.Location;
            WindowDefSize = Size;
        }

        private void Form1_onClipboardUpdate()
        {
            if (!Clipboard.ContainsText())
                return;
            string clipboardtext = Clipboard.GetText();
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock (currentEngine)
                    {
                        Keywords.Text = clipboardtext;
                        this.answer.Text = "[正在处理，请不要继续操作...]";
                        if (currentEngine.EngineInfo.NeedLogin)
                        {
                            var loginEngine = (ILoginSearchEngine)currentEngine;
                            var loginform = new Login(loginEngine.Captcha(currentEngine.EngineInfo.LoginInfo));
                            loginform.ShowDialog();
                            loginform.Dispose();
                            if (!loginEngine.Login(loginform.Username, loginform.Password, loginform.Captcha))
                            {
                                throw new Exception("无法登录到搜题引擎");
                            }
                        }
                        var answer = currentEngine.Search(new() { Keywords = clipboardtext, Type = Structs.QuestionType.Others });
                        this.answer.Text = answer.Answer;
                        if (autocopy.Checked)
                            timer1.Start();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("您选择的搜题引擎出现了一处错误。\n" + err.Message + "\n" + err.StackTrace, "搜题引擎无法运行");
                }
            })).Start();
        }

        private void run_CheckedChanged(object sender, EventArgs e)
        {
            if (run.Checked)
            {
                WinApi.AddClipboardFormatListener(this.Handle);
            }
            else
            {
                WinApi.RemoveClipboardFormatListener(this.Handle);
            }
        }

        int lastTickCount = 0;
        protected override void WndProc(ref Message m)//拦截消息泵
        {
            if (m.Msg == WinApi.WM_CLIPBOARDUPDATE && this.onClipboardUpdate != null)
            {
                //列表类解析，会阻止时间，用此法不行，再用lastText方法
                if (Environment.TickCount - this.lastTickCount >= 200)
                    this.onClipboardUpdate();
                this.lastTickCount = Environment.TickCount;
                m.Result = IntPtr.Zero;
            }
            base.WndProc(ref m);
        }

        private void EngineSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (EngineSelection.SelectedItem != null)
                currentEngine = EngineLib.Get(EngineSelection.SelectedItem.ToString());
            run.Enabled = currentEngine.Loaded;
            new Thread(new ThreadStart(() =>
            {
                lock (currentEngine)
                {
                    try
                    {
                        EngineSelection.Enabled = false;
                        EngineName.Text = currentEngine.EngineInfo.Name;
                        EngineProvider.Text = currentEngine.EngineInfo.Provider;
                        EngineVersion.Text = currentEngine.EngineInfo.Version.ToString();
                        EngineMessages.Text = currentEngine.EngineInfo.Message;
                        if (currentEngine.EngineInfo.NeedLogin)
                        {
                            var loginEngine = (ILoginSearchEngine)currentEngine;
                            var loginform = new Login(loginEngine.Captcha(currentEngine.EngineInfo.LoginInfo));
                            loginform.ShowDialog();
                            loginform.Dispose();
                            if (!loginEngine.Login(loginform.Username, loginform.Password, loginform.Captcha))
                            {
                                throw new Exception("无法登录到搜题引擎");
                            }
                        }
                        while (!currentEngine.Loaded) Thread.Sleep(0);
                        run.Enabled = currentEngine.Loaded;
                        EngineVersion.Text = currentEngine.EngineInfo.Version.ToString();
                        EngineMessages.Text = currentEngine.EngineInfo.Message;
                        EngineSelection.Enabled = true;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("您选择的搜题引擎出现了一处错误。\n" + err.Message + "\n" + err.StackTrace, "无法加载选择的搜题引擎");
                    }
                }
            })).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EngineSelection.Items.AddRange(EngineLib.List().ToArray());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBox2.Checked;
        }

        private void lessinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (lessinfo.Checked)
            {
                searchbox.Location = new Point(label1.Location.X, EngineSelection.Location.Y);
                Size = new Size(WindowDefSize.Width, searchbox.Size.Height + searchbox.Location.Y + (WindowDefSize.Height-(BoxDefLoc.Y+searchbox.Size.Height)));
            }
            else
            {
                searchbox.Location = BoxDefLoc;
                Size = WindowDefSize;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.answer.Text);
            timer1.Stop();
        }
    }
}
