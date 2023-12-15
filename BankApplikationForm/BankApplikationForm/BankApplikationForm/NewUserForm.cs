using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplikationForm
{
    public partial class NewUserForm : Form
    {
        BankManager bankManager;
        public NewUserForm(BankManager bankManager)
        {
            InitializeComponent();
            this.bankManager = bankManager;
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (bankManager.CreateNewUser(nameTextbox.Text, passwordTexbox.Text, emailTextbox.Text, addressTextbox.Text))
            {
                MessageBox.Show("New user created!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email already exists");
            }
        }
    }
}
