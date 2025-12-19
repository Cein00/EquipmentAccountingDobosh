using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PracticaDobosh
{
    public partial class DepartmentEditForm : Form
    {
        public DepartmentEditForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Поле ID является обязательным!");
                return;
            }
            bool isDepNameFilled = !string.IsNullOrWhiteSpace(textBoxDepName.Text);
            bool isHeadNameFilled = !string.IsNullOrWhiteSpace(textBoxHeadName.Text);

            if (!isDepNameFilled && !isHeadNameFilled)
            {
                MessageBox.Show("Заполните хотя бы одно поле: 'Название' или 'Глава отдела'");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
