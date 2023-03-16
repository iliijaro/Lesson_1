using System;
namespace HelloName_Lesson.Classes
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

        public void receiveCall(string contactName)
        {
            this.contactName = contactName;
            Console.WriteLine($"{contactName} is calling\n");
        }

        public void receiveCall(string contactName, string number)
        {
            this.contactName = contactName;
            this.number = number;
            Console.WriteLine($"{number} {contactName} is calling\n");
        }

        public static void sendMessage(params string[] messageNumbers)
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