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
    public partial class Welcome_UC : UserControl
    {
        public Welcome_UC()
        {
            InitializeComponent();
        }

        // Go sign up page using No button
        public delegate void RemoveAndSignUP(Object sender);
        public event RemoveAndSignUP SignUP;
        private void No_Button_Click(object sender, EventArgs e)
        {
            SignUP(this);
        }

        // Go login page using Yes button
        public delegate void RemoveAndLogin(Object sender);
        public event RemoveAndLogin Login;

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            Login(this);
        }
    }
}
