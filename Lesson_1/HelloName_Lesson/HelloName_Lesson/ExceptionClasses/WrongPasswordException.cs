using System;
namespace HelloName_Lesson.ExceptionClasses
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message) { }

        public WrongPasswordException() { }
    }
}

