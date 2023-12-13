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
            AdminFormListBoxUsers = new ListBox();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.InactiveCaption;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(637, 384);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Change User info";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveCaption;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(listBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(AdminFormListBoxUsers);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(637, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Users";
            // 
            // button2
            // 
            button2.Location = new Point(183, 184);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(164, 26);
            button2.TabIndex = 5;
            button2.Text = "Delete User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(424, 11);
            listBox2.Margin = new Padding(2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(163, 154);
            listBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(38, 79);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(92, 26);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminFormListBoxUsers
            // 
            AdminFormListBoxUsers.FormattingEnabled = true;
            AdminFormListBoxUsers.ItemHeight = 15;
            AdminFormListBoxUsers.Location = new Point(183, 11);
            AdminFormListBoxUsers.Margin = new Padding(2);
            AdminFormListBoxUsers.Name = "AdminFormListBoxUsers";
            AdminFormListBoxUsers.Size = new Size(164, 154);
            AdminFormListBoxUsers.TabIndex = 0;
            AdminFormListBoxUsers.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(645, 412);
            tabControl1.TabIndex = 0;
            // 
            // AdminAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 412);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
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
        private ListBox AdminFormListBoxUsers;
        private TabControl tabControl1;
        private Button button2;
    }
}