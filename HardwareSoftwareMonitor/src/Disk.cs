using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSoftwareMonitor.src
{
    class Disk
    {
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string interfaceType;

        public string InterfaceType
        {
            get { return interfaceType; }
            set { interfaceType = value; }
        }

        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Disk(string manufacturer, string interfaceType, int size)
        {
            this.manufacturer = manufacturer;
            this.interfaceType = interfaceType;
            this.size = size;
        }
    }
}
