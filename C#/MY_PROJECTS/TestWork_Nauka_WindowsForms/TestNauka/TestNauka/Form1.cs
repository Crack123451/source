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
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        SqlDataReader sqlReader;
        List<string> listKodeDepartment = new List<string>();

        public Form1()
        {
            InitializeComponent();           
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestNaukaBase.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(stringConnection);

            await sqlConnection.OpenAsync();
            sqlReader = null;
            SqlCommand commandListBox = new SqlCommand("SELECT [Код департамента],[Название департамента] FROM [Department]", sqlConnection);
            SqlCommand commandTimetablesYears = new SqlCommand("SELECT [Дата] FROM [Production_calendar]", sqlConnection);
            try
            {                
                sqlReader = await commandListBox.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(sqlReader["Название департамента"].ToString());
                    listKodeDepartment.Add(sqlReader["Код департамента"].ToString());
                }
               
                sqlReader.Close();
                listBox1.SetSelected(0, true);

                sqlReader = await commandTimetablesYears.ExecuteReaderAsync();
                string year = "";
                while (await sqlReader.ReadAsync())
                    if (year != sqlReader["Дата"].ToString().Substring(6, 4))
                    {
                        year = sqlReader["Дата"].ToString().Substring(6, 4);
                        comboBoxYears.Items.Add(year);
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(sqlReader!=null)
                    sqlReader.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search.Enabled = false;

            string Inquiry = listKodeDepartment[listBox1.SelectedIndex];
            SqlCommand commandTimetablesEmployees = new SqlCommand("SELECT [Табельный №] FROM [Employees] WHERE [Код департамента]=" + Inquiry, sqlConnection);
            sqlReader = commandTimetablesEmployees.ExecuteReader();
            comboBoxTimetables.Items.Clear();
            while (sqlReader.Read())
                comboBoxTimetables.Items.Add(sqlReader["Табельный №"].ToString());
            sqlReader.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void кодировкаОтметокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sqlReader = null;
            SqlCommand commandMark = new SqlCommand("SELECT * FROM [Mark_in_timetable]", sqlConnection);
            try
            {
                sqlReader = await commandMark.ExecuteReaderAsync();
                string message="";
                while (await sqlReader.ReadAsync())
                    message+=sqlReader["Кодировка"].ToString()+"\t"+ sqlReader["Описание"].ToString()+".\n";
                MessageBox.Show(message, "Кодировки");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\n\nПовторите снова!", ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void табелиСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlReader = null;
            SqlCommand commandTimetablesYears = new SqlCommand("SELECT [Фамилия],[Имя],[Табельный №] FROM [Employees] ORDER BY [Фамилия]", sqlConnection);
            try
            {
                sqlReader = await commandTimetablesYears.ExecuteReaderAsync();
                List<string> message=new List<string>();
                while (await sqlReader.ReadAsync())
                    message.Add(sqlReader["Фамилия"].ToString() + " " + sqlReader["Имя"].ToString() + "\t\t\t" + sqlReader["Табельный №"].ToString());

                FormTimeTableEmployees newForm = new FormTimeTableEmployees(this, message);
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+"\n\nПовторите снова!", ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void Search_Click(object sender, EventArgs e)
        {
            sqlReader = null;
            listBoxFirstName.Items.Clear();
            listBoxLastName.Items.Clear();
            listBoxBirthday.Items.Clear();
            listBoxAge.Items.Clear();
            listBoxPosition.Items.Clear();
            listBoxRemoteWork.Items.Clear();
            listBoxAddress.Items.Clear();

            SqlCommand commandEmployees = new SqlCommand("SELECT * FROM [Employees] WHERE [Табельный №]="+comboBoxTimetables.SelectedItem, sqlConnection);
            try
            {
                sqlReader = await commandEmployees.ExecuteReaderAsync();
                await sqlReader.ReadAsync();
                listBoxFirstName.Items.Add(sqlReader["Имя"].ToString());
                listBoxLastName.Items.Add(sqlReader["Фамилия"].ToString());
                listBoxBirthday.Items.Add(sqlReader["Дата рождения"].ToString().Substring(0,10));
                listBoxAge.Items.Add(sqlReader["Возраст"].ToString());
                listBoxPosition.Items.Add(sqlReader["Должность"].ToString());
                if (sqlReader["Удаленная работа"].ToString() == "True")
                    listBoxRemoteWork.Items.Add("Да");
                else if (sqlReader["Удаленная работа"].ToString() == "False")
                    listBoxRemoteWork.Items.Add("Нет");
                else { }
                listBoxAddress.Items.Add(sqlReader["Адрес проживания"].ToString());

                sqlReader.Close();

                if (comboBoxMonth.SelectedItem != null && comboBoxYears.SelectedItem != null)
                    CalendarInGridView(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\n\nПовторите снова!", ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void CalendarInGridView(object sender, EventArgs e)
        {
            string Inquiry = comboBoxTimetables.SelectedItem.ToString();
            string dateMonth = (comboBoxMonth.SelectedIndex+1).ToString();
            dateMonth = dateMonth.Length == 1 ? "0" + dateMonth : dateMonth;
            string dateYears = comboBoxYears.SelectedItem.ToString();

            SqlCommand commandCalendar = new SqlCommand("SELECT [Дата],[Отметка] FROM [Production_calendar] WHERE [№ сотрудника]=" + Inquiry, sqlConnection);
            sqlReader = commandCalendar.ExecuteReader();

            dataGridViewCalendar.Rows.Clear();
            List<string[]> listCalendar = new List<string[]>();
            while (sqlReader.Read())
                if (sqlReader[0].ToString().Substring(3, 7) == dateMonth + "." + dateYears)
                {
                    listCalendar.Add(new string[3]);
                    listCalendar[listCalendar.Count - 1][0] = sqlReader[0].ToString().Substring(0, 10);
                    listCalendar[listCalendar.Count - 1][1] = sqlReader[1].ToString();
                }
            foreach (string[] s in listCalendar)
                dataGridViewCalendar.Rows.Add(s);
        }

            private void comboBoxTimetables_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search.Enabled = true;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin newForm = new FormLogin(this);
            newForm.ShowDialog();
        }
    }
}
