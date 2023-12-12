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
            ChangePassword = new Button();
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
            button1 = new Button();
            newAddressTextBox = new TextBox();
            newNameTextBox = new TextBox();
            label4 = new Label();
            button6 = new Button();
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
            userTabControl.Name = "userTabControl";
            userTabControl.SelectedIndex = 0;
            userTabControl.Size = new Size(987, 692);
            userTabControl.TabIndex = 0;
            // 
            // accountTab
            // 
            accountTab.BackColor = SystemColors.InactiveCaption;
            accountTab.Controls.Add(ChangePassword);
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
            accountTab.Location = new Point(4, 34);
            accountTab.Name = "accountTab";
            accountTab.Padding = new Padding(3);
            accountTab.Size = new Size(979, 654);
            accountTab.TabIndex = 0;
            accountTab.Text = "Account";
            // 
            // ChangePassword
            // 
            ChangePassword.Location = new Point(43, 563);
            ChangePassword.Margin = new Padding(4, 3, 4, 3);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(222, 37);
            ChangePassword.TabIndex = 10;
            ChangePassword.Text = "Change Password";
            ChangePassword.UseVisualStyleBackColor = true;
            // 
            // renameAccountButton
            // 
            renameAccountButton.Location = new Point(194, 493);
            renameAccountButton.Margin = new Padding(4, 3, 4, 3);
            renameAccountButton.Name = "renameAccountButton";
            renameAccountButton.Size = new Size(154, 37);
            renameAccountButton.TabIndex = 9;
            renameAccountButton.Text = "Rename Account";
            renameAccountButton.UseVisualStyleBackColor = true;
            renameAccountButton.Click += renameAccountButton_Click;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.Location = new Point(363, 493);
            deleteAccountButton.Margin = new Padding(4, 3, 4, 3);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(141, 37);
            deleteAccountButton.TabIndex = 8;
            deleteAccountButton.Text = "Delete Account";
            deleteAccountButton.UseVisualStyleBackColor = true;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // newAccountNameLabel2
            // 
            newAccountNameLabel2.AutoSize = true;
            newAccountNameLabel2.Location = new Point(617, 410);
            newAccountNameLabel2.Margin = new Padding(4, 0, 4, 0);
            newAccountNameLabel2.Name = "newAccountNameLabel2";
            newAccountNameLabel2.Size = new Size(269, 25);
            newAccountNameLabel2.TabIndex = 7;
            newAccountNameLabel2.Text = "Press enter to confirm the name.";
            newAccountNameLabel2.Visible = false;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Location = new Point(650, 190);
            loggedInAsLabel.Margin = new Padding(4, 0, 4, 0);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(177, 25);
            loggedInAsLabel.TabIndex = 6;
            loggedInAsLabel.Text = "You are logged in as:";
            // 
            // newAccountNameLabel
            // 
            newAccountNameLabel.AutoSize = true;
            newAccountNameLabel.Location = new Point(584, 372);
            newAccountNameLabel.Margin = new Padding(4, 0, 4, 0);
            newAccountNameLabel.Name = "newAccountNameLabel";
            newAccountNameLabel.Size = new Size(325, 25);
            newAccountNameLabel.TabIndex = 5;
            newAccountNameLabel.Text = "Please enter the name for your account.";
            newAccountNameLabel.Visible = false;
            // 
            // newAccountNameTextBox
            // 
            newAccountNameTextBox.Location = new Point(667, 450);
            newAccountNameTextBox.Margin = new Padding(4, 3, 4, 3);
            newAccountNameTextBox.Name = "newAccountNameTextBox";
            newAccountNameTextBox.Size = new Size(155, 31);
            newAccountNameTextBox.TabIndex = 4;
            newAccountNameTextBox.Visible = false;
            newAccountNameTextBox.KeyPress += accountNameTextBox_KeyPress;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.Location = new Point(650, 492);
            createNewAccountButton.Margin = new Padding(4, 3, 4, 3);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Size = new Size(189, 37);
            createNewAccountButton.TabIndex = 3;
            createNewAccountButton.Text = "Create new account";
            createNewAccountButton.UseVisualStyleBackColor = true;
            createNewAccountButton.Click += createNewAccountButton_Click;
            // 
            // loadAccountButton
            // 
            loadAccountButton.Location = new Point(43, 493);
            loadAccountButton.Margin = new Padding(4, 3, 4, 3);
            loadAccountButton.Name = "loadAccountButton";
            loadAccountButton.Size = new Size(137, 37);
            loadAccountButton.TabIndex = 2;
            loadAccountButton.Text = "Load Account";
            loadAccountButton.UseVisualStyleBackColor = true;
            loadAccountButton.Click += loadAccountButton_Click;
            // 
            // accountsLabel
            // 
            accountsLabel.AutoSize = true;
            accountsLabel.Location = new Point(43, 52);
            accountsLabel.Margin = new Padding(4, 0, 4, 0);
            accountsLabel.Name = "accountsLabel";
            accountsLabel.Size = new Size(85, 25);
            accountsLabel.TabIndex = 1;
            accountsLabel.Text = "Accounts";
            // 
            // accountsListBox
            // 
            accountsListBox.FormattingEnabled = true;
            accountsListBox.ItemHeight = 25;
            accountsListBox.Location = new Point(43, 105);
            accountsListBox.Margin = new Padding(4, 3, 4, 3);
            accountsListBox.Name = "accountsListBox";
            accountsListBox.Size = new Size(438, 304);
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
            transactionTab.Location = new Point(4, 34);
            transactionTab.Name = "transactionTab";
            transactionTab.Padding = new Padding(3);
            transactionTab.Size = new Size(979, 654);
            transactionTab.TabIndex = 1;
            transactionTab.Text = "Transactions";
            // 
            // userAccountsListBox
            // 
            userAccountsListBox.FormattingEnabled = true;
            userAccountsListBox.ItemHeight = 25;
            userAccountsListBox.Location = new Point(541, 513);
            userAccountsListBox.Margin = new Padding(4, 5, 4, 5);
            userAccountsListBox.Name = "userAccountsListBox";
            userAccountsListBox.Size = new Size(354, 104);
            userAccountsListBox.TabIndex = 18;
            // 
            // userListBox
            // 
            userListBox.FormattingEnabled = true;
            userListBox.ItemHeight = 25;
            userListBox.Location = new Point(631, 372);
            userListBox.Margin = new Padding(4, 5, 4, 5);
            userListBox.Name = "userListBox";
            userListBox.Size = new Size(170, 129);
            userListBox.TabIndex = 17;
            userListBox.SelectedIndexChanged += userListBox_SelectedIndexChanged;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.Location = new Point(370, 85);
            balanceLabel.Margin = new Padding(4, 0, 4, 0);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(78, 28);
            balanceLabel.TabIndex = 16;
            balanceLabel.Text = "Balance";
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdLabel.Location = new Point(631, 85);
            accountIdLabel.Margin = new Padding(4, 0, 4, 0);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(106, 28);
            accountIdLabel.TabIndex = 15;
            accountIdLabel.Text = "Account Id";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel.Location = new Point(126, 85);
            accountNameLabel.Margin = new Padding(4, 0, 4, 0);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(136, 28);
            accountNameLabel.TabIndex = 14;
            accountNameLabel.Text = "AccountName";
            // 
            // transferButton
            // 
            transferButton.Location = new Point(631, 315);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(113, 33);
            transferButton.TabIndex = 13;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // transferTextBox
            // 
            transferTextBox.Location = new Point(631, 253);
            transferTextBox.Name = "transferTextBox";
            transferTextBox.PlaceholderText = "Amount";
            transferTextBox.Size = new Size(150, 31);
            transferTextBox.TabIndex = 11;
            transferTextBox.KeyPress += transferTextBox_KeyPress;
            // 
            // withdrawTextbox
            // 
            withdrawTextbox.Location = new Point(351, 352);
            withdrawTextbox.Name = "withdrawTextbox";
            withdrawTextbox.PlaceholderText = "Amount";
            withdrawTextbox.Size = new Size(150, 31);
            withdrawTextbox.TabIndex = 9;
            withdrawTextbox.KeyPress += withdrawTextbox_KeyPress;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(107, 352);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.PlaceholderText = "Amount";
            depositTextBox.Size = new Size(150, 31);
            depositTextBox.TabIndex = 8;
            depositTextBox.KeyPress += depositTextBox_KeyPress;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(351, 413);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(113, 33);
            withdrawButton.TabIndex = 7;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(107, 413);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(113, 33);
            depositButton.TabIndex = 6;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(631, 198);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 3;
            label3.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(351, 297);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 2;
            label2.Text = "Withdraw";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 297);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 1;
            label1.Text = "Deposit";
            // 
            // settingsTab
            // 
            settingsTab.BackColor = SystemColors.InactiveCaption;
            settingsTab.Controls.Add(button1);
            settingsTab.Controls.Add(newAddressTextBox);
            settingsTab.Controls.Add(newNameTextBox);
            settingsTab.Controls.Add(label4);
            settingsTab.Controls.Add(button6);
            settingsTab.Controls.Add(button4);
            settingsTab.Controls.Add(confirmTextBox);
            settingsTab.Controls.Add(newPasswordTextBox);
            settingsTab.Controls.Add(currentPasswordTextBox);
            settingsTab.Controls.Add(label5);
            settingsTab.Location = new Point(4, 34);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(3);
            settingsTab.Size = new Size(979, 654);
            settingsTab.TabIndex = 2;
            settingsTab.Text = "Settings";
            // 
            // button1
            // 
            button1.Location = new Point(654, 402);
            button1.Name = "button1";
            button1.Size = new Size(204, 38);
            button1.TabIndex = 14;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += changeUserInformation_click;
            // 
            // newAddressTextBox
            // 
            newAddressTextBox.Location = new Point(654, 293);
            newAddressTextBox.Name = "newAddressTextBox";
            newAddressTextBox.PlaceholderText = "Address";
            newAddressTextBox.Size = new Size(218, 31);
            newAddressTextBox.TabIndex = 13;
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(654, 162);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.PlaceholderText = "Name";
            newNameTextBox.Size = new Size(218, 31);
            newNameTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(654, 88);
            label4.Name = "label4";
            label4.Size = new Size(203, 30);
            label4.TabIndex = 10;
            label4.Text = "Update Information";
            // 
            // button6
            // 
            button6.Location = new Point(730, 558);
            button6.Name = "button6";
            button6.Size = new Size(144, 38);
            button6.TabIndex = 9;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(91, 402);
            button4.Name = "button4";
            button4.Size = new Size(204, 38);
            button4.TabIndex = 4;
            button4.Text = "Update Password";
            button4.UseVisualStyleBackColor = true;
            button4.Click += UpdatePassword_click;
            // 
            // confirmTextBox
            // 
            confirmTextBox.Location = new Point(91, 293);
            confirmTextBox.Name = "confirmTextBox";
            confirmTextBox.PlaceholderText = "Confirm password";
            confirmTextBox.Size = new Size(218, 31);
            confirmTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(91, 228);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "New password";
            newPasswordTextBox.Size = new Size(218, 31);
            newPasswordTextBox.TabIndex = 2;
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Location = new Point(91, 162);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.PlaceholderText = "Current password";
            currentPasswordTextBox.Size = new Size(218, 31);
            currentPasswordTextBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(91, 88);
            label5.Name = "label5";
            label5.Size = new Size(183, 30);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(979, 654);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Transaction History";
            // 
            // accountIdLabel2
            // 
            accountIdLabel2.AutoSize = true;
            accountIdLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdLabel2.Location = new Point(43, 410);
            accountIdLabel2.Margin = new Padding(4, 0, 4, 0);
            accountIdLabel2.Name = "accountIdLabel2";
            accountIdLabel2.Size = new Size(117, 28);
            accountIdLabel2.TabIndex = 4;
            accountIdLabel2.Text = "Account ID: ";
            // 
            // balanceLabel2
            // 
            balanceLabel2.AutoSize = true;
            balanceLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel2.Location = new Point(43, 315);
            balanceLabel2.Margin = new Padding(4, 0, 4, 0);
            balanceLabel2.Name = "balanceLabel2";
            balanceLabel2.Size = new Size(82, 28);
            balanceLabel2.TabIndex = 3;
            balanceLabel2.Text = "Balance:";
            // 
            // accountNameLabel2
            // 
            accountNameLabel2.AutoSize = true;
            accountNameLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel2.Location = new Point(43, 222);
            accountNameLabel2.Margin = new Padding(4, 0, 4, 0);
            accountNameLabel2.Name = "accountNameLabel2";
            accountNameLabel2.Size = new Size(145, 28);
            accountNameLabel2.TabIndex = 2;
            accountNameLabel2.Text = "Account Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(470, 102);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(253, 38);
            label6.TabIndex = 1;
            label6.Text = "Transaction History";
            // 
            // transactionHistoryListBox
            // 
            transactionHistoryListBox.FormattingEnabled = true;
            transactionHistoryListBox.ItemHeight = 25;
            transactionHistoryListBox.Location = new Point(291, 222);
            transactionHistoryListBox.Margin = new Padding(4, 5, 4, 5);
            transactionHistoryListBox.Name = "transactionHistoryListBox";
            transactionHistoryListBox.Size = new Size(624, 329);
            transactionHistoryListBox.TabIndex = 0;
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 692);
            Controls.Add(userTabControl);
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
        private Button button6;
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
        private Button ChangePassword;
    }
}