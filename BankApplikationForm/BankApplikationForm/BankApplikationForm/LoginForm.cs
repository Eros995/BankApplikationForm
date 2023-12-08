using Microsoft.VisualBasic.ApplicationServices;

namespace BankApplikationForm
{
    public partial class LoginForm : Form
    {
        BankManager bankManager = new BankManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm(bankManager);
            newUserForm.ShowDialog();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (userNameTextbox.Text == "admin")
            {
                if (bankManager.LoginAsAdmin(userNameTextbox.Text, passwordTextBox.Text))
                {
                    AdminAccountForm adminForm = new AdminAccountForm(this);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Email or Password");
                }
            }
            else
            {
                if (bankManager.LoginAsUser(userNameTextbox.Text, passwordTextBox.Text))
                {
                    UserAccountForm userForm = new UserAccountForm(this);
                    userForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Email or Password");
                }
            }
        }
    }
}