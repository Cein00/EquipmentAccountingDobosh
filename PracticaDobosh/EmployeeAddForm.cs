using PracticaDobosh.BLL;
using PracticaDobosh.DAL.Context;
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
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            bool isFIOFilled = !string.IsNullOrWhiteSpace(textBox1.Text);
            bool isPositinFilled = !string.IsNullOrWhiteSpace(textBox2.Text);
            bool isDepFill = !string.IsNullOrWhiteSpace(textBox3.Text);

            if (!isFIOFilled || !isPositinFilled || !isDepFill)
            {
                MessageBox.Show("Заполните все поля: ФИО, Позицию, номер Отдела");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
