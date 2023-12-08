namespace BankApplikationForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logInButton = new Button();
            newUserButton = new Button();
            userNameLabel = new Label();
            passwordLabel = new Label();
            userNameTextbox = new TextBox();
            passwordTextBox = new TextBox();
            bankNameLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logInButton
            // 
            logInButton.Location = new Point(509, 459);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(151, 43);
            logInButton.TabIndex = 0;
            logInButton.Text = "Logga in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // newUserButton
            // 
            newUserButton.Location = new Point(47, 459);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(161, 43);
            newUserButton.TabIndex = 1;
            newUserButton.Text = "New User";
            newUserButton.UseVisualStyleBackColor = true;
            newUserButton.Click += newUserButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(509, 57);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(69, 15);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(509, 170);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(59, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // userNameTextbox
            // 
            userNameTextbox.Location = new Point(509, 104);
            userNameTextbox.Name = "userNameTextbox";
            userNameTextbox.Size = new Size(288, 23);
            userNameTextbox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(509, 232);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(288, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // bankNameLabel
            // 
            bankNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bankNameLabel.AutoSize = true;
            bankNameLabel.Font = new Font("Sylfaen", 24F, FontStyle.Bold, GraphicsUnit.Point);
            bankNameLabel.ForeColor = SystemColors.HotTrack;
            bankNameLabel.Location = new Point(12, 261);
            bankNameLabel.Name = "bankNameLabel";
            bankNameLabel.Size = new Size(269, 50);
            bankNameLabel.TabIndex = 8;
            bankNameLabel.Text = "The Popular Bank";
            bankNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            bankNameLabel.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.bankbild;
            pictureBox1.Location = new Point(67, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(880, 537);
            Controls.Add(pictureBox1);
            Controls.Add(bankNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(newUserButton);
            Controls.Add(logInButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInButton;
        private Button newUserButton;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox userNameTextbox;
        private TextBox passwordTextBox;
        private Label bankNameLabel;
        private PictureBox pictureBox1;
    }
}