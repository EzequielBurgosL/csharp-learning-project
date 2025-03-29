namespace oopTutorial.Interfaces
{
    interface IVehicle
    {
        int Accelerate();

    }
    class Car : IVehicle
    {
        public int speed = 0;

        public int Accelerate()
        {
            this.speed = 100;
            return this.speed;
        }
    };

    class Motorcycle : IVehicle
    {
        public int speed = 0;

        public int Accelerate()
        {
            this.speed = 80;
            return this.speed;
        }
    }

    class Truck : IVehicle
    {
        public int speed = 0;

        public int Accelerate()
        {
            this.speed = 60;
            return this.speed;
        }
    }
}
