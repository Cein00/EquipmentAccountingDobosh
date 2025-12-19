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
    public partial class DepartmentDeleteForm : Form
    {
        public DepartmentDeleteForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIdDelete.Text))
            {
                MessageBox.Show("Поле ID является обязательным!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonCancelDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    
    }
}
