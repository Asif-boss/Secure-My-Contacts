using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_My_Contacts.Froms.Welcome
{
    public partial class Welcome_Window : Form
    {
        public Welcome_Window()
        {
            InitializeComponent();
            // ~ Initialize
            // Welcome
            Welcome_UC welContent = new Welcome_UC();
            welContent.Location = new Point(0, 0);
            this.Controls.Add(welContent);

            // Login
            Login_UC LogContent = new Login_UC();
            LogContent.Location = new Point(0, 0);

            // Sign up
            Signup_UC SignUpContent = new Signup_UC();
            SignUpContent.Location = new Point(0, 0);

            // ~ Button
            // Welcome Yes:
            welContent.Login += delegate (object sender)
            {
                this.Controls.Remove((Welcome_UC)sender);
                this.Controls.Add(LogContent);
            };

            // Welcome No:
            welContent.SignUP += delegate (object sender)
            {
                this.Controls.Remove((Welcome_UC)sender);
                this.Controls.Add(SignUpContent);
            };

            // Sign up to login page
            SignUpContent.Signup_to_login += delegate (object sender)
            {
                this.Controls.Remove((Signup_UC)sender);
                this.Controls.Add(LogContent);
            };

            // Login to sign up page
            LogContent.Login_to_Signup += delegate (object sender)
            {
                this.Controls.Remove((Login_UC)sender);
                this.Controls.Add(SignUpContent);
            };

        }
    }
}
