using System;
namespace HelloName_Lesson.AutoParkClasses
{
    public class Bus : Transport
    {
        public Bus(string destination, int transportNumber, string departureTime, int amountOfSeats)
        {
            this.destination = destination;
            this.transportNumber = transportNumber;
            this.departureTime = departureTime;
            this.amountOfSeats = amountOfSeats;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The bus Number {transportNumber} arrives at {departureTime} is going to {destination} and it has only {amountOfSeats} seats ");
        }

        public override string GetTheTransportType()
        {
            return "This is a diesel type";
        }
    }
}