namespace FactoryPattern
{
    internal class Program
    {
        /*
         * Possible steps:
            Create an Interface named IVehicle that has a stubbed out public void Drive method
            Create 2 new public classes that will conform to IVehicle
            Example) Car, Motorcycle,  BigRig
            These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)
            Now we will make our static VehicleFactory class
            It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
            Call this functionality in the Main method
            */

        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.GetVehicle(4)
            Console.WriteLine("Let's see what kind of vehicle pops out!");
            vehicle.Drive();
            
            IVehicle vehicle2 = VehicleFactory.GetVehicle(2);
            Console.WriteLine("One more time, what do we get?!");
            vehicle2.Drive();
        }
    }
}