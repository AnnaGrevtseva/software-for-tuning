using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
//using Microsoft.VisualBasic;

namespace AutoMeasurement
{
    class PortAccess
    {
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int adress, int value);

        [DllImport("inpout32.dll", EntryPoint = "Inp32")]
        public static extern int Input(int adress);

        private static void Pause() // пауза
        {
            for (int i = 0; i < 10000; i++) { }
        }

        public static void send(int address, string message)
        {
            message = message.Replace("1", "2"); //инвертирование кода
            message = message.Replace("0", "1");
            message = message.Replace("2", "0");
            for (int i = message.Length - 1; i >= 0; --i)
            {
                string code = message.Substring(i, 1);

                Pause();    //Thread.Sleep(1);
                PortAccess.Output(address, Convert.ToInt32("0000000" + code, 2));
                Pause();    //Thread.Sleep(1);
                PortAccess.Output(address, Convert.ToInt32("0000100" + code, 2)); //сдвиг (5 контакт)
                Pause();   //Thread.Sleep(1);
                PortAccess.Output(address, Convert.ToInt32("0000000" + code, 2));
            }

            PortAccess.Output(address, Convert.ToInt32("00000000", 2));
            Pause();
            PortAccess.Output(address, Convert.ToInt32("00010000", 2)); // строб-импульс (6 контакт)
            Pause();
            PortAccess.Output(address, Convert.ToInt32("00000000", 2));
        }
    }
}
