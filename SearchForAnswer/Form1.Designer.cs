
namespace SearchForAnswer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.EngineSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TokenInput = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EngineMessages = new System.Windows.Forms.TextBox();
            this.EngineProvider = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EngineVersion = new System.Windows.Forms.TextBox();
            this.EngineName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.GroupBox();
            this.lessinfo = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.autocopy = new System.Windows.Forms.CheckBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Keywords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.searchbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜题引擎";
            // 
            // EngineSelection
            // 
            this.EngineSelection.FormattingEnabled = true;
            this.EngineSelection.Location = new System.Drawing.Point(87, 12);
            this.EngineSelection.Name = "EngineSelection";
            this.EngineSelection.Size = new System.Drawing.Size(151, 28);
            this.EngineSelection.TabIndex = 1;
            this.EngineSelection.SelectedIndexChanged += new System.EventHandler(this.EngineSelection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Token";
            // 
            // TokenInput
            // 
            this.TokenInput.Location = new System.Drawing.Point(331, 12);
            this.TokenInput.Name = "TokenInput";
            this.TokenInput.Size = new System.Drawing.Size(289, 27);
            this.TokenInput.TabIndex = 3;
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.Location = new System.Drawing.Point(629, 14);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(91, 24);
            this.run.TabIndex = 4;
            this.run.Text = "开始运行";
            this.run.UseVisualStyleBackColor = true;
            this.run.CheckedChanged += new System.EventHandler(this.run_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EngineMessages);
            this.groupBox1.Controls.Add(this.EngineProvider);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EngineVersion);
            this.groupBox1.Controls.Add(this.EngineName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜题引擎信息";
            // 
            // EngineMessages
            // 
            this.EngineMessages.Location = new System.Drawing.Point(16, 55);
            this.EngineMessages.Multiline = true;
            this.EngineMessages.Name = "EngineMessages";
            this.EngineMessages.ReadOnly = true;
            this.EngineMessages.Size = new System.Drawing.Size(692, 54);
            this.EngineMessages.TabIndex = 8;
            // 
            // EngineProvider
            // 
            this.EngineProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EngineProvider.Location = new System.Drawing.Point(481, 29);
            this.EngineProvider.Name = "EngineProvider";
            this.EngineProvider.ReadOnly = true;
            this.EngineProvider.Size = new System.Drawing.Size(227, 20);
            this.EngineProvider.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(281, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "提供商:";
            // 
            // EngineVersion
            // 
            this.EngineVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EngineVersion.Location = new System.Drawing.Point(277, 29);
            this.EngineVersion.Name = "EngineVersion";
            this.EngineVersion.ReadOnly = true;
            this.EngineVersion.Size = new System.Drawing.Size(107, 20);
            this.EngineVersion.TabIndex = 3;
            // 
            // EngineName
            // 
            this.EngineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EngineName.Location = new System.Drawing.Point(61, 29);
            this.EngineName.Name = "EngineName";
            this.EngineName.ReadOnly = true;
            this.EngineName.Size = new System.Drawing.Size(165, 20);
            this.EngineName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "版本:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称:";
            // 
            // searchbox
            // 
            this.searchbox.Controls.Add(this.lessinfo);
            this.searchbox.Controls.Add(this.checkBox2);
            this.searchbox.Controls.Add(this.autocopy);
            this.searchbox.Controls.Add(this.answer);
            this.searchbox.Controls.Add(this.label7);
            this.searchbox.Controls.Add(this.Keywords);
            this.searchbox.Controls.Add(this.label6);
            this.searchbox.Location = new System.Drawing.Point(12, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(726, 242);
            this.searchbox.TabIndex = 6;
            this.searchbox.TabStop = false;
            this.searchbox.Text = "查题";
            // 
            // lessinfo
            // 
            this.lessinfo.AutoSize = true;
            this.lessinfo.Location = new System.Drawing.Point(9, 170);
            this.lessinfo.Name = "lessinfo";
            this.lessinfo.Size = new System.Drawing.Size(91, 24);
            this.lessinfo.TabIndex = 9;
            this.lessinfo.Text = "精简界面";
            this.lessinfo.UseVisualStyleBackColor = true;
            this.lessinfo.CheckedChanged += new System.EventHandler(this.lessinfo_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(9, 200);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "窗口置顶";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // autocopy
            // 
            this.autocopy.AutoSize = true;
            this.autocopy.Location = new System.Drawing.Point(9, 111);
            this.autocopy.Name = "autocopy";
            this.autocopy.Size = new System.Drawing.Size(91, 24);
            this.autocopy.TabIndex = 7;
            this.autocopy.Text = "自动复制";
            this.autocopy.UseVisualStyleBackColor = true;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(106, 74);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(602, 150);
            this.answer.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "答案";
            // 
            // Keywords
            // 
            this.Keywords.Location = new System.Drawing.Point(106, 26);
            this.Keywords.Name = "Keywords";
            this.Keywords.ReadOnly = true;
            this.Keywords.Size = new System.Drawing.Size(602, 27);
            this.Keywords.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "题目关键词";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 267);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.TokenInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EngineSelection);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "快速搜题助手";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox EngineSelection;
        private System.Windows.Forms.TextBox TokenInput;
        private System.Windows.Forms.CheckBox run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox EngineName;
        private System.Windows.Forms.TextBox EngineVersion;
        private System.Windows.Forms.TextBox EngineProvider;
        private System.Windows.Forms.TextBox EngineMessages;
        private System.Windows.Forms.GroupBox searchbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Keywords;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.CheckBox au;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox co;
        private System.Windows.Forms.CheckBox autocopy;
        private System.Windows.Forms.CheckBox lessinfo;
        public System.Windows.Forms.Timer timer1;
    }
}

