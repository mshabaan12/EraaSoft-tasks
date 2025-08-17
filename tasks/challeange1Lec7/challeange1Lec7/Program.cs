namespace challeange1Lec7
{
    class Car
    {
        double speed;
        double fuel;

        public Car(double speed, double fuel)
        {
            this.speed = speed;
            this.fuel = fuel;
        }
        public double Speed
        {
            get
            {

                return this.speed;
            }
            set
            {
                if (value > 200)
                {
                    Console.WriteLine("the speed is greater than 200 km/h");
                }
                else
                {
                    this.speed = value;
                }
            }
        }
        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("in valid request");
                }
                else
                {
                    this.fuel = value;
                }
            }
        }
        internal class Program
        {

            static void Main(string[] args)
            {
                Car car1 = new Car(180, 50);
                car1.Speed = 160;
                Console.WriteLine(car1.Speed);
                car1.Speed = 260;
                Console.WriteLine(car1.Speed);
            }
        }
    }
}

