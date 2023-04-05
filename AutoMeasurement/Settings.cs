using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace AutoMeasurement
{
    public partial class Settings : Form
    {

        ConnectDevice cnct;
        public Settings(ConnectDevice cnct)
        {
            InitializeComponent();

            this.cnct = cnct;
            // Form1 frm = (Form1)this.Owner;
        }

       

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }










        private void vibor_freq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public TextBox Vibor_freq { get { return vibor_freq; } } //выбор начальной домноженной частоты;
        public TextBox Vibor_freq_rub { get { return vibor_freq_rub; } }// выбор начальной домноженной частоты для рубидия (каждый раз переключаьб комбобокс неудобно)
       
        public TextBox Vibor_port { get { return PortNumber; } } //выбор порта

        public ConnectDevice Cnct { get => cnct; set => cnct = value; }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            Hide();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            cnct.Address = DeviceList.Text;
            if (cnct.Connection() == "Error") MessageBox.Show("Ошибка подключения к прибору, нажмите Найти прибор!", "Ошибка");
            string Info = cnct.Info();
            DeviceInfo.Text = "Информация о приборе: " + Info;
            //cnct.CloseSession(); (если закрыть сессию, то передача адреса прибора из настройки невозможна!)

        }

        private void DeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DeviceInfo_Click(object sender, EventArgs e)
        {

        }


       

        private void DeviceList_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void DeviceList_Click(object sender, EventArgs e)
        {

        }

        private void FindDevice_Click(object sender, EventArgs e)
        {
            DeviceList.Items.Clear();// очистим список
            string[] addresses = cnct.FindDevice();// принимаем список доступных девайсов
            if (addresses != null)
            {
                foreach (string adr in addresses)// создаем список для выбора пользователя
                {
                    DeviceList.Items.Add(adr);
                }
            }
            DeviceList.DroppedDown = true;//разворачивает комбобокс
        }
    }
}

