namespace Backup
{
    abstract class Storage
    {
        public abstract string mediaName { get; }
        public abstract string model { get; }
        public abstract void Copy(double dataSize);
        public abstract double Capasity();
        public abstract double FreeMemory();
        public abstract void PrintDeviceİnfo();
    }
}
