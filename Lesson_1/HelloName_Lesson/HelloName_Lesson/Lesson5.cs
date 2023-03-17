using System;
using HelloName_Lesson.Classes;

namespace HelloName_Lesson
{
    public class Lesson5
    {
        public static void Task1_Phone()
        {
            Phone iphone = new Phone();
            iphone.model = "iPhone 11 Pro";
            iphone.number = "+375446632255";
            iphone.weight = 400;

            var xiaomi = new Phone("+375338856241", "Redmi Note 3");

            Phone googlePixel = new();

            Abonent eugene = new Abonent(iphone.number, "Eugene");

            var valera = new Abonent("Valera");

            Abonent people = new();

            iphone.GetInfo();
            xiaomi.GetInfo();
            googlePixel.GetInfo();

            iphone.GetNumber();

            eugene.ReceiveCall(eugene.contactName, eugene.number);
            valera.ReceiveCall(valera.contactName);
            people.ReceiveCall(people.contactName);

            Abonent.SendMessage("+375444411111", "+375291231231", "+375337772318");
        }

        public static void Task2_CreditCard()
        {
            CreditCard alfaBank = new(2233467984551111, 1000);

            CreditCard mtbBank = new CreditCard(9876212161163333, 1000);

            var priorbank = new CreditCard(3333212166668989, 1000);

            alfaBank.AddMoney(99);
            mtbBank.AddMoney(151);
            priorbank.ReceiveMoney(50);

            alfaBank.GetBalance();
            mtbBank.GetBalance();
            priorbank.GetBalance();
        }
    }
}