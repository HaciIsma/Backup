using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backup
{
    class DVD : Storage
    {
        public enum DVDType
        {
            SingleSayt = 0, DoubleSayt
        }
        public DVD(DVDType type)
        {
            if (type == DVDType.SingleSayt) { capasity = 4.7; }
            else if (type == DVDType.DoubleSayt) { capasity = 9; }
        }

        public override double Capasity()
        {
            return capasity;
        }
        public override void Copy(double dataSize)
        {
            int time_s = (int)(dataSize / wRSpeed);

            if (dataSize % capasity == 0)
            {
                dvdSize = (int)(dataSize / capasity);
            }
            else
            {
                dvdSize = (int)(dataSize / capasity) + 1;
            }

            freeMemory = dvdSize * capasity - dataSize;

            while (time_s != 0)
            {
                Console.WriteLine($"Copy {time_s} second remained");
                --time_s;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public override double FreeMemory()
        {
            return freeMemory;
        }

        public override void PrintDeviceİnfo()
        {
            Console.WriteLine("DVD");
            Console.WriteLine($"Capasity: {capasity}");
            Console.WriteLine($"Write/Read speed: {wRSpeed}");
        }

        double capasity = default(double);
        int dvdSize = default(int);
        double freeMemory = default(double);
        double wRSpeed = 1.32; //mbit/s

        public override string mediaName { get => "DVD";  }
        public override string model { get => (capasity == 4.7) ? "SingleSayt" : "DoubleSayt"; }
    }
}
