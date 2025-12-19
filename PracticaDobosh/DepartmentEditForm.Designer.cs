namespace PracticaDobosh
{
    partial class DepartmentEditForm
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
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxId = new TextBox();
            textBoxDepName = new TextBox();
            textBoxHeadName = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxId, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxDepName, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxHeadName, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.Size = new Size(443, 169);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSave.Location = new Point(313, 30);
            buttonSave.Name = "buttonSave";
            tableLayoutPanel1.SetRowSpan(buttonSave, 2);
            buttonSave.Size = new Size(127, 48);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancel.Location = new Point(313, 84);
            buttonCancel.Name = "buttonCancel";
            tableLayoutPanel1.SetRowSpan(buttonCancel, 2);
            buttonCancel.Size = new Size(127, 48);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(304, 21);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(304, 21);
            label2.TabIndex = 3;
            label2.Text = "Название отдела";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 114);
            label3.Name = "label3";
            label3.Size = new Size(304, 21);
            label3.TabIndex = 4;
            label3.Text = "Глава Отдела";
            // 
            // textBoxId
            // 
            textBoxId.Dock = DockStyle.Top;
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxId.Location = new Point(3, 30);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(304, 29);
            textBoxId.TabIndex = 5;
            // 
            // textBoxDepName
            // 
            textBoxDepName.Dock = DockStyle.Top;
            textBoxDepName.Font = new Font("Segoe UI", 12F);
            textBoxDepName.Location = new Point(3, 84);
            textBoxDepName.Name = "textBoxDepName";
            textBoxDepName.Size = new Size(304, 29);
            textBoxDepName.TabIndex = 6;
            // 
            // textBoxHeadName
            // 
            textBoxHeadName.Dock = DockStyle.Top;
            textBoxHeadName.Font = new Font("Segoe UI", 12F);
            textBoxHeadName.Location = new Point(3, 138);
            textBoxHeadName.Name = "textBoxHeadName";
            textBoxHeadName.Size = new Size(304, 29);
            textBoxHeadName.TabIndex = 7;
            // 
            // DepartmentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 169);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartmentEditForm";
            Text = "DepartmentEditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBoxId;
        public TextBox textBoxDepName;
        public TextBox textBoxHeadName;
    }
}