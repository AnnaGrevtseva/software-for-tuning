using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace AutoMeasurement
{
    public partial class Rb : Form
    {

        Settings settings;
        ConnectDevice cnct;

        public static double pribavka;
        public static double vichet;
        public double pribor_value;
        public double pribor_value_vichet;
        public double pribor_value_pribavka;

        private static StandardType standard = StandardType.eSTANDARD_TYPE_RB;

        public Rb(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            cnct = new ConnectDevice();
            //registr_00_1_8.Checked = true;
        }

       
        private void button_TY_1_2_rub_Click(object sender, EventArgs e)
        {

            vvod_freq_1_2_rub.Text= vvod_freq_1_2_rub.Text.Replace(',', '.');
            bincode_1_2_rub.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq_rub.Text, vvod_freq_1_2_rub.Text, registr_00_1_2_rub.Checked);
            
            if (registr_00_1_2_rub.Checked == true)
            {
                registr_00_1_2_rub.Checked = false;
                registr_01_1_2_rub.Checked = true;
            }
            else
            {
                registr_00_1_2_rub.Checked = true;
                registr_01_1_2_rub.Checked = false;
            }
        }

        private void checkBox_1_2_rub_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1_2_rub.Checked) registr_00_1_2_rub.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vvod_freq_1_6_1.Text = vvod_freq_1_6_1.Text.Replace(',', '.');
            vvod_freq_1_6_2.Text = vvod_freq_1_6_2.Text.Replace(',', '.');

            if (registr_00_1_6.Checked == true)
            {
                bincode_1_6_1.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq_rub.Text, vvod_freq_1_6_1.Text, registr_00_1_6.Checked);
            }

            else
            {
                bincode_1_6_1.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq_rub.Text, vvod_freq_1_6_2.Text, registr_00_1_6.Checked);
            }

            //registr_01_1_6.Checked = true;

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

        private void checkBox_1_6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1_6_1.Checked)
            {
                registr_00_1_6.Checked = true;
                checkBox_1_6_2.Checked = false;


            }

        }


        private void vivod_SCH_1_1_Click(object sender, EventArgs e)
        {


            vvod_freq_1_6_3.Text = vvod_freq_1_6_3.Text.Replace(',', '.');
            vvod_freq_1_6_4.Text = vvod_freq_1_6_4.Text.Replace(',', '.');
            if (registr_00_1_6_1.Checked == true)
            {
                bincode_1_6_2.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq_rub.Text, vvod_freq_1_6_3.Text, registr_00_1_6_1.Checked);
            }

            else
            {
                bincode_1_6_2.Text = CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq_rub.Text, vvod_freq_1_6_4.Text, registr_00_1_6_1.Checked);
            }

            if (registr_00_1_6_1.Checked == true)
            {
                registr_00_1_6_1.Checked = false;
                registr_01_1_6_1.Checked = true;
            }
            else
            {
                registr_00_1_6_1.Checked = true;
                registr_01_1_6_1.Checked = false;
            }

        }

        private void checkBox_1_1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_1_6_2.Checked)
            {
                registr_00_1_6_1.Checked = true;
                checkBox_1_6_1.Checked = false;

            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            Hide();
        }

        private void priborfreq_Click(object sender, EventArgs e)
        {
            pribor_value_1_2.Text = settings.Cnct.MeasFreq();
            
            try
            {
                pribor_value = Conversion.Val(pribor_value_1_2.Text);


                if (pribor_value==0)
                {
                    pribor_value_1_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
                }

                else
                {
                    pribor_value_1_2.Text = Convert.ToString(pribor_value) + "Гц";

                }

                
            }
            catch
            {
                pribor_value_1_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void vivod_SCH_1_8_Click(object sender, EventArgs e)
        {
            vvod_freq_1_8_1.Text = vvod_freq_1_8_1.Text.Replace(',', '.');

            CalculatorAndSender.calcAndSend(standard, settings.Vibor_port.Text, settings.Vibor_freq_rub.Text, vvod_freq_1_8_1.Text, registr_00_1_8.Checked);
           freq_1_8_rub.Text = Convert.ToString(ConvertFreq.vivod_formula);

            if (registr_00_1_8.Checked == true)
            {
                registr_00_1_8.Checked = false;
                registr_01_1_8.Checked = true;
            }
            else
            {
                registr_00_1_8.Checked = true;
                registr_01_1_8.Checked = false;
            }



        }

        private void result_pribavka_rub_Click(object sender, EventArgs e)
        {
            
            double freq_add = 0;

            string formula = ConvertFreq.calc(standard, Convert.ToDouble(settings.Vibor_freq_rub.Text), Convert.ToDouble(vvod_freq_1_8_1.Text), freq_add);

            if (pribavka_chek_rub.Checked == true)
            {
                pribavka = Convert.ToInt64(pribavka_vichet_rub.Text) + Convert.ToInt64(formula);
                pribavka_1_8.Text = Convert.ToString(pribavka);


            }
            else if (vichet_chek_rub.Checked==true)
            {
                vichet = -(Convert.ToInt64(pribavka_vichet_rub.Text)) + Convert.ToInt64(formula);
                vichet_1_8.Text = Convert.ToString(vichet);
            }
        }

        private void pribavka_chek_rub_CheckedChanged(object sender, EventArgs e)
        {
            if (pribavka_chek_rub.Checked==true) 
            {
                vichet_chek_rub.Checked = false;
                perestr_minus_check_rub.Checked = false;

            } 
        }

        private void vichet_chek_rub_CheckedChanged(object sender, EventArgs e)
        {
            if (vichet_chek_rub.Checked == true) 
            {
                pribavka_chek_rub.Checked = false;
                perestr_plus_check_rub.Checked = false;
            }
            
        }

        private void vivod_perestr__minus_1_8_Click(object sender, EventArgs e)
        {
            RegisterType register = registr_per_minus_00_1_8.Checked ? RegisterType.eREGISTER_TYPE_00 :
                           RegisterType.eREGISTER_TYPE_01;

            
            string bin_code_string = ConvertFreq.Vybor_only(register, vichet);// только выбор регистра
            CalculatorAndSender.send(settings.Vibor_port.Text,bin_code_string); //отправка кода

            //test.Text = bin_code_string;

            if (registr_per_minus_00_1_8.Checked == true)
            {
                registr_per_minus_00_1_8.Checked = false;
                registr_per_minus_01_1_8.Checked = true;
            }
            else
            {
                registr_per_minus_00_1_8.Checked = true;
                registr_per_minus_01_1_8.Checked = false;
            }

        }

        private void vivod_perestr__plus_1_9_Click(object sender, EventArgs e)
        {
            RegisterType register = registr_per_plus_00_1_8.Checked ? RegisterType.eREGISTER_TYPE_00 :
               RegisterType.eREGISTER_TYPE_01;

            string bin_code_string = ConvertFreq.Vybor_only(register, pribavka); //только выбор регистра
            CalculatorAndSender.send(settings.Vibor_port.Text, bin_code_string); // отправка кода

            //test.Text = bin_code_string;

            if (registr_per_plus_00_1_8.Checked == true)
            {
                registr_per_plus_00_1_8.Checked = false;
                registr_per_plus_01_1_8.Checked = true;
            }
            else
            {
                registr_per_plus_00_1_8.Checked = true;
                registr_per_plus_01_1_8.Checked = false;
            }
        }

        private void perestr_minus_check_rub_CheckedChanged(object sender, EventArgs e)
        {
            if (perestr_minus_check_rub.Checked)
            {
                registr_per_minus_00_1_8.Checked = true;
                perestr_plus_check_rub.Checked = false;
                vichet_chek_rub.Checked = false;
                pribavka_chek_rub.Checked = false;
                chekfreq_1_8.Checked = false;

            }
        }

        private void perestr_plus_check_rub_CheckedChanged(object sender, EventArgs e)
        {
            if (perestr_plus_check_rub.Checked)
            {
                registr_per_plus_00_1_8.Checked = true;
                perestr_minus_check_rub.Checked = false;
                vichet_chek_rub.Checked = false;
                pribavka_chek_rub.Checked = false;
                chekfreq_1_8.Checked = false;
            }
        }

        private void priborfreq_1_8_1_Click(object sender, EventArgs e)
        {
            pribor_value_1_8_1.Text=settings.Cnct.MeasFreq(); // settings.Cnct.- передает конкретный выбор пользователя
            try
            {
                // передаем в другом формате, преобразуем в double
                pribor_value = Conversion.Val(pribor_value_1_8_1.Text);

                if (pribor_value == 0)
                {
                    pribor_value_1_8_1.Text = "Ошибка, подключите прибор! " + "\n" +
                   "Для этого войдите в Настройки->Найти прибор->Подключить";
                }


                else
                {
                    pribor_value_1_8_1.Text = Convert.ToString(pribor_value) + "Гц";
                }

                
            }
            catch
            {
                pribor_value_1_8_1.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
            
            
            
        }

        private void chekfreq_1_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chekfreq_1_8.Checked) registr_00_1_8.Checked = true;
        }

        private void priborfreq_1_8_2_Click(object sender, EventArgs e)
        {
            pribor_value_1_8_2.Text = settings.Cnct.MeasFreq();
            try
            {
                pribor_value_vichet = Conversion.Val(pribor_value_1_8_2.Text);

                if (pribor_value_vichet == 0)
                {
                    pribor_value_1_8_2.Text = "Ошибка, подключите прибор! " + "\n" +
                   "Для этого войдите в Настройки->Найти прибор->Подключить";
                }

                else
                {
                    pribor_value_1_8_2.Text = Convert.ToString(pribor_value_vichet) + "Гц";
                }

                
            }
            catch
            {
                pribor_value_1_8_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }

        }

        private void vivod_step_Click(object sender, EventArgs e) //вычисление шага перестройки 
        {
            try
            {
                //double f1 = Convert.ToDouble(pribor_value_1_8_1.Text);
                //double f2 = Convert.ToDouble(pribor_value_1_8_2.Text); было (f1-f2)
                perestr_step_value_1.Text = Convert.ToString((pribor_value-pribor_value_vichet) / 10000); //согласно ТУ шаг=6.8*10^-4 Гц
                // вычисление шага перестройки, добавлять ли размерность???
            }

            catch
            {
                perestr_step_value_1.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
            
        }

        private void priborfreq_1_8_3_Click(object sender, EventArgs e)
        {
            pribor_value_1_8_3.Text = settings.Cnct.MeasFreq(); // смотреть предыдущую реализацию соединения в Cs
            try
            {
                pribor_value_pribavka = Conversion.Val(pribor_value_1_8_3.Text);

                if (pribor_value_pribavka == 0)
                {
                    pribor_value_1_8_3.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";

                }

                else
                {

                    pribor_value_1_8_3.Text = Convert.ToString(pribor_value_pribavka) + "Гц";

                }

                
            }
            catch
            {
                pribor_value_1_8_3.Text = "Ошибка, подключите прибор! " + "\n"+
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }

        private void vivod_step_2_Click(object sender, EventArgs e)
        {
            try 
            {
                perestr_step_value_2.Text = Convert.ToString((pribor_value - pribor_value_pribavka) / 10000); 
                //согласно ТУ шаг=6.8*10^-4 Гц
                //вычисление шага перестройки добавлять ли размерность???
            }
            catch
            {
                perestr_step_value_2.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }

        }

        private void priborfreq_1_6_Click(object sender, EventArgs e)
        {
            pribor_value_1_6.Text = settings.Cnct.MeasFreq();

            try
            {
                pribor_value = Conversion.Val(pribor_value_1_6.Text);


                if (pribor_value==0)
                {
                    pribor_value_1_6.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";

                }

                else
                {
                    pribor_value_1_6.Text = Convert.ToString(pribor_value) + "Гц";
                }

                
            }
            catch
            {
                pribor_value_1_6.Text = "Ошибка, подключите прибор! " + "\n" +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }
        }
    }
}
