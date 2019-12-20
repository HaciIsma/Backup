using System;
using System.Threading;

namespace Backup
{
    class ExternalHDD : Storage
    {
        enum ExternalHDDType
        {
            RPM5400 , RPM7200 , RPM10000
        }

        ExternalHDD(ExternalHDDType type, int capasity)
        {
            switch (type)
            {
                case ExternalHDDType.RPM5400:
                    wRSpeed = 75;
                    break;
                case ExternalHDDType.RPM7200:
                    wRSpeed = 120;
                    break;
                case ExternalHDDType.RPM10000:
                    wRSpeed = 140;
                    break;
            }
            this.capasity = capasity;
        }
        public override string mediaName => "ExternalHDD";

        public override string model => wRSpeed == 75 ? "5400 RPM" : wRSpeed == 120 ? "7200 RPM" : "10.000 RPM";

        public override double Capasity()
        {
            return capasity;
        }

        public override void Copy(double dataSize)
        {
            int time_s = (int)(dataSize / wRSpeed);

            if (dataSize % capasity == 0)
            {
                HDDSize = (int)(dataSize / capasity);
            }
            else
            {
                HDDSize = (int)(dataSize / capasity) + 1;
            }

            freeMemory = HDDSize * capasity - dataSize;

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
        double wRSpeed = default;
        int HDDSize = default;
        double freeMemory = default;
    }
}
