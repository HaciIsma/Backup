using System;
using System.Threading;

namespace Backup
{
    class DVD : Storage
    {
        public enum DVDType
        {
            SingleSayt , DoubleSayt
        }
        public DVD(DVDType type)
        {
            switch (type)
            {
                case DVDType.SingleSayt:
                    capasity = 4.7;
                    break;
                case DVDType.DoubleSayt:
                    capasity = 9;
                    break;
            }
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
            Console.WriteLine($"Media name: {mediaName}");
            Console.WriteLine($"Model : {model}");
            Console.WriteLine($"Capasity: {capasity}");
            Console.WriteLine($"Write/Read speed: {wRSpeed}");
        }

        double capasity = default;
        int dvdSize = default;
        double freeMemory = default;
        double wRSpeed = 1.32; //mbit/s

        public override string mediaName { get => "DVD"; }
        public override string model { get => (capasity == 4.7) ? "SingleSayt" : "DoubleSayt"; }
    }
}
