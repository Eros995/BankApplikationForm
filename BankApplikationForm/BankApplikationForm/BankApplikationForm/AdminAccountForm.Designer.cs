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
            tabPage4 = new TabPage();
            tabPage1 = new TabPage();
            button2 = new Button();
            listBox2 = new ListBox();
            button1 = new Button();
            adminFormListBoxUsers = new ListBox();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.InactiveCaption;
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2, 3, 2, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2, 3, 2, 3);
            tabPage4.Size = new Size(729, 516);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Change User info";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveCaption;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(listBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(adminFormListBoxUsers);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(729, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Users";
            // 
            // button2
            // 
            button2.Location = new Point(209, 245);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(187, 35);
            button2.TabIndex = 5;
            button2.Text = "Delete User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // button1
            // 
            button1.Location = new Point(43, 105);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(105, 35);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adminFormListBoxUsers
            // 
            adminFormListBoxUsers.FormattingEnabled = true;
            adminFormListBoxUsers.ItemHeight = 20;
            adminFormListBoxUsers.Location = new Point(209, 15);
            adminFormListBoxUsers.Margin = new Padding(2, 3, 2, 3);
            adminFormListBoxUsers.Name = "adminFormListBoxUsers";
            adminFormListBoxUsers.Size = new Size(187, 204);
            adminFormListBoxUsers.TabIndex = 0;
            adminFormListBoxUsers.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 549);
            tabControl1.TabIndex = 0;
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
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage1;
        private ListBox listBox2;
        private Button button1;
        private ListBox adminFormListBoxUsers;
        private TabControl tabControl1;
        private Button button2;
    }
}