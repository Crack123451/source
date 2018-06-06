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
    public partial class FormLogin : Form
    {
        public FormLogin(Form1 ParrentForm)
        {
            InitializeComponent();
            buttonEnter.Enabled = false;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string role = comboBoxRoles.SelectedItem.ToString();
            string password = textBoxPassword.Text.ToString();
            if ( role == "Табельщик" && password == "1111")
            {
                FormTimekeeper newForm = new FormTimekeeper(this);
                newForm.ShowDialog();
            }
            else if (role == "Админ. справ. департамент." && password == "2222")
            {
                FormAdminDepartment newForm = new FormAdminDepartment(this);
                newForm.ShowDialog();
            }
            else if (role == "Админ. справ. сотрудников" && password == "3333")
            {
                FormAdminEmployees newForm = new FormAdminEmployees(this);
                newForm.ShowDialog();
            }
            else
                MessageBox.Show("Пароль введен неверно!", "В доступе отказано");
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnter.Enabled = true;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
