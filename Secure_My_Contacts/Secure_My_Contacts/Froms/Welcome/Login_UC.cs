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
    public partial class Login_UC : UserControl
    {
        public Login_UC()
        {
            InitializeComponent();
        }


        // Log in page to sign up page
        public delegate void RemoveAndSignup(Object sender);
        public event RemoveAndSignup Login_to_Signup;

        private void signup_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_to_Signup(this);
        }
    }
}
