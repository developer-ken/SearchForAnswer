
namespace SearchForAnswer
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.captchabox = new System.Windows.Forms.PictureBox();
            this.captcha = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchabox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "您选择的引擎要求您登录。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // captchabox
            // 
            this.captchabox.Location = new System.Drawing.Point(12, 98);
            this.captchabox.Name = "captchabox";
            this.captchabox.Size = new System.Drawing.Size(100, 50);
            this.captchabox.TabIndex = 3;
            this.captchabox.TabStop = false;
            // 
            // captcha
            // 
            this.captcha.Location = new System.Drawing.Point(118, 112);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(168, 23);
            this.captcha.TabIndex = 4;
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(61, 63);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '#';
            this.passwd.Size = new System.Drawing.Size(225, 23);
            this.passwd.TabIndex = 5;
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(61, 34);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(225, 23);
            this.uname.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.captchabox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "登录到目标引擎";
            ((System.ComponentModel.ISupportInitialize)(this.captchabox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox captchabox;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Button button1;
    }
}