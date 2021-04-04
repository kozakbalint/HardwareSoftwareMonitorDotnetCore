using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSoftwareMonitor.src
{
    class Drive
    {
        private string rootDir;

        public string RootDir
        {
            get { return rootDir; }
            set { rootDir = value; }
        }

        private string fileSystem;

        public string FileSystem
        {
            get { return fileSystem; }
            set { fileSystem = value; }
        }

        private int totalSize;

        public int TotalSize
        {
            get { return totalSize; }
            set { totalSize = value; }
        }

        private int availableSpace;

        public int AvailableSpace
        {
            get { return availableSpace; }
            set { availableSpace = value; }
        }

        public Drive(string rootDir, string fileSystem, int totalSize, int availableSpace)
        {
            this.rootDir = rootDir;
            this.fileSystem = fileSystem;
            this.totalSize = totalSize;
            this.availableSpace = availableSpace;
        }
    }
}
