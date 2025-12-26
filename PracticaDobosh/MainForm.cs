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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem?.ToString() == "Подразделения")
            {
                DepartmentForm departmentForm = new DepartmentForm();
                departmentForm.Show();
            }
            if(listBox1.SelectedItem?.ToString() == "Сотрудники")
            {
                EmplyeeForm emplyeeForm = new EmplyeeForm();
                emplyeeForm.Show();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
