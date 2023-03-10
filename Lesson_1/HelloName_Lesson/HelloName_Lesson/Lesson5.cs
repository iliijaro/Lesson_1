using System;
using HelloName_Lesson.Classes;

namespace HelloName_Lesson
{
	public class Lesson5
	{
		public static void Main()
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

			eugene.receiveCall(eugene.contactName, eugene.number);
			valera.receiveCall(valera.contactName);
			people.receiveCall(people.contactName);

			Abonent.sendMessage("+375444411111","+375291231231","+375337772318");
		}	
	}
}