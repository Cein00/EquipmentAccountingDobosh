namespace PracticaDobosh
{
    partial class DepartmentDeleteForm
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
            buttonDelete = new Button();
            buttonCancelDelete = new Button();
            label1 = new Label();
            textBoxIdDelete = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonDelete, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonCancelDelete, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxIdDelete, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.4437866F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.7869835F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(331, 169);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(3, 120);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(159, 46);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancelDelete
            // 
            buttonCancelDelete.Dock = DockStyle.Fill;
            buttonCancelDelete.Location = new Point(168, 120);
            buttonCancelDelete.Name = "buttonCancelDelete";
            buttonCancelDelete.Size = new Size(160, 46);
            buttonCancelDelete.TabIndex = 1;
            buttonCancelDelete.Text = "Отменить";
            buttonCancelDelete.UseVisualStyleBackColor = true;
            buttonCancelDelete.Click += buttonCancelDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(325, 21);
            label1.TabIndex = 2;
            label1.Text = "Введите ID";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBoxIdDelete
            // 
            tableLayoutPanel1.SetColumnSpan(textBoxIdDelete, 2);
            textBoxIdDelete.Dock = DockStyle.Fill;
            textBoxIdDelete.Font = new Font("Segoe UI", 12F);
            textBoxIdDelete.Location = new Point(3, 46);
            textBoxIdDelete.Name = "textBoxIdDelete";
            textBoxIdDelete.Size = new Size(325, 29);
            textBoxIdDelete.TabIndex = 3;
            // 
            // DepartmentDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 169);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartmentDeleteForm";
            Text = "DepartmentDeleteForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonDelete;
        private Button buttonCancelDelete;
        private Label label1;
        public TextBox textBoxIdDelete;
    }
}