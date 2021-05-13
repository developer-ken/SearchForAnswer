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

        public Form1()
        {
            InitializeComponent();
            onClipboardUpdate += Form1_onClipboardUpdate;
            CheckForIllegalCrossThreadCalls = false;
            searchbox.Location = new Point(13, 166);
            Size = new Size(768, 468);
        }

        private void Form1_onClipboardUpdate()
        {
            if (!Clipboard.ContainsText())
                return;
            string clipboardtext = Clipboard.GetText();
            new Thread(new ThreadStart(() =>
            {
                lock (currentEngine)
                {
                    Keywords.Text = clipboardtext;
                    this.answer.Text = "[正在处理，请不要继续操作...]";
                    var answer = currentEngine.Search(new() { Keywords = clipboardtext, Type = Structs.QuestionType.Others });
                    this.answer.Text = answer.Answer;
                    if (autocopy.Checked)
                        timer1.Start();
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
                        EngineName.Text = currentEngine.EngineInfo.Name;
                        EngineProvider.Text = currentEngine.EngineInfo.Provider;
                        EngineVersion.Text = currentEngine.EngineInfo.Version.ToString();
                        EngineMessages.Text = currentEngine.EngineInfo.Message;
                        while (!currentEngine.Loaded) Thread.Sleep(0);
                        run.Enabled = currentEngine.Loaded;
                        EngineVersion.Text = currentEngine.EngineInfo.Version.ToString();
                        EngineMessages.Text = currentEngine.EngineInfo.Message;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("您选择的答题引擎出现了一处错误。\n" + err.Message + "\n" + err.StackTrace, "无法加载选择的答题引擎");
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
                searchbox.Location = new Point(13, 12);
                Size = new Size(768, 314);
            }
            else
            {
                searchbox.Location = new Point(13, 166);
                Size = new Size(768, 468);
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
