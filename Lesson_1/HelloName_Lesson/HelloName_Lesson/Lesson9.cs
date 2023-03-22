using System;
using System.Collections;

namespace HelloName_Lesson
{
	public class Lesson9
	{
		public static void Task1()
		{
			ArrayList list = new ArrayList();

			try
			{
				object? s = list[18];
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message, ex.Source, ex.Data);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}	
	}
}