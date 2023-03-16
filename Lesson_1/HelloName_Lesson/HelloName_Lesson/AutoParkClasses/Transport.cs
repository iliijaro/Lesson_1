using System;
namespace HelloName_Lesson.AutoParkClasses
{
    abstract public class Transport : IComparable
    {
        public string destination { get; set; }
        public int transportNumber { get; set; }
        public string departureTime { get; set; }
        public int amountOfSeats { get; set; }

        public Transport() { }

        public virtual void GetInfo() { }

        abstract public string GetTheTransportType();

        public virtual int CompareTo(object? obj)
        {
            if (obj is Transport transport)
            {
                return amountOfSeats.CompareTo(transport.amountOfSeats);
            }
            return 0;
        }
    }
}