using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace AutoMeasurement
{
    public partial class Cs : Form
    {
        Settings settings;
        ConnectDevice cnct;

        public static double pribavka;
        public static double vichet;
        public double pribor_value;
        public double pribor_value_vichet;
        public double pribor_value_pribavka;

        private static StandardType standard = StandardType.eSTANDARD_TYPE_CS;
        public Cs(Settings settings)
        {
            InitializeComponent();
            //registr_00_1_2.Checked = true;
            this.settings = settings;
            cnct = new ConnectDevice();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            vvod_freq_1_2.Text = vvod_freq_1_2.Text.Replace(',','.');
            bincode_1_2.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, vvod_freq_1_2.Text, registr_00_1_2.Checked);
            
            if (registr_00_1_2.Checked == true)
            {
                registr_00_1_2.Checked = false;
                registr_01_1_2.Checked = true;
            }
            else
            {
                registr_00_1_2.Checked = true;
                registr_01_1_2.Checked = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void PortNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1_3.Text= textBox1_3.Text.Replace(',', '.');
            CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, textBox1_3.Text, registr_00_1_3.Checked);
            if (registr_00_1_3.Checked == true)
            {
                registr_00_1_3.Checked = false;
                registr_01_1_3.Checked = true;
            }
            else
            {
                registr_00_1_3.Checked = true;
                registr_01_1_3.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double freq_add = 4; // Добавка к частоте 15000004, Гц
            CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, textBox1_3.Text, registrminus_00_1_3.Checked, freq_add);
            minus_4.Text = Convert.ToString(freq_add + Conversion.Val(textBox1_3.Text));

            if (registrminus_00_1_3.Checked == true)
            {
                registrminus_00_1_3.Checked = false;
                registrminus_01_1_3.Checked = true;
            }
            else
            {
                registrminus_00_1_3.Checked = true;
                registrminus_01_1_3.Checked = false;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox_1_2.Checked) registr_00_1_2.Checked = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chekfreq_1_3.Checked)
            {
                registr_00_1_3.Checked = true;
                check_freqminus_1_3.Checked = false;
               
                registrminus_00_1_3.Checked = false;
                registrminus_01_1_3.Checked = false;

            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (registr_01_1_3.Checked) check_freqminus_1_3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_freqminus_1_3.Checked)
            {
                registrminus_00_1_3.Checked = true;
                chekfreq_1_3.Checked        = false;
                registr_00_1_3.Checked      = false;
                registr_01_1_3.Checked      = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (registrminus_01_1_3.Checked) chekfreq_1_3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vvod_freq_1_6.Text = vvod_freq_1_6.Text.Replace(',', '.');
            bincode_1_6.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, vvod_freq_1_6.Text, registr_00_1_6.Checked);
            
            if (registr_00_1_6.Checked == true)
            {
                registr_00_1_6.Checked = false;
                registr_01_1_6.Checked = true;
            }
            else
            {
                registr_00_1_6.Checked = true;
                registr_01_1_6.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1_6.Checked) registr_00_1_6.Checked = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            vvod_freq_1_7_1.Text = vvod_freq_1_7_1.Text.Replace(',', '.');
            vvod_freq_1_7_2.Text = vvod_freq_1_7_2.Text.Replace(',', '.');
            bincode_1_7_1.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, vvod_freq_1_7_1.Text, registr_00_1_7.Checked=true);
            
            bincode_1_7_2.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, vvod_freq_1_7_2.Text, registr_01_1_7.Checked);
            
            if (registr_00_1_7.Checked == true)
            {
                registr_00_1_7.Checked = false;
                registr_01_1_7.Checked = true;
            }
            else
            {
                registr_00_1_7.Checked = true;
                registr_01_1_7.Checked = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1_7.Checked) registr_00_1_7.Checked = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

           vvod_freq_1_9.Text = vvod_freq_1_9.Text.Replace(',', '.');
           CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq.Text, vvod_freq_1_9.Text, registr_00_1_9.Checked);
           freq_1_9.Text = Convert.ToString(ConvertFreq.vivod_formula);

            if (registr_00_1_9.Checked == true)
            {
                registr_00_1_9.Checked = false;
                registr_01_1_9.Checked = true;
            }
            else
            {
                registr_00_1_9.Checked = true;
                registr_01_1_9.Checked = false;
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (chekfreq_1_9.Checked) registr_00_1_9.Checked = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            double freq_add = 0;
          
            string formula = ConvertFreq.calc(standard,Convert.ToDouble(settings.Vibor_freq.Text),Conversion.Val(vvod_freq_1_9.Text),freq_add);

            if (pribavka_chek.Checked==true)
            {
                pribavka = Convert.ToInt64(pribavka_vichet.Text) + Convert.ToInt64(formula);
                pribavka_1_9.Text = Convert.ToString(pribavka);
            }
            else
            { 
                vichet = -(Convert.ToInt64(pribavka_vichet.Text)) +  Convert.ToInt64(formula);
                vichet_1_9.Text = Convert.ToString(vichet);
            }
        }

        private void pribavka_chek_CheckedChanged(object sender, EventArgs e)
        {
            if (pribavka_chek.Checked) vichet_chek.Checked=false;
        }

        private void pribavka_1_9_Click(object sender, EventArgs e)
        {

        }
        private void freq_1_9_Click(object sender, EventArgs e)
        {

        }
        private void vichet_chek_CheckedChanged(object sender, EventArgs e)
        {
            if (vichet_chek.Checked) pribavka_chek.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (perestr_minus_check.Checked)
            {
                registr_per_minus_00_1_9.Checked = true;
                perestr_plus_check.Checked = false;
                vichet_chek.Checked = false;
                pribavka_chek.Checked = false;
                chekfreq_1_9.Checked = false;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegisterType register = registr_per_minus_00_1_9.Checked ? RegisterType.eREGISTER_TYPE_00 :
                                                                      RegisterType.eREGISTER_TYPE_01;

            string bin_code_string = ConvertFreq.Vybor_only(register, vichet);
            CalculatorAndSender.send(settings.Vibor_port.Text, bin_code_string);
            //test.Text = bin_code_string; //тестовая проверка загружаемого кода
            if (registr_per_minus_00_1_9.Checked == true)
            {
                registr_per_minus_00_1_9.Checked = false;
                registr_per_minus_01_1_9.Checked = true;
            }
            else
            {
                registr_per_minus_00_1_9.Checked = true;
                registr_per_minus_01_1_9.Checked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegisterType register = registr_per_plus_00_1_9.Checked ? RegisterType.eREGISTER_TYPE_00 :
                                                                       RegisterType.eREGISTER_TYPE_01;

            string bin_code_string = ConvertFreq.Vybor_only(register, pribavka);
            CalculatorAndSender.send(settings.Vibor_port.Text, bin_code_string);
            //test_2.Text = bin_code_string; //тестовая проверка загружаемого кода

            if (registr_per_plus_00_1_9.Checked == true)
            {
                registr_per_plus_00_1_9.Checked = false;
                registr_per_plus_01_1_9.Checked = true;
            }
            else
            {
                registr_per_plus_00_1_9.Checked = true;
                registr_per_plus_01_1_9.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (perestr_plus_check.Checked)
            {
                registr_per_plus_00_1_9.Checked = true;
                registr_per_minus_01_1_9.Checked = false;
                perestr_minus_check.Checked = false;
                vichet_chek.Checked = false;
                pribavka_chek.Checked = false;
                chekfreq_1_9.Checked = false;
            }
                
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            Hide();
        }

        private void priborfreq_1_9_1_Click(object sender, EventArgs e)
        {

            pribor_value_1_9_1.Text = settings.Cnct.MeasFreq();
            
            try
            {

                pribor_value = Conversion.Val(pribor_value_1_9_1.Text);

                if (pribor_value == 0)
                {
                    pribor_value_1_9_1.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
                }

                else 
                {
                    pribor_value_1_9_1.Text = Convert.ToString(pribor_value) + "Гц"; //используется только для вывода показаний прибора пользователю;

                }

                
            }
            catch
            {
                pribor_value_1_9_1.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void priborfreq_1_9_2_Click(object sender, EventArgs e)
        {
            pribor_value_1_9_2.Text = settings.Cnct.MeasFreq();
            

            try
            {
                pribor_value_vichet = Conversion.Val(pribor_value_1_9_2.Text);

                if (pribor_value_vichet == 0)
                {
                    pribor_value_1_9_2.Text = "Ошибка, подключите прибор! " + "\n" +
                      "Для этого войдите в Настройки->Найти прибор->Подключить";
                }
                else
                {
                    pribor_value_1_9_2.Text = Convert.ToString(pribor_value_vichet) + "Гц";
                }
                

            }
            catch
            {
                pribor_value_1_9_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void priborfreq_1_2_Click(object sender, EventArgs e)
        {
         
            pribor_value_1_2.Text = settings.Cnct.MeasFreq();
            try
            {
                pribor_value = Conversion.Val(pribor_value_1_2.Text);

                if (pribor_value == 0)
                {
                    pribor_value_1_2.Text = "Ошибка, подключите прибор! " + "\n" +
                      "Для этого войдите в Настройки->Найти прибор->Подключить";
                }
                else
                {
                    pribor_value_1_2.Text = Convert.ToString(pribor_value) + "Гц"; //используется только для вывода показаний прибора пользователю;
                }
                
            }
            catch
            {
                pribor_value_1_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void Meas_mark_y_Click(object sender, EventArgs e)
        {
            /*cnct.Connection(); //обращение к прибору для подключения (без обращения к Настройкам)
            if (cnct != null) cnct.Mode = cnct.Mode;
            if (cnct != null) cnct.Address = cnct.Address;*/
            mark_y.Text = settings.Cnct.MeasureMarkY(); 

        }

        private void vivod_step_cs_Click(object sender, EventArgs e)
        {
            try
            {
                //double f1 = Convert.ToDouble(pribor_value_1_9_1.Text); //запрос значения частоты до перестройки
                //double f2 = Convert.ToDouble(pribor_value_1_9_2.Text);// после перестройки
                perestr_step_cs_1.Text = Convert.ToString((pribor_value - pribor_value_vichet) / 10000); // вычисление шага


            }

            catch
            {
                perestr_step_cs_1.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void priborfreq_1_9_3_Click(object sender, EventArgs e)
        {
            pribor_value_1_9_3.Text = settings.Cnct.MeasFreq();
            try
            {
                pribor_value_pribavka = Conversion.Val(pribor_value_1_9_3.Text);

                if (pribor_value_pribavka==0) 
                {

                    pribor_value_1_9_3.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";

                }

                else
                {
                    pribor_value_1_9_3.Text = Convert.ToString(pribor_value_pribavka) + "Гц";
                }

                
            }
            catch
            {
                pribor_value_1_9_3.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void vivod_step_cs_2_Click(object sender, EventArgs e)
        {
            try
            {
                perestr_step_cs_2.Text = Convert.ToString((pribor_value - pribor_value_pribavka) / 10000); // вычисление шага
            }

            catch
            {
                perestr_step_cs_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить"; 
            }

        }

        private void priborfreq_1_6_Click(object sender, EventArgs e)
        {
            pribor_value_1_6.Text = settings.Cnct.MeasFreq();
            try
            {
                pribor_value = Conversion.Val(pribor_value_1_6.Text);

                if (pribor_value == 0)
                {
                    pribor_value_1_6.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
                }

                else
                {
                    pribor_value_1_6.Text = Convert.ToString(pribor_value) + "Гц"; //используется только для вывода показаний прибора пользователю;

                }

               
            }
            catch
            {
                pribor_value_1_6.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void priborfreq_1_7_Click(object sender, EventArgs e)
        {
            pribor_value_1_7.Text = settings.Cnct.MeasFreq();
            try
            {
                pribor_value = Conversion.Val(pribor_value_1_7.Text);

                if (pribor_value==0)
                {
                    pribor_value_1_7.Text = "Ошибка, подключите прибор! " + "\n" +
                   "Для этого войдите в Настройки->Найти прибор->Подключить";
                }

                else
                {
                    pribor_value_1_7.Text = Convert.ToString(pribor_value) + "Гц"; //используется только для вывода показаний прибора пользователю;
                }

                
            }
            catch
            {
                pribor_value_1_7.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pribor_value_1_3.Text = settings.Cnct.MeasFreq();
            try
            {

                
                pribor_value = Conversion.Val(pribor_value_1_3.Text);

                if (pribor_value==0)
                {
                    pribor_value_1_3.Text = "Ошибка, подключите прибор! " + "\n" +
                   "Для этого войдите в Настройки->Найти прибор->Подключить";

                }

                else 
                {
                    pribor_value_1_3.Text = Convert.ToString(pribor_value) + "Гц"; //используется только для вывода показаний прибора пользователю;
                }

                
            }
            catch
            {
                pribor_value_1_3.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }
    }
}
