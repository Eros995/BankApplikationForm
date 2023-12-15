using Microsoft.VisualBasic.ApplicationServices;

namespace BankApplikationForm
{
    public partial class LoginForm : Form
    {
        BankManager bankManager = new BankManager();
        private User loggedInUser;
        public LoginForm(User user = null)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            userNameTextbox.Text = "";
            passwordTextBox.Text = "";
            NewUserForm newUserForm = new NewUserForm(bankManager);
            newUserForm.ShowDialog();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextbox.Text;
            string password = passwordTextBox.Text;
            bankManager.ReloadUsers();

            if (bankManager.LoginAsAdmin(username, password))
            {
                AdminAccountForm adminForm = new AdminAccountForm(this);
                MessageBox.Show("Welcome Admin!");
                adminForm.Show();
                this.Hide();
            }
            else if (bankManager.LoginAsUser(username, password, out loggedInUser) && loggedInUser != null)
            {
                UserAccountForm userForm = new UserAccountForm(loggedInUser, bankManager, this);
                MessageBox.Show("Welcome " + loggedInUser.Name + "!");
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }

            userNameTextbox.Text = "";
            passwordTextBox.Text = "";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}