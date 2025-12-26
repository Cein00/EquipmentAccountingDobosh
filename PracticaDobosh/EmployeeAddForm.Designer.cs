namespace PracticaDobosh
{
    partial class EmployeeAddForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3313322F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0019989F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3313322F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0019989F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3313322F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0019989F));
            tableLayoutPanel1.Size = new Size(466, 199);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Позиция";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 135);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 2;
            label3.Text = "Номер Отдела";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(329, 29);
            button1.Name = "button1";
            tableLayoutPanel1.SetRowSpan(button1, 2);
            button1.Size = new Size(134, 59);
            button1.TabIndex = 3;
            button1.Text = "Нанять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(329, 94);
            button2.Name = "button2";
            tableLayoutPanel1.SetRowSpan(button2, 2);
            button2.Size = new Size(134, 59);
            button2.TabIndex = 4;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(3, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(3, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 29);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Top;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(3, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 29);
            textBox3.TabIndex = 7;
            // 
            // EmployeeAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 199);
            Controls.Add(tableLayoutPanel1);
            Name = "EmployeeAddForm";
            Text = "EmployeeAddForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
    }
}