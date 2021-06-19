using Jint;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataImporter
{
    public partial class Form1 : Form
    {
        struct QATable
        {
            public string Q, A;
        }
        DataTable datastore;
        DataTable resultstore;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            help_pannel_input.Visible = !help_pannel_input.Visible;
            help_pannel_output.Visible = !help_pannel_output.Visible;
            help_pannel_script.Visible = !help_pannel_script.Visible;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            string[] files = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var fn in files)
                {
                    if (Regex.IsMatch(fn, @".+\.csv"))
                    {
                        e.Effect = DragDropEffects.Link;
                    }
                    if (Regex.IsMatch(fn, @".+\.convert\.js"))
                    {
                        e.Effect = DragDropEffects.Link;
                    }
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                foreach (var fn in files)
                {
                    if (Regex.IsMatch(fn, @".+\.csv"))
                    {
                        datastore = ReadCSV(fn);
                        inputbox.Rtf = TableInRTF.RtfFromDataTable(datastore, inputbox.Width * 10);
                    }
                    if (Regex.IsMatch(fn, @".+\.convert\.js"))
                    {
                        convertscript.Text = File.ReadAllText(fn);
                    }
                }
            }
        }

        private string[][] LoadCsv(string file)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            List<string[]> data = new List<string[]>();
            var lines = File.ReadAllLines(file, Encoding.GetEncoding("GB2312"));
            foreach (var l in lines)
            {
                data.Add(l.Split(','));
            }
            return data.ToArray();
        }

        /// <summary>
        /// 读取CSV文件到DataTable中
        /// </summary>
        /// <param name="filePath">CSV的文件路径</param>
        /// <returns></returns>
        public static DataTable ReadCSV(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            DataTable dt = new DataTable();
            int lineNumber = 0;
            using (CsvFileReader reader = new CsvFileReader(filePath, Encoding.GetEncoding("GB2312")))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {

                    if (0 == lineNumber)
                    {
                        foreach (string s in row)
                        {
                            dt.Columns.Add(s.Replace("\"", ""));
                        }
                    }
                    else
                    {
                        int index = 0;
                        DataRow dr = dt.NewRow();
                        foreach (string s in row)
                        {
                            dr[index] = s.Replace("\"", "");
                            index++;
                        }
                        dt.Rows.Add(dr);
                    }
                    lineNumber++;
                }
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScriptEngine se = new ScriptEngine(convertscript.Text);
            resultstore = new DataTable();
            resultstore.Columns.Add("题目");
            resultstore.Columns.Add("答案");
            List<string> question = new List<string>();
            LogWindow lw = new LogWindow();
            if (datastore != null) foreach (DataRow rec in datastore.Rows)
                {
                    var result = se.Convert(tostringarray(rec.ItemArray));
                    if (question.Contains(result[0]))
                    {
                        lw.textbox.Text += "重复的题目:" + result[0] + "\n该题目重复出现，将仅存储一次。\n\n";
                        continue;
                    }
                    else
                    {
                        question.Add(result[0]);
                    }
                    DataRow dr = resultstore.NewRow();
                    dr[0] = result[0];
                    dr[1] = result[1];
                    resultstore.Rows.Add(dr);
                }
            if (lw.textbox.Text.Length > 2) lw.ShowDialog();
            resulttable.Rtf = TableInRTF.RtfFromDataTable(resultstore, resulttable.Width * 10);
        }
        private string[] tostringarray(object[] obj)
        {
            List<string> ll = new List<string>();
            foreach (var i in obj)
            {
                ll.Add(i.ToString());
            }
            return ll.ToArray();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filesave.Title = "保存转换脚本";
            filesave.Filter = "转换脚本文件|*.convert.js";
            filesave.DefaultExt = "convert.js";
            filesave.CheckPathExists = true;
            filesave.CheckFileExists = false;
            filesave.AddExtension = true;
            var result = filesave.ShowDialog();
            if (result != DialogResult.OK) return;
            File.WriteAllText(filesave.FileName, convertscript.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filesave.Title = "保存题库";
            filesave.Filter = "本地题库文件|*.ldb";
            filesave.DefaultExt = "ldb";
            filesave.CheckPathExists = true;
            filesave.CheckFileExists = false;
            filesave.AddExtension = true;
            var result = filesave.ShowDialog();
            if (result != DialogResult.OK) return;
            StreamWriter sr = new StreamWriter(filesave.FileName);
            foreach (DataRow dr in resultstore.Rows)
            {
                JObject jb = new JObject();
                jb.Add("q", dr.ItemArray[0].ToString());
                jb.Add("a", dr.ItemArray[1].ToString());
                sr.WriteLine(jb.ToString(Newtonsoft.Json.Formatting.None));
            }
            sr.Flush();
            sr.Close();
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
