using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AutoMeasurement
{
    public class CalculatorAndSender
    {


        public static string calc(StandardType standard, string freq_center_string, string freq_curr_string, bool register_00_checked, double freq_add = 0)
        {
            double freq_center  = Convert.ToDouble(freq_center_string); // Входная частота*3 / (*5), Гц
            double freq_current = Conversion.Val(freq_curr_string);   // Текущее значение частоты, Гц

            // Определение регистра
            RegisterType register = register_00_checked ? RegisterType.eREGISTER_TYPE_00 :
                                                          RegisterType.eREGISTER_TYPE_01;

            return ConvertFreq.calc_and_register(standard, freq_center, freq_current, freq_add, register); //обращение к классу вычислений
        }

        // Отправка данных по LPT-порту, только отправка(одинаковая операция для двух стандартов!!!)
        public static void send(string lpt_port_address, string message)
        {
            try
            {
                int address = Convert.ToInt32(lpt_port_address, 16); // Адрес LPT-порта
                PortAccess.send(address, message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при подключении к LPT-порту! Код не был загружен!", "Ошибка");
            }
        }

        public static string calcAndSend(StandardType standard, string lpt_port_address, string freq_center_string, string freq_curr_string, bool register_00_checked, 
                                         double freq_add = 0)
        {
            string bin_code_string = calc(standard, freq_center_string, freq_curr_string, register_00_checked, freq_add);

            // Отправка данных по LPT-порту
            send(lpt_port_address, bin_code_string);

            return bin_code_string;
        }
    }
}
