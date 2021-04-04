using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareSoftwareMonitor.src
{
    class Gpu
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int vram;

        public int Vram
        {
            get { return vram; }
            set { vram = value; }
        }

        private int verticalRes;

        public int VerticalRes
        {
            get { return verticalRes; }
            set { verticalRes = value; }
        }

        private int horizontalRes;

        public int HorizontalRes
        {
            get { return horizontalRes; }
            set { horizontalRes = value; }
        }

        private int refreshRate;

        public int RefreshRate
        {
            get { return refreshRate; }
            set { refreshRate = value; }
        }

        public Gpu(string name, int vram, int verticalRes, int horizontalRes, int refreshRate)
        {
            this.name = name;
            this.vram = vram;
            this.verticalRes = verticalRes;
            this.horizontalRes = horizontalRes;
            this.refreshRate = refreshRate;
        }
    }
}
