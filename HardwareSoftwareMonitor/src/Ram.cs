using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSoftwareMonitor.src
{
    class Ram
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public Ram(string name, string manufacturer, string model, int capacity)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            this.capacity = capacity;
        }
    }
}
