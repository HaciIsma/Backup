using Backup.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    class Controller
    {
        public void control()
        {
            Console.CursorVisible = false;
            Data a = new Data { Size = 30 };
            DVD abs = new DVD(DVD.DVDType.SingleSayt);
            abs.Capasity();
            abs.Copy(a.Size);
            abs.FreeMemory();
            abs.PrintDeviceİnfo();
        }
    }
}
