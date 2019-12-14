using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    abstract class Storage
    {
        public string mediaName { get; set; }
        public string model { get; set; }
        public abstract void Copy();
        public abstract decimal Capasity();
        public abstract decimal FreeMemory();
        public abstract void PrintDeviceİnfo();
    }
}
