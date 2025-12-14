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
    public partial class Signup_UC : UserControl
    {
        public Signup_UC()
        {
            InitializeComponent();
        }

        // Go to Log in page
        public delegate void RemoveAndLogin(Object sender);
        public event RemoveAndLogin Signup_to_login;
        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup_to_login(this);
        }
    }
}
