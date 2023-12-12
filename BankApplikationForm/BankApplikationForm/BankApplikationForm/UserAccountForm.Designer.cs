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
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            balanceLabel = new Label();
            accountIdLabel = new Label();
            accountNameLabel = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            withdrawTextbox = new TextBox();
            depositTextBox = new TextBox();
            withdrawButton = new Button();
            depositButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            settingsTab = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            label4 = new Label();
            button6 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            tabPage1 = new TabPage();
            userTabControl.SuspendLayout();
            accountTab.SuspendLayout();
            transactionTab.SuspendLayout();
            settingsTab.SuspendLayout();
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
            userTabControl.Size = new Size(644, 415);
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
            accountTab.Location = new Point(4, 24);
            accountTab.Margin = new Padding(2);
            accountTab.Name = "accountTab";
            accountTab.Padding = new Padding(2);
            accountTab.Size = new Size(636, 387);
            accountTab.TabIndex = 0;
            accountTab.Text = "Account";
            // 
            // renameAccountButton
            // 
            renameAccountButton.Location = new Point(136, 296);
            renameAccountButton.Margin = new Padding(3, 2, 3, 2);
            renameAccountButton.Name = "renameAccountButton";
            renameAccountButton.Size = new Size(108, 22);
            renameAccountButton.TabIndex = 9;
            renameAccountButton.Text = "Rename Account";
            renameAccountButton.UseVisualStyleBackColor = true;
            renameAccountButton.Click += renameAccountButton_Click;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.Location = new Point(254, 296);
            deleteAccountButton.Margin = new Padding(3, 2, 3, 2);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(99, 22);
            deleteAccountButton.TabIndex = 8;
            deleteAccountButton.Text = "Delete Account";
            deleteAccountButton.UseVisualStyleBackColor = true;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // newAccountNameLabel2
            // 
            newAccountNameLabel2.AutoSize = true;
            newAccountNameLabel2.Location = new Point(425, 222);
            newAccountNameLabel2.Name = "newAccountNameLabel2";
            newAccountNameLabel2.Size = new Size(179, 15);
            newAccountNameLabel2.TabIndex = 7;
            newAccountNameLabel2.Text = "Press enter to confirm the name.";
            newAccountNameLabel2.Visible = false;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Location = new Point(448, 90);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(116, 15);
            loggedInAsLabel.TabIndex = 6;
            loggedInAsLabel.Text = "You are logged in as:";
            // 
            // newAccountNameLabel
            // 
            newAccountNameLabel.AutoSize = true;
            newAccountNameLabel.Location = new Point(402, 199);
            newAccountNameLabel.Name = "newAccountNameLabel";
            newAccountNameLabel.Size = new Size(217, 15);
            newAccountNameLabel.TabIndex = 5;
            newAccountNameLabel.Text = "Please enter the name for your account.";
            newAccountNameLabel.Visible = false;
            // 
            // newAccountNameTextBox
            // 
            newAccountNameTextBox.Location = new Point(460, 246);
            newAccountNameTextBox.Margin = new Padding(3, 2, 3, 2);
            newAccountNameTextBox.Name = "newAccountNameTextBox";
            newAccountNameTextBox.Size = new Size(110, 23);
            newAccountNameTextBox.TabIndex = 4;
            newAccountNameTextBox.Visible = false;
            newAccountNameTextBox.KeyPress += accountNameTextBox_KeyPress;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.Location = new Point(448, 271);
            createNewAccountButton.Margin = new Padding(3, 2, 3, 2);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Size = new Size(132, 22);
            createNewAccountButton.TabIndex = 3;
            createNewAccountButton.Text = "Create new account";
            createNewAccountButton.UseVisualStyleBackColor = true;
            createNewAccountButton.Click += createNewAccountButton_Click;
            // 
            // loadAccountButton
            // 
            loadAccountButton.Location = new Point(30, 296);
            loadAccountButton.Margin = new Padding(3, 2, 3, 2);
            loadAccountButton.Name = "loadAccountButton";
            loadAccountButton.Size = new Size(96, 22);
            loadAccountButton.TabIndex = 2;
            loadAccountButton.Text = "Load Account";
            loadAccountButton.UseVisualStyleBackColor = true;
            loadAccountButton.Click += loadAccountButton_Click;
            // 
            // accountsLabel
            // 
            accountsLabel.AutoSize = true;
            accountsLabel.Location = new Point(30, 31);
            accountsLabel.Name = "accountsLabel";
            accountsLabel.Size = new Size(57, 15);
            accountsLabel.TabIndex = 1;
            accountsLabel.Text = "Accounts";
            // 
            // accountsListBox
            // 
            accountsListBox.FormattingEnabled = true;
            accountsListBox.ItemHeight = 15;
            accountsListBox.Location = new Point(30, 63);
            accountsListBox.Margin = new Padding(3, 2, 3, 2);
            accountsListBox.Name = "accountsListBox";
            accountsListBox.Size = new Size(308, 184);
            accountsListBox.TabIndex = 0;
            accountsListBox.SelectedIndexChanged += accountsListBox_SelectedIndexChanged;
            // 
            // transactionTab
            // 
            transactionTab.BackColor = SystemColors.InactiveCaption;
            transactionTab.Controls.Add(listBox2);
            transactionTab.Controls.Add(listBox1);
            transactionTab.Controls.Add(balanceLabel);
            transactionTab.Controls.Add(accountIdLabel);
            transactionTab.Controls.Add(accountNameLabel);
            transactionTab.Controls.Add(button3);
            transactionTab.Controls.Add(textBox3);
            transactionTab.Controls.Add(withdrawTextbox);
            transactionTab.Controls.Add(depositTextBox);
            transactionTab.Controls.Add(withdrawButton);
            transactionTab.Controls.Add(depositButton);
            transactionTab.Controls.Add(label3);
            transactionTab.Controls.Add(label2);
            transactionTab.Controls.Add(label1);
            transactionTab.Location = new Point(4, 24);
            transactionTab.Margin = new Padding(2);
            transactionTab.Name = "transactionTab";
            transactionTab.Padding = new Padding(2);
            transactionTab.Size = new Size(636, 387);
            transactionTab.TabIndex = 1;
            transactionTab.Text = "Transactions";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(442, 322);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 49);
            listBox2.TabIndex = 18;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(442, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 17;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.Location = new Point(259, 51);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(55, 19);
            balanceLabel.TabIndex = 16;
            balanceLabel.Text = "Balance";
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdLabel.Location = new Point(442, 51);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(75, 19);
            accountIdLabel.TabIndex = 15;
            accountIdLabel.Text = "Account Id";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel.Location = new Point(88, 51);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(95, 19);
            accountNameLabel.TabIndex = 14;
            accountNameLabel.Text = "AccountName";
            // 
            // button3
            // 
            button3.Location = new Point(442, 188);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(79, 20);
            button3.TabIndex = 13;
            button3.Text = "Transfer";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(442, 151);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Amount";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 11;
            // 
            // withdrawTextbox
            // 
            withdrawTextbox.Location = new Point(246, 211);
            withdrawTextbox.Margin = new Padding(2);
            withdrawTextbox.Name = "withdrawTextbox";
            withdrawTextbox.PlaceholderText = "Amount";
            withdrawTextbox.Size = new Size(106, 23);
            withdrawTextbox.TabIndex = 9;
            withdrawTextbox.KeyPress += withdrawTextbox_KeyPress;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(75, 211);
            depositTextBox.Margin = new Padding(2);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.PlaceholderText = "Amount";
            depositTextBox.Size = new Size(106, 23);
            depositTextBox.TabIndex = 8;
            depositTextBox.KeyPress += depositTextBox_KeyPress;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(246, 248);
            withdrawButton.Margin = new Padding(2);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(79, 20);
            withdrawButton.TabIndex = 7;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(75, 248);
            depositButton.Margin = new Padding(2);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(79, 20);
            depositButton.TabIndex = 6;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(442, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 3;
            label3.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(246, 178);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 2;
            label2.Text = "Withdraw";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 178);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 1;
            label1.Text = "Deposit";
            // 
            // settingsTab
            // 
            settingsTab.BackColor = SystemColors.InactiveCaption;
            settingsTab.Controls.Add(button1);
            settingsTab.Controls.Add(textBox1);
            settingsTab.Controls.Add(textBox2);
            settingsTab.Controls.Add(textBox7);
            settingsTab.Controls.Add(label4);
            settingsTab.Controls.Add(button6);
            settingsTab.Controls.Add(button4);
            settingsTab.Controls.Add(textBox6);
            settingsTab.Controls.Add(textBox5);
            settingsTab.Controls.Add(textBox4);
            settingsTab.Controls.Add(label5);
            settingsTab.Location = new Point(4, 24);
            settingsTab.Margin = new Padding(2);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(2);
            settingsTab.Size = new Size(636, 387);
            settingsTab.TabIndex = 2;
            settingsTab.Text = "Settings";
            // 
            // button1
            // 
            button1.Location = new Point(417, 241);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 14;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(417, 176);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Address";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(417, 137);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(417, 97);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Name";
            textBox7.Size = new Size(154, 23);
            textBox7.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(417, 53);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 10;
            label4.Text = "Update Information";
            // 
            // button6
            // 
            button6.Location = new Point(511, 335);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(101, 23);
            button6.TabIndex = 9;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(64, 241);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(143, 23);
            button4.TabIndex = 4;
            button4.Text = "Update Password";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(64, 176);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Confirm password";
            textBox6.Size = new Size(154, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(64, 137);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "New password";
            textBox5.Size = new Size(154, 23);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(64, 97);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Current password";
            textBox4.Size = new Size(154, 23);
            textBox4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(64, 53);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 0;
            label5.Text = "Change Password";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveCaption;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(636, 387);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Transaction History";
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 415);
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
        private TextBox textBox3;
        private TextBox withdrawTextbox;
        private TextBox depositTextBox;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label5;
        private Button button6;
        private Label balanceLabel;
        private Label accountIdLabel;
        private Label accountNameLabel;
        private Button renameAccountButton;
        private Button deleteAccountButton;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox7;
        private Label label4;
        private TabPage tabPage1;
    }
}