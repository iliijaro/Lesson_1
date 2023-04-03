using System;
namespace HelloName_Lesson.PhoneAndCreditCard
{
    public class Abonent : Phone
    {
        public string contactName;

        public Abonent(string number, string contactName)
        {
            this.number = number;
            this.contactName = contactName;
        }

        public Abonent(string contactName)
        {
            this.contactName = contactName;
        }

        public Abonent() : this("Unknown") { }

        public void ReceiveCall(string contactName)
        {
            this.contactName = contactName;
            Console.WriteLine($"{contactName} is calling\n");
        }

        public void ReceiveCall(string contactName, string number)
        {
            this.contactName = contactName;
            this.number = number;
            Console.WriteLine($"{number} {contactName} is calling\n");
        }

        public static void SendMessage(params string[] messageNumbers)
        {
            if (messageNumbers != null)
            {
                for (int i = 0; i < messageNumbers.Length; i++)
                {
                    string eachnumber = messageNumbers[i];
                    Console.WriteLine("Message will be sent to: " + (eachnumber)+"\n");
                }
            }
        }
    }
}