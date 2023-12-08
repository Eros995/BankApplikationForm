namespace BankApplikationForm
{
    partial class NewUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameTextbox = new TextBox();
            passwordTexbox = new TextBox();
            addressTextbox = new TextBox();
            emailTextbox = new TextBox();
            createUserButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 88);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 143);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 253);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 199);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(271, 88);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(250, 31);
            nameTextbox.TabIndex = 7;
            // 
            // passwordTexbox
            // 
            passwordTexbox.Location = new Point(271, 140);
            passwordTexbox.Name = "passwordTexbox";
            passwordTexbox.Size = new Size(250, 31);
            passwordTexbox.TabIndex = 8;
            // 
            // addressTextbox
            // 
            addressTextbox.Location = new Point(271, 247);
            addressTextbox.Name = "addressTextbox";
            addressTextbox.Size = new Size(250, 31);
            addressTextbox.TabIndex = 9;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(271, 193);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(250, 31);
            emailTextbox.TabIndex = 10;
            // 
            // createUserButton
            // 
            createUserButton.Location = new Point(271, 352);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(141, 44);
            createUserButton.TabIndex = 14;
            createUserButton.Text = "Create";
            createUserButton.UseVisualStyleBackColor = true;
            createUserButton.Click += createUserButton_Click;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 529);
            Controls.Add(createUserButton);
            Controls.Add(emailTextbox);
            Controls.Add(addressTextbox);
            Controls.Add(passwordTexbox);
            Controls.Add(nameTextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "NewUserForm";
            Text = "NewUser";
            BackgroundImageLayoutChanged += NewAccount_BackgroundImageLayoutChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextbox;
        private TextBox passwordTexbox;
        private TextBox addressTextbox;
        private TextBox emailTextbox;
        private Button createUserButton;
    }
}