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
            accountInfoLabel = new Label();
            tabPage3 = new TabPage();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button4 = new Button();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button5 = new Button();
            button6 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 4, 2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 482);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(2, 4, 2, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 4, 2, 4);
            tabPage1.Size = new Size(792, 444);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // accountNameLabel2
            // 
            accountNameLabel2.AutoSize = true;
            accountNameLabel2.Location = new Point(481, 264);
            accountNameLabel2.Margin = new Padding(4, 0, 4, 0);
            accountNameLabel2.Name = "accountNameLabel2";
            accountNameLabel2.Size = new Size(269, 25);
            accountNameLabel2.TabIndex = 7;
            accountNameLabel2.Text = "Press enter to confirm the name.";
            accountNameLabel2.Visible = false;
            // 
            // loggedInAsLabel
            // 
            loggedInAsLabel.AutoSize = true;
            loggedInAsLabel.Location = new Point(515, 44);
            loggedInAsLabel.Margin = new Padding(4, 0, 4, 0);
            loggedInAsLabel.Name = "loggedInAsLabel";
            loggedInAsLabel.Size = new Size(177, 25);
            loggedInAsLabel.TabIndex = 6;
            loggedInAsLabel.Text = "You are logged in as:";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new Point(449, 225);
            accountNameLabel.Margin = new Padding(4, 0, 4, 0);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(325, 25);
            accountNameLabel.TabIndex = 5;
            accountNameLabel.Text = "Please enter the name for your account.";
            accountNameLabel.Visible = false;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Location = new Point(531, 304);
            accountNameTextBox.Margin = new Padding(4);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(155, 31);
            accountNameTextBox.TabIndex = 4;
            accountNameTextBox.Visible = false;
            accountNameTextBox.KeyPress += accountNameTextBox_KeyPress;
            // 
            // createNewAccountButton
            // 
            createNewAccountButton.Location = new Point(515, 345);
            createNewAccountButton.Margin = new Padding(4);
            createNewAccountButton.Name = "createNewAccountButton";
            createNewAccountButton.Size = new Size(189, 36);
            createNewAccountButton.TabIndex = 3;
            createNewAccountButton.Text = "Create new account";
            createNewAccountButton.UseVisualStyleBackColor = true;
            createNewAccountButton.Click += createNewAccountButton_Click;
            // 
            // loadAccountButton
            // 
            loadAccountButton.Location = new Point(64, 345);
            loadAccountButton.Margin = new Padding(4);
            loadAccountButton.Name = "loadAccountButton";
            loadAccountButton.Size = new Size(144, 36);
            loadAccountButton.TabIndex = 2;
            loadAccountButton.Text = "Load Account";
            loadAccountButton.UseVisualStyleBackColor = true;
            // 
            // accountsLabel
            // 
            accountsLabel.AutoSize = true;
            accountsLabel.Location = new Point(84, 4);
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
            accountsListBox.Location = new Point(6, 32);
            accountsListBox.Margin = new Padding(4);
            accountsListBox.Name = "accountsListBox";
            accountsListBox.Size = new Size(439, 304);
            accountsListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(accountInfoLabel);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 444);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Transactions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(559, 313);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Transfer";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 248);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 12;
            label4.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(559, 169);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Amount";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(630, 246);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(79, 31);
            numericUpDown1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 169);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Amount";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 169);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Amount";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(306, 246);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(53, 246);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(559, 113);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 3;
            label3.Text = "Transfer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(306, 113);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 2;
            label2.Text = "Withdraw";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 113);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 1;
            label1.Text = "Deposit";
            // 
            // accountInfoLabel
            // 
            accountInfoLabel.AutoSize = true;
            accountInfoLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            accountInfoLabel.Location = new Point(306, 24);
            accountInfoLabel.Name = "accountInfoLabel";
            accountInfoLabel.Size = new Size(174, 38);
            accountInfoLabel.TabIndex = 0;
            accountInfoLabel.Text = "Account Info";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 444);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 44);
            label5.Name = "label5";
            label5.Size = new Size(183, 30);
            label5.TabIndex = 0;
            label5.Text = "Change Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(34, 118);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Current password";
            textBox4.Size = new Size(219, 31);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(34, 183);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "New password";
            textBox5.Size = new Size(219, 31);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(34, 249);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Confirm password";
            textBox6.Size = new Size(219, 31);
            textBox6.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(34, 356);
            button4.Name = "button4";
            button4.Size = new Size(204, 39);
            button4.TabIndex = 4;
            button4.Text = "Update Password";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(471, 44);
            label6.Name = "label6";
            label6.Size = new Size(160, 30);
            label6.TabIndex = 5;
            label6.Text = "Delete Account";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(471, 171);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(183, 31);
            textBox7.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(394, 118);
            label7.Name = "label7";
            label7.Size = new Size(350, 25);
            label7.TabIndex = 7;
            label7.Text = "Enter your password to delete this account";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(471, 237);
            button5.Name = "button5";
            button5.Size = new Size(183, 39);
            button5.TabIndex = 8;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Location = new Point(600, 356);
            button6.Name = "button6";
            button6.Size = new Size(144, 39);
            button6.TabIndex = 9;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 4, 2, 4);
            Name = "UserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            FormClosing += UserAccountForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button loadAccountButton;
        private Label accountsLabel;
        private ListBox accountsListBox;
        private Button createNewAccountButton;
        private Label accountNameLabel;
        private TextBox accountNameTextBox;
        private Label loggedInAsLabel;
        private Label accountNameLabel2;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label accountInfoLabel;
        private TabPage tabPage3;
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
    }
}