using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNauka
{
    public partial class FormTimekeeper : Form
    {
        public FormTimekeeper(FormLogin ParrentForm)
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private void production_calendarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.production_calendarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testNaukaBaseDataSet);

        }

        private void FormTimekeeper_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testNaukaBaseDataSet.Production_calendar". При необходимости она может быть перемещена или удалена.
            this.production_calendarTableAdapter.Fill(this.testNaukaBaseDataSet.Production_calendar);

        }
    }
}
