
internal class Program
{
    private static void Main(string[] args)
    {
        Task3();
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
    public static void Task3()
    {
        Console.WriteLine("Enter the word from the topic 'Weather' to translate: ");
        string word = Console.ReadLine();
        string word1 = "погода";
        string word2 = "градусы";
        string word3 = "солнечно";
        string word4 = "ветренно";
        string word5 = "дождь";
        string word6 = "снег";
        string word7 = "торнадо";
        string word8 = "туман";
        string word9 = "гололёд";
        string word10 = "жара";
        string translate = "Translation: ";

        if (word == word1)
        {
            Console.WriteLine(translate + "Weather");

        }
        else if (word == word2)
        {
            Console.WriteLine(translate + "Degrees");
        }
        else if (word == word3)
        {
            Console.WriteLine(translate + "Sunny");
        }
        else if (word == word4)
        {
            Console.WriteLine(translate + "Windy");
        }
        else if (word == word5)
        {
            Console.WriteLine(translate + "Rain");
        }
        else if (word == word6)
        {
            Console.WriteLine(translate + "Snow");
        }
        else if (word == word7)
        {
            Console.WriteLine(translate + "Tornado");
        }
        else if (word == word8)
        {
            Console.WriteLine(translate + "Fog");
        }
        else if (word == word9)
        {
            Console.WriteLine(translate + "Ice");
        }
        else if (word == word10)
        {
            Console.WriteLine(translate + "Heat");
        }
        else
        {

            Console.WriteLine("This word is not found in the Vocabluary!");
        }


    }


}
