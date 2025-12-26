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
    public partial class EmplyeeForm : Form
    {
        private static readonly EquipmentDbContext _db = new EquipmentDbContext();
        private readonly EmployeeService _service = new EmployeeService(_db);

        public EmplyeeForm()
        {
            InitializeComponent();
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
            
        }

        public async Task RefreshData()
        {
            var data = await _service.GetAllAsync();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            string[] columnsToHide = { "Department", "ResponsibleEquipment", "OldMovements", "NewMovements" };
            foreach (var col in columnsToHide)
            {
                if (dataGridView1.Columns[col] != null)
                    dataGridView1.Columns[col].Visible = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            EmployeeAddForm addForm = new EmployeeAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string fio = addForm.textBox1.Text;
                string pos = addForm.textBox2.Text;
                int depId = int.Parse(addForm.textBox3.Text);

                await _service.AddAsync(fio, pos, depId);
                await RefreshData();
            }
        }
    }
}
