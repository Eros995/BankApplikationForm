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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            accountNameLabel2 = new Label();
            loggedInAsLabel = new Label();
            accountNameLabel = new Label();
            accountNameTextBox = new TextBox();
            createNewAccountButton = new Button();
            loadAccountButton = new Button();
            accountsLabel = new Label();
            accountsListBox = new ListBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 360);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(accountNameLabel2);
            tabPage1.Controls.Add(loggedInAsLabel);
            tabPage1.Controls.Add(accountNameLabel);
            tabPage1.Controls.Add(accountNameTextBox);
            tabPage1.Controls.Add(createNewAccountButton);
            tabPage1.Controls.Add(loadAccountButton);
            tabPage1.Controls.Add(accountsLabel);
            tabPage1.Controls.Add(accountsListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(632, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // accountNameLabel2
            // 
            accountNameLabel2.AutoSize = true;
            accountNameLabel2.Location = new Point(385, 211);
            accountNameLabel2.Name = "accountNameLabel2";
            accountNameLabel2.Size = new Size(222, 20);
            accountNameLabel2.TabIndex = 7;
            accountNameLabel2.Text = "Press enter to confirm the name.";
            accountNameLabel2.Visible = false;
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
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new Point(359, 180);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(270, 20);
            accountNameLabel.TabIndex = 5;
            accountNameLabel.Text = "Please enter the name for your account.";
            accountNameLabel.Visible = false;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Location = new Point(425, 243);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(125, 27);
            accountNameTextBox.TabIndex = 4;
            accountNameTextBox.Visible = false;
            accountNameTextBox.KeyPress += accountNameTextBox_KeyPress;
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
            loadAccountButton.Location = new Point(51, 276);
            loadAccountButton.Name = "loadAccountButton";
            loadAccountButton.Size = new Size(115, 29);
            loadAccountButton.TabIndex = 2;
            loadAccountButton.Text = "Load Account";
            loadAccountButton.UseVisualStyleBackColor = true;
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
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(632, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Deposit";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 3, 2, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 3, 2, 3);
            tabPage3.Size = new Size(632, 327);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Transaction";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2, 3, 2, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2, 3, 2, 3);
            tabPage4.Size = new Size(632, 327);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete Account";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(2, 3, 2, 3);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(2, 3, 2, 3);
            tabPage5.Size = new Size(632, 327);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Withdraw";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            FormClosing += UserAccountForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button loadAccountButton;
        private Label accountsLabel;
        private ListBox accountsListBox;
        private Button createNewAccountButton;
        private Label accountNameLabel;
        private TextBox accountNameTextBox;
        private Label loggedInAsLabel;
        private Label accountNameLabel2;
    }
}