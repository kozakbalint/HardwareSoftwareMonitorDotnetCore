﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSoftwareMonitor.src
{
    class InstalledApp
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public InstalledApp(string name, string version)
        {
            this.name = name;
            this.version = version;
        }
    }
}
