using System;
using HelloName_Lesson.AutoParkClasses;
namespace HelloName_Lesson
{
    public class Lesson7
    {
        public static void TaskAutoPark()
        {
            Bus newBus = new("Malinovka", 53, "12:00", 25);
            newBus.GetInfo();
            Console.WriteLine(newBus.GetTheTransportType());
            Console.WriteLine();

            Trolleybus newTrolley = new Trolleybus("Avtozavod", 33, "14:00", 38);
            newTrolley.GetInfo();
            Console.WriteLine(newTrolley.GetTheTransportType());
            Console.WriteLine();

            Tramcar newTram = new Tramcar("Vesnyanka", 2, "6:00", 11);
            newTram.GetInfo();
            Console.WriteLine(newTram.GetTheTransportType());
            Console.WriteLine();

            Transport[] transports = { newBus, newTrolley, newTram };

            Array.Sort(transports);

            foreach (var unit in transports)
            {
                Console.WriteLine(string.Format("{0}, {1}, {2}, {3}",$" Amount of seats: {unit.amountOfSeats}", $"Number: {unit.transportNumber}", $"Departure time: {unit.departureTime}",  unit.destination));
            }

            Console.WriteLine();
            Console.WriteLine("Enter the Destination of transport: ");
            string? userData = Console.ReadLine();

            foreach (var unit in transports)
            {
                if (unit.destination == userData)
                {
                    unit.GetInfo();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Please enter the departure time");

            string? userData1 = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(userData1);

            Console.WriteLine();
            Console.WriteLine("Transport list:");

            foreach (var unit in transports)
            {
                if (DateTime.Parse(unit.departureTime) > dateTime)
                {
                    Console.WriteLine(string.Format("{0}, {1}, {2}", unit.departureTime, unit.transportNumber, unit.destination));
                }
            }
        }
    }
}