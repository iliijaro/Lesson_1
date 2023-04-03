using System;
namespace HelloName_Lesson.AutoParkClasses
{
    public class Trolleybus : Transport
    {
        public Trolleybus(string destination, int transportNumber, string departureTime, int amountOfSeats)
        {
            this.destination = destination;
            this.transportNumber = transportNumber;
            this.departureTime = departureTime;
            this.amountOfSeats = amountOfSeats;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The Trolleybus Number {transportNumber} arrives at {departureTime} is going to {destination} and it has only {amountOfSeats} seats ");
        }

        public override string GetTheTransportType()
        {
            return "Electric Type of transport";
        }
    }
}