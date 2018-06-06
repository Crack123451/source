using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNauka
{
    public partial class FormAdminDepartment : Form
    {
        public FormAdminDepartment(FormLogin ParrentForm)
        {
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testNaukaBaseDataSet);

        }

        private void FormAdminDepartment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testNaukaBaseDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.testNaukaBaseDataSet.Department);

        }
    }
}
