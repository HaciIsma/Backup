using Backup.Model;
using System;

namespace Backup
{
    class Controller
    {
        public void control()
        {
            Console.CursorVisible = false;
            Console.WriteLine("Choose: ");
            Console.WriteLine("1.DVD\n2.External\n3.Flash");
            bool check = default;
            int input = default;
            check = int.TryParse(Console.ReadLine(), out input);
            switch (input)
            {
                case 1:
                    DVD dvd = new DVD(DVD.DVDType.SingleSayt);
                    break;
                case 2:
                    ExternalHDD externalHDD = new ExternalHDD(ExternalHDD.ExternalHDDType.RPM7200, 500);
                    break;
                case 3:
                    Flash flash = new Flash(Flash.FlashType.f30, 500);
                    break;
                default:
                    Console.WriteLine("Incorrect Choose");
                    break;
            }
        }
    }
}
