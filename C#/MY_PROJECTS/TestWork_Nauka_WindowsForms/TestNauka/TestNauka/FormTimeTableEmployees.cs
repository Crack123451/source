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
    public partial class FormTimeTableEmployees : Form
    {
        public FormTimeTableEmployees(Form1 ParrentForm, List<string> message)
        {
            InitializeComponent();
            foreach(var i in message)
                listBox1.Items.Add(i);
        }

        private void FormTimeTableEmployees_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
