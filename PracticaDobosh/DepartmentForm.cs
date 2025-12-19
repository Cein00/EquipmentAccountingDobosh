using PracticaDobosh.BLL;
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
    public partial class DepartmentForm : Form
    {
        private readonly DepartmentService _service = new DepartmentService();
        public DepartmentForm()
        {
            InitializeComponent();
        }
        private async void DepartmentForm_Load(object sender, EventArgs e)
        {
            await RefreshData();
        }
        public async Task RefreshData()
        {
            var data = await _service.GetAllAsync();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;

            if (dataGridView1.Columns["Employees"] != null)
            {
                dataGridView1.Columns["Employees"].Visible = false;
            }
        }

        private async void buttonChanged_Click(object sender, EventArgs e)
        {

            DepartmentEditForm editform = new DepartmentEditForm();
            if (editform.ShowDialog() == DialogResult.OK)
            {

                int id = int.Parse(editform.textBoxId.Text);
                string depName = editform.textBoxDepName.Text;
                string headName = editform.textBoxHeadName.Text;

                await _service.UpdateAsync(id, depName, headName);

                await RefreshData();
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            DepartmentAddForm addform = new DepartmentAddForm();
            if (addform.ShowDialog() == DialogResult.OK)
            {


                string depName = addform.textBoxDepNameAdd.Text;
                string headName = addform.textBoxHeadNameAdd.Text;

                await _service.AddAsync(depName, headName);

                await RefreshData();
            }

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DepartmentDeleteForm deleteform = new DepartmentDeleteForm();
            if (deleteform.ShowDialog() == DialogResult.OK)
            {


                int id = int.Parse(deleteform.textBoxIdDelete.Text);

                await _service.DeleteAsync(id);

                await RefreshData();
            }
        }
    }
}
