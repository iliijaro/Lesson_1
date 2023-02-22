
internal class Program
{
    private static void Main(string[] args)
    {
        Task2();
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
    public static void Task2()
    {
        Console.WriteLine("Enter the number from 0 to 100: ");
        byte number = byte.Parse(Console.ReadLine());


        if ((number >= 0) && (number <= 14))
        {
            Console.WriteLine("The number is in the Range [0-14]");
        }
        else if ((number >= 15) && (number <= 35))

        {
            Console.WriteLine("The number is in the Range [15-35]");
        }
        else if ((number >= 36) && (number <= 49))

        {
            Console.WriteLine("The number is in the Range [36-49]");
        }
        else if ((number >= 50) && (number <= 100))

        {
            Console.WriteLine("The number is in the Range [50-100]");
        }
        else
        {
            Console.WriteLine("The number is not in the any Range");
        }




    }


}
