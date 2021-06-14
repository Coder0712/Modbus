using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Windows.Forms;

namespace Modbus
{
    public class ModbusTest
    {
        ModbusClient client = new ModbusClient("192.168.8.2", 502);

        public void ConnectModbus()
        {

            client.Connect();

            if (client.Connected)
            {
                Console.WriteLine("Connected to SPS");
            }
            else
            {
                Console.Write("Error with connection");
            }
        }

        public string ReadTemp()
        {
                int temp = 0;
                string strTemp = null;

                // read registers from modbus and give registers 0 to 5 back 
                int[] registers = client.ReadHoldingRegisters(0, 4);

                for (int i = 0; i < registers.Length; ++i)
                {
                    if (i == 3)
                    {
                        temp = registers[i];
                        strTemp = Convert.ToString(temp);
                    }
                }

                return strTemp;
            
        }
    }
}
