using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchForAnswer
{
    public partial class Login : Form
    {
        public string Username { private set; get; }
        public string Password { private set; get; }
        public string Captcha { private set; get; }
        public Login(Bitmap captcha)
        {
            InitializeComponent();
            if (captcha == null)
            {
                this.captcha.Enabled = false;
                this.captcha.Text = "无需验证码";
                this.captchabox.Enabled = false;
            }
            else
            {
                this.captcha.Enabled = true;
                this.captcha.Text = "";
                this.captchabox.Enabled = true;
                this.captchabox.Image = captcha;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = uname.Text;
            Password = passwd.Text;
            Captcha = captcha.Enabled ? captcha.Text : null;
            Close();
        }
    }
}
