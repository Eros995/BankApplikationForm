namespace BankApplikationForm
{
    partial class UserAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userTabControl = new TabControl();
            accountTab = new TabPage();
            renameAccountButton = new Button();
            deleteAccountButton = new Button();
            newAccountNameLabel2 = new Label();
            loggedInAsLabel = new Label();
            newAccountNameLabel = new Label();
            newAccountNameTextBox = new TextBox();
            createNewAccountButton = new Button();
            loadAccountButton = new Button();
            accountsLabel = new Label();
            accountsListBox = new ListBox();
            transactionTab = new TabPage();
            userAccountsListBox = new ListBox();
            userListBox = new ListBox();
            balanceLabel = new Label();
            accountIdLabel = new Label();
            accountNameLabel = new Label();
            transferButton = new Button();
            transferTextBox = new TextBox();
            withdrawTextbox = new TextBox();
            depositTextBox = new TextBox();
            withdrawButton = new Button();
            depositButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            settingsTab = new TabPage();
            newEmailTextBox = new TextBox();
            button1 = new Button();
            newAddressTextBox = new TextBox();
            newNameTextBox = new TextBox();
            label4 = new Label();
            userLogOutButton = new Button();
            button4 = new Button();
            confirmTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            currentPasswordTextBox = new TextBox();
            label5 = new Label();
            tabPage1 = new TabPage();
            accountIdLabel2 = new Label();
            balanceLabel2 = new Label();
            accountNameLabel2 = new Label();
            label6 = new Label();
            transactionHistoryListBox = new ListBox();
            userTabControl.SuspendLayout();
            accountTab.SuspendLayout();
            transactionTab.SuspendLayout();
            settingsTab.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // userTabControl
            // 
            userTabControl.Controls.Add(accountTab);
            userTabControl.Controls.Add(transactionTab);
            userTabControl.Controls.Add(settingsTab);
            userTabControl.Controls.Add(tabPage1);
            userTabControl.Dock = DockStyle.Fill;
            userTabControl.Location = new Point(0, 0);
            userTabControl.Margin = new Padding(2);
            userTabControl.Name = "userTabControl";
            userTabControl.SelectedIndex = 0;
            userTabControl.Size = new Size(790, 554);
            userTabControl.TabIndex = 0;
            // 
            // accountTab
            // 
            accountTab.BackColor = SystemColors.InactiveCaption;
            accountTab.Controls.Add(renameAccountButton);
            accountTab.Controls.Add(deleteAccountButton);
            accountTab.Controls.Add(newAccountNameLabel2);
            accountTab.Controls.Add(loggedInAsLabel);
            accountTab.Controls.Add(newAccountNameLabel);
            accountTab.Controls.Add(newAccountNameTextBox);
            accountTab.Controls.Add(createNewAccountButton);
            accountTab.Controls.Add(loadAccountButton);
            accountTab.Controls.Add(accountsLabel);
            accountTab.Controls.Add(accountsListBox);
            accountTab.Location = new Point(4, 29);
            accountTab.Margin = new Padding(2);
            accountTab.Name = "accountTab";
            accountTab.Padding = new Padding(2);
            accountTab.Size = new Size(782, 521);
            accountTab.TabIndex = 0;
            accountTab.Text = "Account";
            // 
            // renameAccountButton
            // 
            renameAccountButton.Location = new Point(155, 394);
            renameAccountButton.Margin = new Padding(3, 2, 3, 2);
            renameAccountButton.Name = "renameAccountButton";
            renameAccountButton.Size = new Size(123, 30);
            renameAccountButton.TabIndex = 9;
            renameAccountButton.Text = "Rename Account";
            renameAccountButton.UseVisualStyleBackColor = true;
            renameAccountButton.Click += renameAccountButton_Click;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.Location = new Point(290, 394);
            deleteAccountButton.Margin = new Padding(3, 2, 3, 2);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(113, 30);
            deleteAccountButton.TabIndex = 8;
            deleteAccountButton.Text = "Delete Account";
            deleteAccountButton.UseVisualStyleBackColor = true;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // newAccountNameLabel2
            // 
            newAccountNameLabel2.AutoSize = true;
            newAccountNameLabel2.Location = new Point(494, 328);
            newAccountNameLabel2.Name = "newAccountNameLabel2";
            newAccountNameLabel2.Size = new Size(222, 20);
            newAccountNameLabel2.TabIndex = 7;
            newAccountNameLabel2.Text = "Press enter to confirm the name.";
            newAccountNameLabel2.Visible = false;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Location = new Point(520, 152);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(147, 20);
            loggedInAsLabel.TabIndex = 6;
            loggedInAsLabel.Text = "You are logged in as:";
            // 
            // newAccountNameLabel
            // 
            newAccountNameLabel.AutoSize = true;
            newAccountNameLabel.Location = new Point(467, 298);
            newAccountNameLabel.Name = "newAccountNameLabel";
            newAccountNameLabel.Size = new Size(270, 20);
            newAccountNameLabel.TabIndex = 5;
            newAccountNameLabel.Text = "Please enter the name for your account.";
            newAccountNameLabel.Visible = false;
            // 
            // newAccountNameTextBox
            // 
            newAccountNameTextBox.Location = new Point(534, 360);
            newAccountNameTextBox.Margin = new Padding(3, 2, 3, 2);
            newAccountNameTextBox.Name = "newAccountNameTextBox";
            newAccountNameTextBox.Size = new Size(125, 27);
            newAccountNameTextBox.TabIndex = 4;
            newAccountNameTextBox.Visible = false;
            newAccountNameTextBox.KeyPress += accountNameTextBox_KeyPress;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.Location = new Point(520, 394);
            createNewAccountButton.Margin = new Padding(3, 2, 3, 2);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Size = new Size(151, 30);
            createNewAccountButton.TabIndex = 3;
            createNewAccountButton.Text = "Create new account";
            createNewAccountButton.UseVisualStyleBackColor = true;
            createNewAccountButton.Click += createNewAccountButton_Click;
            // 
            // loadAccountButton
            // 
            loadAccountButton.Location = new Point(34, 394);
            loadAccountButton.Margin = new Padding(3, 2, 3, 2);
            loadAccountButton.Name = "loadAccountButton";
            loadAccountButton.Size = new Size(110, 30);
            loadAccountButton.TabIndex = 2;
            loadAccountButton.Text = "Load Account";
            loadAccountButton.UseVisualStyleBackColor = true;
            loadAccountButton.Click += loadAccountButton_Click;
            // 
            // accountsLabel
            // 
            accountsLabel.AutoSize = true;
            accountsLabel.Location = new Point(34, 42);
            accountsLabel.Name = "accountsLabel";
            accountsLabel.Size = new Size(69, 20);
            accountsLabel.TabIndex = 1;
            accountsLabel.Text = "Accounts";
            // 
            // accountsListBox
            // 
            accountsListBox.FormattingEnabled = true;
            accountsListBox.ItemHeight = 20;
            accountsListBox.Location = new Point(34, 84);
            accountsListBox.Margin = new Padding(3, 2, 3, 2);
            accountsListBox.Name = "accountsListBox";
            accountsListBox.Size = new Size(351, 244);
            accountsListBox.TabIndex = 0;
            accountsListBox.SelectedIndexChanged += accountsListBox_SelectedIndexChanged;
            // 
            // transactionTab
            // 
            transactionTab.BackColor = SystemColors.InactiveCaption;
            transactionTab.Controls.Add(userAccountsListBox);
            transactionTab.Controls.Add(userListBox);
            transactionTab.Controls.Add(balanceLabel);
            transactionTab.Controls.Add(accountIdLabel);
            transactionTab.Controls.Add(accountNameLabel);
            transactionTab.Controls.Add(transferButton);
            transactionTab.Controls.Add(transferTextBox);
            transactionTab.Controls.Add(withdrawTextbox);
            transactionTab.Controls.Add(depositTextBox);
            transactionTab.Controls.Add(withdrawButton);
            transactionTab.Controls.Add(depositButton);
            transactionTab.Controls.Add(label3);
            transactionTab.Controls.Add(label2);
            transactionTab.Controls.Add(label1);
            transactionTab.Location = new Point(4, 29);
            transactionTab.Margin = new Padding(2);
            transactionTab.Name = "transactionTab";
            transactionTab.Padding = new Padding(2);
            transactionTab.Size = new Size(782, 521);
            transactionTab.TabIndex = 1;
            transactionTab.Text = "Transactions";
            // 
            // userAccountsListBox
            // 
            userAccountsListBox.FormattingEnabled = true;
            userAccountsListBox.ItemHeight = 20;
            userAccountsListBox.Location = new Point(433, 410);
            userAccountsListBox.Margin = new Padding(3, 4, 3, 4);
            userAccountsListBox.Name = "userAccountsListBox";
            userAccountsListBox.Size = new Size(284, 84);
            userAccountsListBox.TabIndex = 18;
            // 
            // userListBox
            // 
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 20;
            userListBox.Location = new Point(505, 298);
            userListBox.Margin = new Padding(3, 4, 3, 4);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(137, 104);
            userListBox.TabIndex = 17;
            userListBox.SelectedIndexChanged += userListBox_SelectedIndexChanged;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.Location = new Point(296, 68);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(69, 23);
            balanceLabel.TabIndex = 16;
            balanceLabel.Text = "Balance";
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdLabel.Location = new Point(505, 68);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(93, 23);
            accountIdLabel.TabIndex = 15;
            accountIdLabel.Text = "Account Id";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel.Location = new Point(101, 68);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(119, 23);
            accountNameLabel.TabIndex = 14;
            accountNameLabel.Text = "AccountName";
            // 
            // transferButton
            // 
            transferButton.Location = new Point(505, 252);
            transferButton.Margin = new Padding(2);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(90, 26);
            transferButton.TabIndex = 13;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // transferTextBox
            // 
            transferTextBox.Location = new Point(505, 202);
            transferTextBox.Margin = new Padding(2);
            transferTextBox.Name = "transferTextBox";
            transferTextBox.PlaceholderText = "Amount";
            transferTextBox.Size = new Size(121, 27);
            transferTextBox.TabIndex = 11;
            transferTextBox.KeyPress += transferTextBox_KeyPress;
            // 
            // withdrawTextbox
            // 
            withdrawTextbox.Location = new Point(281, 282);
            withdrawTextbox.Margin = new Padding(2);
            withdrawTextbox.Name = "withdrawTextbox";
            withdrawTextbox.PlaceholderText = "Amount";
            withdrawTextbox.Size = new Size(121, 27);
            withdrawTextbox.TabIndex = 9;
            withdrawTextbox.KeyPress += withdrawTextbox_KeyPress;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(86, 282);
            depositTextBox.Margin = new Padding(2);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.PlaceholderText = "Amount";
            depositTextBox.Size = new Size(121, 27);
            depositTextBox.TabIndex = 8;
            depositTextBox.KeyPress += depositTextBox_KeyPress;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(281, 330);
            withdrawButton.Margin = new Padding(2);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(90, 26);
            withdrawButton.TabIndex = 7;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(86, 330);
            depositButton.Margin = new Padding(2);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(90, 26);
            depositButton.TabIndex = 6;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(505, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 3;
            label3.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 238);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 2;
            label2.Text = "Withdraw";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 238);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 1;
            label1.Text = "Deposit";
            // 
            // settingsTab
            // 
            settingsTab.BackColor = SystemColors.InactiveCaption;
            settingsTab.Controls.Add(newEmailTextBox);
            settingsTab.Controls.Add(button1);
            settingsTab.Controls.Add(newAddressTextBox);
            settingsTab.Controls.Add(newNameTextBox);
            settingsTab.Controls.Add(label4);
            settingsTab.Controls.Add(userLogOutButton);
            settingsTab.Controls.Add(button4);
            settingsTab.Controls.Add(confirmTextBox);
            settingsTab.Controls.Add(newPasswordTextBox);
            settingsTab.Controls.Add(currentPasswordTextBox);
            settingsTab.Controls.Add(label5);
            settingsTab.Location = new Point(4, 29);
            settingsTab.Margin = new Padding(2);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(2);
            settingsTab.Size = new Size(782, 521);
            settingsTab.TabIndex = 2;
            settingsTab.Text = "Settings";
            // 
            // newEmailTextBox
            // 
            newEmailTextBox.Location = new Point(523, 181);
            newEmailTextBox.Name = "newEmailTextBox";
            newEmailTextBox.PlaceholderText = "Email";
            newEmailTextBox.Size = new Size(175, 27);
            newEmailTextBox.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(523, 322);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(163, 30);
            button1.TabIndex = 14;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += changeUserInformation_click;
            // 
            // newAddressTextBox
            // 
            newAddressTextBox.Location = new Point(523, 234);
            newAddressTextBox.Margin = new Padding(2);
            newAddressTextBox.Name = "newAddressTextBox";
            newAddressTextBox.PlaceholderText = "Address";
            newAddressTextBox.Size = new Size(175, 27);
            newAddressTextBox.TabIndex = 13;
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(523, 130);
            newNameTextBox.Margin = new Padding(2);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.PlaceholderText = "Name";
            newNameTextBox.Size = new Size(175, 27);
            newNameTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(523, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 10;
            label4.Text = "Update Information";
            // 
            // userLogOutButton
            // 
            userLogOutButton.Location = new Point(584, 446);
            userLogOutButton.Margin = new Padding(2);
            userLogOutButton.Name = "userLogOutButton";
            userLogOutButton.Size = new Size(115, 30);
            userLogOutButton.TabIndex = 9;
            userLogOutButton.Text = "Log out";
            userLogOutButton.UseVisualStyleBackColor = true;
            userLogOutButton.Click += userLogOutButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(73, 322);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(163, 30);
            button4.TabIndex = 4;
            button4.Text = "Update Password";
            button4.UseVisualStyleBackColor = true;
            button4.Click += UpdatePassword_click;
            // 
            // confirmTextBox
            // 
            confirmTextBox.Location = new Point(73, 234);
            confirmTextBox.Margin = new Padding(2);
            confirmTextBox.Name = "confirmTextBox";
            confirmTextBox.PlaceholderText = "Confirm password";
            confirmTextBox.Size = new Size(175, 27);
            confirmTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(73, 182);
            newPasswordTextBox.Margin = new Padding(2);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "New password";
            newPasswordTextBox.Size = new Size(175, 27);
            newPasswordTextBox.TabIndex = 2;
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Location = new Point(73, 130);
            currentPasswordTextBox.Margin = new Padding(2);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.PlaceholderText = "Current password";
            currentPasswordTextBox.Size = new Size(175, 27);
            currentPasswordTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 70);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 0;
            label5.Text = "Change Password";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveCaption;
            tabPage1.Controls.Add(accountIdLabel2);
            tabPage1.Controls.Add(balanceLabel2);
            tabPage1.Controls.Add(accountNameLabel2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(transactionHistoryListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(782, 521);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Transaction History";
            // 
            // accountIdLabel2
            // 
            accountIdLabel2.AutoSize = true;
            accountIdLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdLabel2.Location = new Point(34, 328);
            accountIdLabel2.Name = "accountIdLabel2";
            accountIdLabel2.Size = new Size(104, 23);
            accountIdLabel2.TabIndex = 4;
            accountIdLabel2.Text = "Account ID: ";
            // 
            // balanceLabel2
            // 
            balanceLabel2.AutoSize = true;
            balanceLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel2.Location = new Point(34, 252);
            balanceLabel2.Name = "balanceLabel2";
            balanceLabel2.Size = new Size(73, 23);
            balanceLabel2.TabIndex = 3;
            balanceLabel2.Text = "Balance:";
            // 
            // accountNameLabel2
            // 
            accountNameLabel2.AutoSize = true;
            accountNameLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel2.Location = new Point(34, 178);
            accountNameLabel2.Name = "accountNameLabel2";
            accountNameLabel2.Size = new Size(128, 23);
            accountNameLabel2.TabIndex = 2;
            accountNameLabel2.Text = "Account Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(376, 82);
            label6.Name = "label6";
            label6.Size = new Size(216, 32);
            label6.TabIndex = 1;
            label6.Text = "Transaction History";
            // 
            // transactionHistoryListBox
            // 
            transactionHistoryListBox.FormattingEnabled = true;
            transactionHistoryListBox.ItemHeight = 20;
            transactionHistoryListBox.Location = new Point(233, 178);
            transactionHistoryListBox.Margin = new Padding(3, 4, 3, 4);
            transactionHistoryListBox.Name = "transactionHistoryListBox";
            transactionHistoryListBox.Size = new Size(500, 264);
            transactionHistoryListBox.TabIndex = 0;
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 554);
            Controls.Add(userTabControl);
            Margin = new Padding(2);
            Name = "UserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            FormClosing += UserAccountForm_FormClosing;
            userTabControl.ResumeLayout(false);
            accountTab.ResumeLayout(false);
            accountTab.PerformLayout();
            transactionTab.ResumeLayout(false);
            transactionTab.PerformLayout();
            settingsTab.ResumeLayout(false);
            settingsTab.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl userTabControl;
        private TabPage accountTab;
        private Button loadAccountButton;
        private Label accountsLabel;
        private ListBox accountsListBox;
        private Button createNewAccountButton;
        private Label newAccountNameLabel;
        private TextBox newAccountNameTextBox;
        private Label loggedInAsLabel;
        private Label newAccountNameLabel2;
        private TabPage transactionTab;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage settingsTab;
        private Button withdrawButton;
        private Button depositButton;
        private TextBox transferTextBox;
        private TextBox withdrawTextbox;
        private TextBox depositTextBox;
        private Button transferButton;
        private Button button4;
        private TextBox confirmTextBox;
        private TextBox newPasswordTextBox;
        private TextBox currentPasswordTextBox;
        private Label label5;
        private Button userLogOutButton;
        private Label balanceLabel;
        private Label accountIdLabel;
        private Label accountNameLabel;
        private Button renameAccountButton;
        private Button deleteAccountButton;
        private ListBox userListBox;
        private ListBox userAccountsListBox;
        private Button button1;
        private TextBox newAddressTextBox;
        private TextBox newNameTextBox;
        private Label label4;
        private TabPage tabPage1;
        private Label label6;
        private ListBox transactionHistoryListBox;
        private Label accountInfoLabel;
        private Label accountNameLabel2;
        private Label accountIdLabel2;
        private Label balanceLabel2;
        private TextBox newEmailTextBox;
    }
}