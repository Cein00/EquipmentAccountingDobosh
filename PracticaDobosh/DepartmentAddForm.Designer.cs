namespace PracticaDobosh
{
    partial class DepartmentAddForm
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
            labelHeadNameAdd = new Label();
            buttonAdd = new Button();
            buttonCancelAdd = new Button();
            textBoxDepNameAdd = new TextBox();
            textBoxHeadNameAdd = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(labelHeadNameAdd, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonAdd, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonCancelAdd, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxDepNameAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxHeadNameAdd, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(443, 169);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(304, 21);
            label1.TabIndex = 0;
            label1.Text = "Название отдела";
            // 
            // labelHeadNameAdd
            // 
            labelHeadNameAdd.AutoSize = true;
            labelHeadNameAdd.Dock = DockStyle.Bottom;
            labelHeadNameAdd.Font = new Font("Segoe UI", 12F);
            labelHeadNameAdd.Location = new Point(3, 88);
            labelHeadNameAdd.Name = "labelHeadNameAdd";
            labelHeadNameAdd.Size = new Size(304, 21);
            labelHeadNameAdd.TabIndex = 1;
            labelHeadNameAdd.Text = "Глава отдела";
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(313, 28);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(127, 53);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancelAdd
            // 
            buttonCancelAdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelAdd.Location = new Point(313, 103);
            buttonCancelAdd.Name = "buttonCancelAdd";
            tableLayoutPanel1.SetRowSpan(buttonCancelAdd, 2);
            buttonCancelAdd.Size = new Size(127, 47);
            buttonCancelAdd.TabIndex = 3;
            buttonCancelAdd.Text = "Отменить";
            buttonCancelAdd.UseVisualStyleBackColor = true;
            buttonCancelAdd.Click += buttonCancelAdd_Click;
            // 
            // textBoxDepNameAdd
            // 
            textBoxDepNameAdd.Dock = DockStyle.Fill;
            textBoxDepNameAdd.Font = new Font("Segoe UI", 12F);
            textBoxDepNameAdd.Location = new Point(3, 28);
            textBoxDepNameAdd.Name = "textBoxDepNameAdd";
            textBoxDepNameAdd.Size = new Size(304, 29);
            textBoxDepNameAdd.TabIndex = 4;
            // 
            // textBoxHeadNameAdd
            // 
            textBoxHeadNameAdd.Dock = DockStyle.Fill;
            textBoxHeadNameAdd.Font = new Font("Segoe UI", 12F);
            textBoxHeadNameAdd.Location = new Point(3, 112);
            textBoxHeadNameAdd.Name = "textBoxHeadNameAdd";
            textBoxHeadNameAdd.Size = new Size(304, 29);
            textBoxHeadNameAdd.TabIndex = 5;
            // 
            // DepartmentAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 169);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartmentAddForm";
            Text = "DepartmentAddForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label labelHeadNameAdd;
        private Button buttonAdd;
        private Button buttonCancelAdd;
        public TextBox textBoxDepNameAdd;
        public TextBox textBoxHeadNameAdd;
    }
}