namespace HelloName_Lesson.Lesson10
{
    public class NewCar<T>
    {
        public T engineCar;
        public string model;

        public double speed;
        private double maxSpeed = 300;

        public double fuelLevel;
        private double tankVolume = 60;

        public int batteryChargeLevel;
        private int maxBatteryCharge = 100;

        public NewCar(string model, T engineCar, double fuelLevel)
        {
            this.engineCar = engineCar;
            this.model = model;
            this.fuelLevel = fuelLevel;
        }

        public NewCar(string model, T engineCar, int batteryChargeLevel)
        {
            this.engineCar = engineCar;
            this.model = model;
            this.batteryChargeLevel = batteryChargeLevel;
        }

        public void MoveCar(int addSpeed)
        {
            var maxSpeedUp = maxSpeed - speed;
            if ((speed < maxSpeed) && (maxSpeedUp >= addSpeed))
            {
                speed += addSpeed;
                Console.WriteLine($"The {model} speed is {speed} km/h");
            }
            else
            {
                Console.WriteLine($"You can not speed up more than limited speed {maxSpeed} km/h");
            }
        }

        public void AddFuel(int fuelValue)
        {
            var maxFillValue = tankVolume - fuelLevel;
            var maxChargeValue = maxBatteryCharge - batteryChargeLevel;

            if (((engineCar is DieselEngine) && (fuelLevel < tankVolume) && (fuelValue <= maxFillValue)) || ((engineCar is GasEngine) && (fuelLevel < tankVolume) && (fuelValue <= maxFillValue)))
            {
                fuelLevel += fuelValue;
                Console.WriteLine($"The car is filled up to: {fuelLevel} liters");
            }
            else if (((engineCar is DieselEngine) && (fuelLevel < tankVolume) && (fuelValue > maxFillValue)) || ((engineCar is GasEngine) && (fuelLevel < tankVolume) && (fuelValue > maxFillValue)))
            {
                Console.WriteLine($"You are trying to fill up {fuelValue}L, but you can fill up only: {maxFillValue}L\nCurrent fuel level is {fuelLevel}L | Max tank volume is {tankVolume}L");
            }
            else if ((engineCar is ElectroEngine) && (batteryChargeLevel < maxBatteryCharge) && (fuelValue <= maxChargeValue))
            {
                batteryChargeLevel += fuelValue;
                Console.WriteLine($"The car is charge to: {batteryChargeLevel}%");
            }
            else if ((engineCar is ElectroEngine) && (batteryChargeLevel < maxBatteryCharge) && (fuelValue > maxChargeValue))
            {
                Console.WriteLine($"You are trying to charge {fuelValue}%, but you can charge only: {maxChargeValue}%\nCurrent battery charge is {batteryChargeLevel}% | Max battery charge is {maxBatteryCharge}%");
            }
        }
    }
}