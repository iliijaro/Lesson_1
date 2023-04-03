using System;
namespace HelloName_Lesson.ExceptionClasses
{
    public class NewCredits
    {
        public string userName;
        public string password;
        public string confirmPassword;

        public NewCredits(string userName, string password, string confirmPassword)
        {
            this.userName = userName;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        private NewCredits(string userName, string password) : this(userName, password, "admin") { }

        private NewCredits(string userName) : this(userName, "admin", "admin") { }

        private NewCredits() : this("admin", "12345", "12345") { }

        public static bool CheckCredits(NewCredits newCredits)
        {
            try
            {
                var name = newCredits.userName;
                var pass = newCredits.password;
                var confirm = newCredits.confirmPassword;

                if ((name.Length >= 20) || (name.Contains(' ')))
                {
                    throw new WrongLoginException("Incorrect Login! \nLogin should be less than 20 symbols and do not contain spaces!");
                }
                else if ((pass.Length >= 20) || (!pass.Any(char.IsDigit)) || (pass.Contains(' ')))
                {
                    throw new WrongPasswordException("Incorrect Password! \nPassword should contain at least 1 number and be less than 20 symbols and do not contain spaces");
                }
                else if (pass != confirm)
                {
                    throw new WrongPasswordException("Password value is not equal to Confirm Password value! \nCheck the values!");
                }
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            Console.WriteLine("Your Credits are verified!");
            return true;
        }
    }
}