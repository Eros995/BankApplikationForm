using Microsoft.VisualBasic.ApplicationServices;

namespace BankApplikationForm
{
    public partial class loginForm : Form
    {
        BankManager bankManager = new BankManager();
        public loginForm()
        {
            InitializeComponent();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm(bankManager);
            newUserForm.ShowDialog();

        }
    }
}