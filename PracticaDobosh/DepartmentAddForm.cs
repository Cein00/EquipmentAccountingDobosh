using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDobosh
{
    public partial class DepartmentAddForm : Form
    {
        public DepartmentAddForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isDepNameFilled = !string.IsNullOrWhiteSpace(textBoxDepNameAdd.Text);
            bool isHeadNameFilled = !string.IsNullOrWhiteSpace(textBoxHeadNameAdd.Text);

            if (!isDepNameFilled || !isHeadNameFilled)
            {
                MessageBox.Show("Заполните оба поля: 'Название' и 'Глава отдела'");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
