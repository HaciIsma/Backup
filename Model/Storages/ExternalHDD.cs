using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    class ExternalHDD : Storage
    {
        public override string mediaName => throw new NotImplementedException();

        public override string model => throw new NotImplementedException();

        public override double Capasity()
        {
            throw new NotImplementedException();
        }

        public override void Copy(double dataSize)
        {
            throw new NotImplementedException();
        }

        public override double FreeMemory()
        {
            throw new NotImplementedException();
        }

        public override void PrintDeviceİnfo()
        {
            throw new NotImplementedException();
        }
    }
}
