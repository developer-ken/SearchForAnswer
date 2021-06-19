
namespace DataImporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.resulttable = new System.Windows.Forms.RichTextBox();
            this.convertscript = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.filesave = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.help_pannel_input = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.help_pannel_output = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.help_pannel_script = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.help_pannel_input.SuspendLayout();
            this.help_pannel_output.SuspendLayout();
            this.help_pannel_script.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.button1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(31, 7);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(152, 17);
            this.note.TabIndex = 1;
            this.note.Text = "点击左侧按钮查看使用帮助";
            this.note.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.note.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // inputbox
            // 
            this.inputbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputbox.Location = new System.Drawing.Point(12, 32);
            this.inputbox.Name = "inputbox";
            this.inputbox.ReadOnly = true;
            this.inputbox.Size = new System.Drawing.Size(433, 503);
            this.inputbox.TabIndex = 2;
            this.inputbox.Text = "";
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(451, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "→";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.button2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // resulttable
            // 
            this.resulttable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resulttable.Location = new System.Drawing.Point(694, 32);
            this.resulttable.Name = "resulttable";
            this.resulttable.ReadOnly = true;
            this.resulttable.Size = new System.Drawing.Size(433, 503);
            this.resulttable.TabIndex = 4;
            this.resulttable.Text = "";
            // 
            // convertscript
            // 
            this.convertscript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertscript.Location = new System.Drawing.Point(451, 32);
            this.convertscript.Name = "convertscript";
            this.convertscript.Size = new System.Drawing.Size(237, 418);
            this.convertscript.TabIndex = 5;
            this.convertscript.Text = "//Convert函数会对左侧的每一行数据调用\n//左侧数据一行中的元素作为数组传入data参数\n//返回数组的第一个(0)元素为题目，第二个(1)为答案\nfun" +
    "ction Convert(data) {\n    return new Array(data[0],data[1]);\n}";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1052, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "保存题库";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.button3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(613, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "保存脚本";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.button4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "将需要读取的文件或脚本拖到这里";
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // help_pannel_input
            // 
            this.help_pannel_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_pannel_input.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.help_pannel_input.Controls.Add(this.label5);
            this.help_pannel_input.Controls.Add(this.label4);
            this.help_pannel_input.Location = new System.Drawing.Point(12, 32);
            this.help_pannel_input.Name = "help_pannel_input";
            this.help_pannel_input.Size = new System.Drawing.Size(433, 503);
            this.help_pannel_input.TabIndex = 11;
            this.help_pannel_input.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "您拖入表格文件中包含的题目数据。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 62);
            this.label4.TabIndex = 0;
            this.label4.Text = "待处理数据";
            // 
            // help_pannel_output
            // 
            this.help_pannel_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_pannel_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.help_pannel_output.Controls.Add(this.label7);
            this.help_pannel_output.Controls.Add(this.label6);
            this.help_pannel_output.Location = new System.Drawing.Point(694, 33);
            this.help_pannel_output.Name = "help_pannel_output";
            this.help_pannel_output.Size = new System.Drawing.Size(433, 503);
            this.help_pannel_output.TabIndex = 12;
            this.help_pannel_output.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "将会被存储在导出的题库中的数据。\r\n第一列是题目，第二列是答案。";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 62);
            this.label6.TabIndex = 1;
            this.label6.Text = "获取的数据";
            // 
            // help_pannel_script
            // 
            this.help_pannel_script.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_pannel_script.BackColor = System.Drawing.Color.White;
            this.help_pannel_script.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.help_pannel_script.Controls.Add(this.label9);
            this.help_pannel_script.Controls.Add(this.label8);
            this.help_pannel_script.Location = new System.Drawing.Point(451, 32);
            this.help_pannel_script.Name = "help_pannel_script";
            this.help_pannel_script.Size = new System.Drawing.Size(237, 417);
            this.help_pannel_script.TabIndex = 13;
            this.help_pannel_script.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 75);
            this.label9.TabIndex = 3;
            this.label9.Text = "从左侧待处理数据中提取\r\n右侧输出数据所需的操作\r\n和运算逻辑";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 38);
            this.label8.TabIndex = 2;
            this.label8.Text = "数据处理脚本";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 547);
            this.Controls.Add(this.help_pannel_script);
            this.Controls.Add(this.help_pannel_output);
            this.Controls.Add(this.help_pannel_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.convertscript);
            this.Controls.Add(this.resulttable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.note);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "本地查题数据库生成器";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.help_pannel_input.ResumeLayout(false);
            this.help_pannel_input.PerformLayout();
            this.help_pannel_output.ResumeLayout(false);
            this.help_pannel_output.PerformLayout();
            this.help_pannel_script.ResumeLayout(false);
            this.help_pannel_script.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.RichTextBox inputbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox resulttable;
        private System.Windows.Forms.RichTextBox convertscript;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog filesave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel help_pannel_input;
        private System.Windows.Forms.Panel help_pannel_output;
        private System.Windows.Forms.Panel help_pannel_script;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

