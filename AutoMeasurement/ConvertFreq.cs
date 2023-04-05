using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AutoMeasurement
{
    public enum StandardType
    {
        eSTANDARD_TYPE_CS = 0,
        eSTANDARD_TYPE_RB
    }

    public enum RegisterType
    {
        eREGISTER_TYPE_NONE = -1,
        eREGISTER_TYPE_00,
        eREGISTER_TYPE_01
    }
    class ConvertFreq
    {   
        public  const  int    num_digits = 40; // Количестов разрядов
        private static double formula;
        public static double vivod_formula;
        int[] ldata = new int[5] { 255, 247, 254, 246, 239 }; // для функции отправки 
        
        private static string Del_Method(Int64 x) // перевод частоты в двоичный код
        {            
           return (x > 0)? Convert.ToString(x, 2) : "";
        }

        private static double calcFormula(StandardType standard, double freq_center, double f1, double freq_add) // вычисления для цезиевого стандарта
        {     
           return formula = (standard == StandardType.eSTANDARD_TYPE_CS) ? Math.Truncate( Math.Exp(num_digits * Math.Log(2)) * ((freq_center + freq_add - (Convert.ToDouble(f1))) / freq_center)) :
                            (standard == StandardType.eSTANDARD_TYPE_RB) ? Math.Truncate( Math.Exp(num_digits * Math.Log(2)) * (((Convert.ToDouble(f1))) / freq_center)) :
                                                                           0;
        }

        private static string Vybor(RegisterType register, double formula) // выбор регистра
        {
            if (register == RegisterType.eREGISTER_TYPE_NONE)
                return "";

            string str_end = "";
            if (register == RegisterType.eREGISTER_TYPE_00)
                str_end = "00";
            else if (register == RegisterType.eREGISTER_TYPE_01)
                str_end = "10";

            return ("00" + Del_Method(Convert.ToInt64(formula)) + str_end);
        }

        public static string calc_and_register(StandardType standard, double freq_center, double f1, double freq_add, RegisterType register)
        {
            vivod_formula = calcFormula(standard, freq_center, f1, freq_add);
            return Vybor(register, formula);
        }

        public static string calc(StandardType standard, double freq_center, double f1, double freq_add) //сделано для пункта 1.1.9 ТУ цезиевого стандарта, только вычисление формы без регистра.

        {
            string calc= Convert.ToString(calcFormula(standard, freq_center, f1, freq_add));
            return calc;
        }

        public static string Vybor_only(RegisterType register, double value)// сделано для пункта 1.1.9 ТУ цезиевого и для пункта 1.1.8 рубидиевого стандартов, только выбор регистра, без вычисления формулы.
        {
            if (register == RegisterType.eREGISTER_TYPE_NONE)
                return "";

            string str_end = "";
            if (register == RegisterType.eREGISTER_TYPE_00)
                str_end = "00";
            else if (register == RegisterType.eREGISTER_TYPE_01)
                str_end = "10";

            return ("00" + Del_Method(Convert.ToInt64(value)) + str_end);
        }
    }
}
