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
            balanceLabel = new Label();
            accountIdLabel = new Label();
            accountNameLabel = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            settingsTab = new TabPage();
            button6 = new Button();
            button5 = new Button();
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            userTabControl.SuspendLayout();
            accountTab.SuspendLayout();
            transactionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            settingsTab.SuspendLayout();
            SuspendLayout();
            // 
            // userTabControl
            // 
            userTabControl.Controls.Add(accountTab);
            userTabControl.Controls.Add(transactionTab);
            userTabControl.Controls.Add(settingsTab);
            userTabControl.Dock = DockStyle.Fill;
            userTabControl.Location = new Point(0, 0);
            userTabControl.Margin = new Padding(2, 3, 2, 3);
            userTabControl.Name = "userTabControl";
            userTabControl.SelectedIndex = 0;
            userTabControl.Size = new Size(640, 386);
            userTabControl.TabIndex = 0;
            // 
            // accountTab
            // 
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
            accountTab.Margin = new Padding(2, 3, 2, 3);
            accountTab.Name = "accountTab";
            accountTab.Padding = new Padding(2, 3, 2, 3);
            accountTab.Size = new Size(632, 353);
            accountTab.TabIndex = 0;
            accountTab.Text = "Account";
            accountTab.UseVisualStyleBackColor = true;
            // 
            // renameAccountButton
            // 
            renameAccountButton.Location = new Point(129, 276);
            renameAccountButton.Name = "renameAccountButton";
            renameAccountButton.Size = new Size(129, 29);
            renameAccountButton.TabIndex = 9;
            renameAccountButton.Text = "Rename Account";
            renameAccountButton.UseVisualStyleBackColor = true;
            renameAccountButton.Click += renameAccountButton_Click;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.Location = new Point(264, 276);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(119, 29);
            deleteAccountButton.TabIndex = 8;
            deleteAccountButton.Text = "Delete Account";
            deleteAccountButton.UseVisualStyleBackColor = true;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // newAccountNameLabel2
            // 
            newAccountNameLabel2.AutoSize = true;
            newAccountNameLabel2.Location = new Point(385, 211);
            newAccountNameLabel2.Name = "newAccountNameLabel2";
            newAccountNameLabel2.Size = new Size(222, 20);
            newAccountNameLabel2.TabIndex = 7;
            newAccountNameLabel2.Text = "Press enter to confirm the name.";
            newAccountNameLabel2.Visible = false;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Location = new Point(412, 35);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(147, 20);
            loggedInAsLabel.TabIndex = 6;
            loggedInAsLabel.Text = "You are logged in as:";
            // 
            // newAccountNameLabel
            // 
            newAccountNameLabel.AutoSize = true;
            newAccountNameLabel.Location = new Point(359, 180);
            newAccountNameLabel.Name = "newAccountNameLabel";
            newAccountNameLabel.Size = new Size(270, 20);
            newAccountNameLabel.TabIndex = 5;
            newAccountNameLabel.Text = "Please enter the name for your account.";
            newAccountNameLabel.Visible = false;
            // 
            // newAccountNameTextBox
            // 
            newAccountNameTextBox.Location = new Point(425, 243);
            newAccountNameTextBox.Name = "newAccountNameTextBox";
            newAccountNameTextBox.Size = new Size(125, 27);
            newAccountNameTextBox.TabIndex = 4;
            newAccountNameTextBox.Visible = false;
            newAccountNameTextBox.KeyPress += accountNameTextBox_KeyPress;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.Location = new Point(412, 276);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Size = new Size(151, 29);
            createNewAccountButton.TabIndex = 3;
            createNewAccountButton.Text = "Create new account";
            createNewAccountButton.UseVisualStyleBackColor = true;
            createNewAccountButton.Click += createNewAccountButton_Click;
            // 
            // loadAccountButton
            // 
            loadAccountButton.Location = new Point(8, 276);
            loadAccountButton.Name = "loadAccountButton";
            loadAccountButton.Size = new Size(115, 29);
            loadAccountButton.TabIndex = 2;
            loadAccountButton.Text = "Load Account";
            loadAccountButton.UseVisualStyleBackColor = true;
            loadAccountButton.Click += loadAccountButton_Click;
            // 
            // accountsLabel
            // 
            accountsLabel.AutoSize = true;
            accountsLabel.Location = new Point(67, 3);
            accountsLabel.Name = "accountsLabel";
            accountsLabel.Size = new Size(69, 20);
            accountsLabel.TabIndex = 1;
            accountsLabel.Text = "Accounts";
            // 
            // accountsListBox
            // 
            accountsListBox.FormattingEnabled = true;
            accountsListBox.ItemHeight = 20;
            accountsListBox.Location = new Point(5, 26);
            accountsListBox.Name = "accountsListBox";
            accountsListBox.Size = new Size(352, 244);
            accountsListBox.TabIndex = 0;
            accountsListBox.SelectedIndexChanged += accountsListBox_SelectedIndexChanged;
            // 
            // transactionTab
            // 
            transactionTab.Controls.Add(balanceLabel);
            transactionTab.Controls.Add(accountIdLabel);
            transactionTab.Controls.Add(accountNameLabel);
            transactionTab.Controls.Add(button3);
            transactionTab.Controls.Add(label4);
            transactionTab.Controls.Add(textBox3);
            transactionTab.Controls.Add(numericUpDown1);
            transactionTab.Controls.Add(textBox2);
            transactionTab.Controls.Add(textBox1);
            transactionTab.Controls.Add(button2);
            transactionTab.Controls.Add(button1);
            transactionTab.Controls.Add(label3);
            transactionTab.Controls.Add(label2);
            transactionTab.Controls.Add(label1);
            transactionTab.Location = new Point(4, 29);
            transactionTab.Margin = new Padding(2);
            transactionTab.Name = "transactionTab";
            transactionTab.Padding = new Padding(2);
            transactionTab.Size = new Size(632, 353);
            transactionTab.TabIndex = 1;
            transactionTab.Text = "Transactions";
            transactionTab.UseVisualStyleBackColor = true;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.Location = new Point(238, 49);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(69, 23);
            balanceLabel.TabIndex = 16;
            balanceLabel.Text = "Balance";
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountIdLabel.Location = new Point(447, 49);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(93, 23);
            accountIdLabel.TabIndex = 15;
            accountIdLabel.Text = "Account Id";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameLabel.Location = new Point(42, 49);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(119, 23);
            accountNameLabel.TabIndex = 14;
            accountNameLabel.Text = "AccountName";
            // 
            // button3
            // 
            button3.Location = new Point(447, 283);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 13;
            button3.Text = "Transfer";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 240);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 12;
            label4.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(447, 192);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Amount";
            textBox3.Size = new Size(121, 27);
            textBox3.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(486, 234);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 233);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Amount";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 233);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Amount";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(238, 283);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 7;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(42, 283);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 6;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(447, 147);
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
            label2.Location = new Point(238, 147);
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
            label1.Location = new Point(42, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 1;
            label1.Text = "Deposit";
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(button6);
            settingsTab.Controls.Add(button5);
            settingsTab.Controls.Add(label7);
            settingsTab.Controls.Add(textBox7);
            settingsTab.Controls.Add(label6);
            settingsTab.Controls.Add(button4);
            settingsTab.Controls.Add(textBox6);
            settingsTab.Controls.Add(textBox5);
            settingsTab.Controls.Add(textBox4);
            settingsTab.Controls.Add(label5);
            settingsTab.Location = new Point(4, 29);
            settingsTab.Margin = new Padding(2);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(2);
            settingsTab.Size = new Size(632, 353);
            settingsTab.TabIndex = 2;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(480, 285);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(115, 31);
            button6.TabIndex = 9;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(377, 190);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(146, 31);
            button5.TabIndex = 8;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(315, 94);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(290, 20);
            label7.TabIndex = 7;
            label7.Text = "Enter your password to delete this account";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(377, 137);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(147, 27);
            textBox7.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(377, 35);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 5;
            label6.Text = "Delete Account";
            // 
            // button4
            // 
            button4.Location = new Point(27, 285);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(163, 31);
            button4.TabIndex = 4;
            button4.Text = "Update Password";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(27, 199);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Confirm password";
            textBox6.Size = new Size(176, 27);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 146);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "New password";
            textBox5.Size = new Size(176, 27);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 94);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Current password";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 0;
            label5.Text = "Change Password";
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 386);
            Controls.Add(userTabControl);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            FormClosing += UserAccountForm_FormClosing;
            userTabControl.ResumeLayout(false);
            accountTab.ResumeLayout(false);
            accountTab.PerformLayout();
            transactionTab.ResumeLayout(false);
            transactionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button button2;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label5;
        private Button button6;
        private Button button5;
        private Label balanceLabel;
        private Label accountIdLabel;
        private Label accountNameLabel;
        private Button renameAccountButton;
        private Button deleteAccountButton;
    }
}