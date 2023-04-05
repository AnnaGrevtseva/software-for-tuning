using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ivi.Visa.Interop;
using System.Threading;

namespace AutoMeasurement
{
     public class ConnectDevice
    {
        ResourceManager rm;
        FormattedIO488 Device;
        string address = "USB0::5355::145::158208::0::INSTR"; //адрес прибора выбирается пользователем в настройках
        string mode = "READ";
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        } // адрес прибора выбранный пользователем 
        public string Mode
        {
            set
            {
                mode = value;
            }
            get
            {
                return mode;
            }
        }
    
       //режим измерения прибора 
       public ConnectDevice()
        {
            rm = new ResourceManager();
            Device = new FormattedIO488();

        }
        public string Connection()
        {

            try
            {
                Device.IO = (IMessage)rm.Open(address, AccessMode.NO_LOCK, 2000, ""); //открывает соединение с прибором
                return "Ok";
            }
            catch
            {
                return "Error";

            }

        }
        public void CloseSession() // закрывает соединение с прибором 
        {
            Device.IO.Close();
        }
        public string MeasFreq() //функция запроса значения частоты прибора
        {

            try
            {

                 if (Mode == "MEAS")
                {
                    Device.WriteString("MEAS:FREQ?");
                    return Device.ReadString();
                }
                else if (Mode == "FETCH")
                {
                    Device.WriteString("FETCH:FREQ?");
                    return Device.ReadString();
                }
                else if (Mode == "READ")
                {
                    Device.WriteString("READ:FREQ?");
                    return Device.ReadString();
                }
                else
                {
                    Device.WriteString("MEAS:FREQ?");
                    return Device.ReadString();
                }
            }
            catch
            {
                return "Ошибка, подключите прибор! " +
                    "Для этого войдите в Настройки->Найти прибор->Подключить";
            }

        }
        public string[] FindDevice() //функция поиска доступных измерительных приборов
        {
            try
            {

                ResourceManager rm = new ResourceManager();
                string[] addresses = rm.FindRsrc("?*INSTR");
                return addresses;
            }
            catch
            {
                return null;
            }
        }
        public string Info()

        {
            try
            {
                Device.WriteString("*IDN?");
                return Device.ReadString();
            }
            catch
            {
                return "Ошибка";
            }

        }


        public string MeasureMarkY() // получение значения с анализатора спектра
        {                                      
            try
            {
                Device.WriteString("CALC:SPEC:MARK1:Y?"); // Считывание необходимой строки!!!
                var y = Device.ReadString().Replace("\n", "");
                return y;
            }
            catch (Exception ex)
            {
                return "Error"+ "\n_Source: " + ex.Source; 
            }
        }
        public string MeasureMarkY1() // тестовая функция для проверки команд с анализатора спектра
        {

            try
            {
                Device.WriteString("*IDN?"); // проверка команд прибора
                var y = Device.ReadString().Replace("\n", "");
                return y;
            }
            catch (Exception ex)
            {
                return "Error" + "\n_Source: " + ex.Source; 
            }
        }
    }
} 
