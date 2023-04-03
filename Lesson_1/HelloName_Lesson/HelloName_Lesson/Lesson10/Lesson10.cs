namespace HelloName_Lesson.Lesson10
{
    public class Lesson10
    {
        public static void Task1()
        {
            MyList<string> newArray = new MyList<string>();
            newArray.Add("Hello");
            newArray.Add("I");
            newArray.Add("am");
            newArray.Add("Array");

            newArray.Delete("I");
            newArray.Delete("Hello");

            Console.WriteLine(newArray.GetElement(1) + "\n");

            Console.WriteLine(newArray.Count() + "\n");

            for (int i = 0; i < newArray.Count(); i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }

        public static void Task2()
        {
            var dieselEngine = new DieselEngine();
            var gasEngine = new GasEngine();
            var electroEngine = new ElectroEngine();

            NewCar<Engine> car_diesel = new("Volkswagen Passat", dieselEngine, 10);
            car_diesel.MoveCar(30);
            car_diesel.MoveCar(22);
            car_diesel.AddFuel(20);
            car_diesel.AddFuel(31);

            Console.WriteLine();

            NewCar<Engine> car_gas = new("Porshe 911", gasEngine, 20);
            car_gas.MoveCar(50);
            car_gas.MoveCar(100);
            car_gas.MoveCar(151);
            car_gas.AddFuel(30);
            car_gas.AddFuel(9);
            car_gas.AddFuel(10);

            Console.WriteLine();

            NewCar<Engine> car_electro = new("Chevrolet Volt", electroEngine, 50);
            car_electro.MoveCar(11);
            car_electro.MoveCar(40);
            car_electro.AddFuel(30);
            car_electro.AddFuel(30);
        }

        public static void Task3()
        {
            Point<int> point1 = new Point<int>(-1, 14);
            Point<int> point2 = new Point<int>(11, -6);
            point1.GetInfo();

            point1.GetTheDistance(point1, point2);
        }
    }
}