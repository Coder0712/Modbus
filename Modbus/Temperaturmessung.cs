using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus
{
    public partial class Temperaturmessung : Form
    {
        ModbusTest modbus = new ModbusTest();

        public Temperaturmessung()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            modbus.ConnectModbus();
        }

        private void btnMessung_Click(object sender, EventArgs e)
        {
            tbTemp.Text = modbus.ReadTemp();
        }
    }
}
