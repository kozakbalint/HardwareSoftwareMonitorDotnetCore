using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSoftwareMonitor.src
{
    class MotherBoard
    {
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string product;

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        public MotherBoard(string manufacturer, string product)
        {
            this.manufacturer = manufacturer;
            this.product = product;
        }
    }
}
