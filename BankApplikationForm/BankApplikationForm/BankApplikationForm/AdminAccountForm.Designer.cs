namespace BankApplikationForm
{
    partial class AdminAccountForm
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
            userInfoTab = new TabPage();
            updateUsersInfoButton = new Button();
            changeUserPasswordButton = new Button();
            usersAdressLabel = new Label();
            usersPasswordLabel = new Label();
            usersAddressTextBox = new TextBox();
            usersEmailTextBox = new TextBox();
            usersNameTextBox = new TextBox();
            confirmPasswordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            currentPasswordTextBox = new TextBox();
            usersIdLabel = new Label();
            usersEmailLabel = new Label();
            usersNameLabel = new Label();
            updateUserInfoLabel = new Label();
            changeUserPasswordLabel = new Label();
            label1 = new Label();
            userSettingLabel = new Label();
            tabPage1 = new TabPage();
            deleteUserButton = new Button();
            listBox2 = new ListBox();
            loadUserButton = new Button();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            adminLogOutButton = new Button();
            userInfoTab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // userInfoTab
            // 
            userInfoTab.BackColor = SystemColors.InactiveCaption;
            userInfoTab.Controls.Add(updateUsersInfoButton);
            userInfoTab.Controls.Add(changeUserPasswordButton);
            userInfoTab.Controls.Add(usersAdressLabel);
            userInfoTab.Controls.Add(usersPasswordLabel);
            userInfoTab.Controls.Add(usersAddressTextBox);
            userInfoTab.Controls.Add(usersEmailTextBox);
            userInfoTab.Controls.Add(usersNameTextBox);
            userInfoTab.Controls.Add(confirmPasswordTextBox);
            userInfoTab.Controls.Add(newPasswordTextBox);
            userInfoTab.Controls.Add(currentPasswordTextBox);
            userInfoTab.Controls.Add(usersIdLabel);
            userInfoTab.Controls.Add(usersEmailLabel);
            userInfoTab.Controls.Add(usersNameLabel);
            userInfoTab.Controls.Add(updateUserInfoLabel);
            userInfoTab.Controls.Add(changeUserPasswordLabel);
            userInfoTab.Controls.Add(label1);
            userInfoTab.Controls.Add(userSettingLabel);
            userInfoTab.Location = new Point(4, 29);
            userInfoTab.Margin = new Padding(2, 3, 2, 3);
            userInfoTab.Name = "userInfoTab";
            userInfoTab.Padding = new Padding(2, 3, 2, 3);
            userInfoTab.Size = new Size(729, 516);
            userInfoTab.TabIndex = 3;
            userInfoTab.Text = "Change User info";
            // 
            // updateUsersInfoButton
            // 
            updateUsersInfoButton.Location = new Point(504, 327);
            updateUsersInfoButton.Name = "updateUsersInfoButton";
            updateUsersInfoButton.Size = new Size(183, 29);
            updateUsersInfoButton.TabIndex = 16;
            updateUsersInfoButton.Text = "Update user information";
            updateUsersInfoButton.UseVisualStyleBackColor = true;
            updateUsersInfoButton.Click += updateUsersInfoButton_Click;
            // 
            // changeUserPasswordButton
            // 
            changeUserPasswordButton.Location = new Point(269, 327);
            changeUserPasswordButton.Name = "changeUserPasswordButton";
            changeUserPasswordButton.Size = new Size(168, 29);
            changeUserPasswordButton.TabIndex = 15;
            changeUserPasswordButton.Text = "Change user Password";
            changeUserPasswordButton.UseVisualStyleBackColor = true;
            changeUserPasswordButton.Click += changeUserPasswordButton_Click;
            // 
            // usersAdressLabel
            // 
            usersAdressLabel.AutoSize = true;
            usersAdressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersAdressLabel.Location = new Point(8, 264);
            usersAdressLabel.Name = "usersAdressLabel";
            usersAdressLabel.Size = new Size(86, 20);
            usersAdressLabel.TabIndex = 14;
            usersAdressLabel.Text = "User Adress";
            // 
            // usersPasswordLabel
            // 
            usersPasswordLabel.AutoSize = true;
            usersPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersPasswordLabel.Location = new Point(8, 376);
            usersPasswordLabel.Name = "usersPasswordLabel";
            usersPasswordLabel.Size = new Size(105, 20);
            usersPasswordLabel.TabIndex = 13;
            usersPasswordLabel.Text = "User password";
            // 
            // usersAddressTextBox
            // 
            usersAddressTextBox.Location = new Point(504, 264);
            usersAddressTextBox.Name = "usersAddressTextBox";
            usersAddressTextBox.PlaceholderText = "Adress";
            usersAddressTextBox.Size = new Size(217, 27);
            usersAddressTextBox.TabIndex = 12;
            // 
            // usersEmailTextBox
            // 
            usersEmailTextBox.Location = new Point(504, 206);
            usersEmailTextBox.Name = "usersEmailTextBox";
            usersEmailTextBox.PlaceholderText = "Email";
            usersEmailTextBox.Size = new Size(217, 27);
            usersEmailTextBox.TabIndex = 11;
            // 
            // usersNameTextBox
            // 
            usersNameTextBox.Location = new Point(504, 147);
            usersNameTextBox.Name = "usersNameTextBox";
            usersNameTextBox.PlaceholderText = "Name";
            usersNameTextBox.Size = new Size(217, 27);
            usersNameTextBox.TabIndex = 10;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(269, 264);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PlaceholderText = "Confirm password";
            confirmPasswordTextBox.Size = new Size(168, 27);
            confirmPasswordTextBox.TabIndex = 9;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(269, 206);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "New password";
            newPasswordTextBox.Size = new Size(168, 27);
            newPasswordTextBox.TabIndex = 8;
            // 
            // currentPasswordTextBox
            // 
            currentPasswordTextBox.Location = new Point(269, 146);
            currentPasswordTextBox.Name = "currentPasswordTextBox";
            currentPasswordTextBox.PlaceholderText = "Current password";
            currentPasswordTextBox.Size = new Size(168, 27);
            currentPasswordTextBox.TabIndex = 7;
            // 
            // usersIdLabel
            // 
            usersIdLabel.AutoSize = true;
            usersIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersIdLabel.Location = new Point(8, 315);
            usersIdLabel.Name = "usersIdLabel";
            usersIdLabel.Size = new Size(55, 20);
            usersIdLabel.TabIndex = 6;
            usersIdLabel.Text = "User Id";
            // 
            // usersEmailLabel
            // 
            usersEmailLabel.AutoSize = true;
            usersEmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersEmailLabel.Location = new Point(8, 206);
            usersEmailLabel.Name = "usersEmailLabel";
            usersEmailLabel.Size = new Size(79, 20);
            usersEmailLabel.TabIndex = 5;
            usersEmailLabel.Text = "User email";
            // 
            // usersNameLabel
            // 
            usersNameLabel.AutoSize = true;
            usersNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersNameLabel.Location = new Point(8, 146);
            usersNameLabel.Name = "usersNameLabel";
            usersNameLabel.Size = new Size(79, 20);
            usersNameLabel.TabIndex = 4;
            usersNameLabel.Text = "User name";
            // 
            // updateUserInfoLabel
            // 
            updateUserInfoLabel.AutoSize = true;
            updateUserInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateUserInfoLabel.Location = new Point(495, 86);
            updateUserInfoLabel.Name = "updateUserInfoLabel";
            updateUserInfoLabel.Size = new Size(226, 28);
            updateUserInfoLabel.TabIndex = 3;
            updateUserInfoLabel.Text = "Update user information";
            // 
            // changeUserPasswordLabel
            // 
            changeUserPasswordLabel.AutoSize = true;
            changeUserPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeUserPasswordLabel.Location = new Point(256, 86);
            changeUserPasswordLabel.Name = "changeUserPasswordLabel";
            changeUserPasswordLabel.Size = new Size(207, 28);
            changeUserPasswordLabel.TabIndex = 2;
            changeUserPasswordLabel.Text = "Change user password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 86);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 1;
            label1.Text = "Current user information";
            // 
            // userSettingLabel
            // 
            userSettingLabel.AutoSize = true;
            userSettingLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userSettingLabel.Location = new Point(269, 30);
            userSettingLabel.Name = "userSettingLabel";
            userSettingLabel.Size = new Size(158, 35);
            userSettingLabel.TabIndex = 0;
            userSettingLabel.Text = "User settings";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveCaption;
            tabPage1.Controls.Add(adminLogOutButton);
            tabPage1.Controls.Add(deleteUserButton);
            tabPage1.Controls.Add(listBox2);
            tabPage1.Controls.Add(loadUserButton);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(729, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Users";
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(247, 237);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(94, 29);
            deleteUserButton.TabIndex = 5;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(485, 15);
            listBox2.Margin = new Padding(2, 3, 2, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(186, 204);
            listBox2.TabIndex = 4;
            // 
            // loadUserButton
            // 
            loadUserButton.Location = new Point(43, 105);
            loadUserButton.Margin = new Padding(2, 3, 2, 3);
            loadUserButton.Name = "loadUserButton";
            loadUserButton.Size = new Size(105, 35);
            loadUserButton.TabIndex = 1;
            loadUserButton.Text = "Load";
            loadUserButton.UseVisualStyleBackColor = true;
            loadUserButton.Click += loadUserButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(209, 15);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 204);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(userInfoTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 549);
            tabControl1.TabIndex = 0;
            // 
            // adminLogOutButton
            // 
            adminLogOutButton.Location = new Point(21, 325);
            adminLogOutButton.Name = "adminLogOutButton";
            adminLogOutButton.Size = new Size(94, 29);
            adminLogOutButton.TabIndex = 6;
            adminLogOutButton.Text = "Log out";
            adminLogOutButton.UseVisualStyleBackColor = true;
            adminLogOutButton.Click += adminLogOutButton_Click;
            // 
            // AdminAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 549);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "AdminAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosing += AdminAccountForm_FormClosing;
            userInfoTab.ResumeLayout(false);
            userInfoTab.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage userInfoTab;
        private TabPage tabPage1;
        private ListBox listBox2;
        private Button loadUserButton;
        private ListBox listBox1;
        private TabControl tabControl1;
        private Label updateUserInfoLabel;
        private Label changeUserPasswordLabel;
        private Label label1;
        private Label userSettingLabel;
        private Label usersIdLabel;
        private Label usersEmailLabel;
        private Label usersNameLabel;
        private TextBox currentPasswordTextBox;
        private Label usersPasswordLabel;
        private TextBox usersAddressTextBox;
        private TextBox usersEmailTextBox;
        private TextBox usersNameTextBox;
        private TextBox confirmPasswordTextBox;
        private TextBox newPasswordTextBox;
        private Label usersAdressLabel;
        private Button changeUserPasswordButton;
        private Button updateUsersInfoButton;
        private Button deleteUserButton;
        private Button adminLogOutButton;
    }
}