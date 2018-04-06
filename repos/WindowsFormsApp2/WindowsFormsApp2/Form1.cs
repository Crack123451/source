using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diskName = string.Empty;

            //предварительно очищаем список
            listBox1.Items.Clear();

            //Получение списка накопителей подключенных через интерфейс USB
            foreach (System.Management.ManagementObject drive in
                      new System.Management.ManagementObjectSearcher(
                       "select * from Win32_DiskDrive where InterfaceType='USB'").Get())
            {
                //Получаем букву накопителя
                foreach (System.Management.ManagementObject partition in
                new System.Management.ManagementObjectSearcher(
                    "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + drive["DeviceID"]
                      + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
                {
                    foreach (System.Management.ManagementObject disk in
                 new System.Management.ManagementObjectSearcher(
                        "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='"
                          + partition["DeviceID"]
                          + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
                    {
                        //Получение буквы устройства
                        diskName = disk["Name"].ToString().Trim();
                        listBox1.Items.Add("Буква накопителя=" + diskName);
                    }
                }

                //Получение модели устройства
                listBox1.Items.Add("Модель=" + drive["Model"]);

                //Получение Ven устройства
                listBox1.Items.Add("Ven=" +
                 parseVenFromDeviceID(drive["PNPDeviceID"].ToString().Trim()));

                //Получение Prod устройства
                listBox1.Items.Add("Prod=" +
                 parseProdFromDeviceID(drive["PNPDeviceID"].ToString().Trim()));

                //Получение Rev устройства
                listBox1.Items.Add("Rev=" +
                 parseRevFromDeviceID(drive["PNPDeviceID"].ToString().Trim()));

                //Получение серийного номера устройства
                string serial = drive["SerialNumber"].ToString().Trim();
                //WMI не всегда может вернуть серийный номер накопителя через данный класс
                if (serial.Length > 1)
                    listBox1.Items.Add("Серийный номер=" + serial);
                else
                    //Если серийный не получен стандартным путем,
                    //Парсим информацию Plug and Play Device ID 
                    listBox1.Items.Add("Серийный номер=" +
                   parseSerialFromDeviceID(drive["PNPDeviceID"].ToString().Trim()));

                //Получение объема устройства в гигабайтах
                decimal dSize = Math.Round((Convert.ToDecimal(
              new System.Management.ManagementObject("Win32_LogicalDisk.DeviceID='"
                      + diskName + "'")["Size"]) / 1073741824), 2);
                listBox1.Items.Add("Полный объем=" + dSize + " gb");

                //Получение свободного места на устройстве в гигабайтах
                decimal dFree = Math.Round((Convert.ToDecimal(
              new System.Management.ManagementObject("Win32_LogicalDisk.DeviceID='"
                      + diskName + "'")["FreeSpace"]) / 1073741824), 2);
                listBox1.Items.Add("Свободный объем=" + dFree + " gb");

                //Получение использованного места на устройстве
                decimal dUsed = dSize - dFree;
                listBox1.Items.Add("Используемый объем=" + dUsed + " gb");

                listBox1.Items.Add("");
            }
        }

        private string parseSerialFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string[] serialArray;
            string serial;
            int arrayLen = splitDeviceId.Length - 1;

            serialArray = splitDeviceId[arrayLen].Split('&');
            serial = serialArray[0];

            return serial;
        }

        private string parseVenFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string Ven;
            //Разбиваем строку на несколько частей. 
            //Каждая чаcть отделяется по символу &
            string[] splitVen = splitDeviceId[1].Split('&');

            Ven = splitVen[1].Replace("VEN_", "");
            Ven = Ven.Replace("_", " ");
            return Ven;
        }

        private string parseProdFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string Prod;
            //Разбиваем строку на несколько частей. 
            //Каждая чаcть отделяется по символу &
            string[] splitProd = splitDeviceId[1].Split('&');

            Prod = splitProd[2].Replace("PROD_", ""); ;
            Prod = Prod.Replace("_", " ");
            return Prod;
        }

        private string parseRevFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string Rev;
            //Разбиваем строку на несколько частей. 
            //Каждая чаcть отделяется по символу &
            string[] splitRev = splitDeviceId[1].Split('&');

            Rev = splitRev[3].Replace("REV_", ""); ;
            Rev = Rev.Replace("_", " ");
            return Rev;
        }
    }
}
