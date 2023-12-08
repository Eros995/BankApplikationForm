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
    public partial class AdminAccountForm : Form
    {
        LoginForm loginForm;

        public AdminAccountForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AdminAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
        }
    }
}
