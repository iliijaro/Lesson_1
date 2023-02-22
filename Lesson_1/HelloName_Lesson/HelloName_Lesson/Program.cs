
internal class Program
{
    private static void Main(string[] args)
    {
        Task1();
    }
    public static void Lesson1()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
    }
    public static void Task1()
    {
        float operand1 = 20;
        float operand2 = 10;
        Console.WriteLine("Enter the arithmetic sign: ");
        string sign = Console.ReadLine();

        float result1;


        switch (sign)
        {
            case "*":
                {
                    result1 = operand1 * operand2;
                    string result = result1.ToString();


                    Console.WriteLine("Result: " + result);
                    break;
                }

            case "/":
                {
                    {
                        // Found the solution on the StackOverflow
                        // May I use it?

                        /* if (operand2 == 0)
                            throw new DivideByZeroException();*/

                    }
                    result1 = operand1 / operand2;
                    string result = result1.ToString();


                    Console.WriteLine("Result: " + result);
                    break;
                }

            case "+":
                {
                    result1 = operand1 + operand2;
                    string result = result1.ToString();


                    Console.WriteLine("Result: " + result);
                    break;
                }

            case "-":
                {
                    result1 = operand1 - operand2;
                    string result = result1.ToString();


                    Console.WriteLine("Result: " + result);
                    break;
                }

            default:
                Console.WriteLine("Wrong arithmetic sign, please choose from: '+' '-' '/' and '*'");
                break;
        }
    }


}
