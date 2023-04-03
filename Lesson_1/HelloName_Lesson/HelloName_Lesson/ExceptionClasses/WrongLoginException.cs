using System;
namespace HelloName_Lesson.ExceptionClasses
{
	public class WrongLoginException : Exception
	{
		public WrongLoginException(string message) : base(message) { }

		public WrongLoginException() { }

    }
}

