namespace BankApplikationForm
{
    partial class AdminAccount
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
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            listBox2 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 412);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Change User info";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Transaction";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "List Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(538, 18);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(231, 254);
            listBox2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(52, 111);
            button3.Name = "button3";
            button3.Size = new Size(131, 41);
            button3.TabIndex = 3;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(52, 175);
            button2.Name = "button2";
            button2.Size = new Size(131, 44);
            button2.TabIndex = 2;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(42, 18);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(261, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(232, 254);
            listBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 412);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Create Account";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(275, 234);
            button4.Name = "button4";
            button4.Size = new Size(160, 44);
            button4.TabIndex = 0;
            button4.Text = "Create Account";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 49);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 1;
            label1.Text = "Select User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 105);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 2;
            label2.Text = "Opening Ammount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(396, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(396, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 31);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 167);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 7;
            label3.Text = "Occupation";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Admin";
            Text = "Admin";
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private Button button1;
        private ListBox listBox1;
        private TabControl tabControl1;
        private Button button2;
        private Button button3;
        private TabPage tabPage2;
        private ListBox listBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Label label3;
        private TextBox textBox3;
    }
}