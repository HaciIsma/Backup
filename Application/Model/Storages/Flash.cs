using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backup
{
    class Flash : Storage
    {
        public enum FlashType
        {
            f30, f31, f32
        }
        public Flash(FlashType type, int capasity)
        {
            switch (type)
            {
                case FlashType.f30:
                    wRSpeed = 500;
                    break;
                case FlashType.f31:
                    wRSpeed = 1000;
                    break;
                case FlashType.f32:
                    wRSpeed = 1200;
                    break;
            }
            this.capasity = capasity;
        }
        public override string mediaName => "Flash";

        public override string model => wRSpeed == 500 ? "3.0" : wRSpeed == 1000 ? "3.1" : "3.2";

        public override double Capasity()
        {
            return capasity;
        }

        public override void Copy(double dataSize)
        {
            int time_s = (int)(dataSize / wRSpeed);

            if (dataSize % capasity == 0)
            {
                flashSize = (int)(dataSize / capasity);
            }
            else
            {
                flashSize = (int)(dataSize / capasity) + 1;
            }

            freeMemory = flashSize * capasity - dataSize;

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
        int flashSize = default;
        double freeMemory = default;
        double wRSpeed = default; //mbit/s
    }
}
