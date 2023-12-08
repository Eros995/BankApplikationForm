using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplikationForm
{
    public partial class UserAccountForm : Form
    {
        LoginForm loginForm;
        public UserAccountForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
    }
}
