namespace PracticaDobosh
{
    partial class DepartmentForm
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
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonChanged = new Button();
            buttonDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonChanged, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonDelete, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.MenuBar;
            dataGridView1.ColumnHeadersHeight = 50;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 4);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 394);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(3, 403);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(194, 44);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonChanged
            // 
            buttonChanged.Dock = DockStyle.Fill;
            buttonChanged.Location = new Point(203, 403);
            buttonChanged.Name = "buttonChanged";
            buttonChanged.Size = new Size(194, 44);
            buttonChanged.TabIndex = 2;
            buttonChanged.Text = "Изменить";
            buttonChanged.UseVisualStyleBackColor = true;
            buttonChanged.Click += buttonChanged_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(403, 403);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(194, 44);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonChanged;
        private Button buttonDelete;
    }
}