using Backup.Model;
using System;

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
            var free = abs.FreeMemory();
            abs.PrintDeviceİnfo();
            Console.WriteLine($"Free : {free}");
        }
    }
}
