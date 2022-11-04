namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vehicle do you want to create?");
            var typeVehicle = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(typeVehicle);

            vehicle.Drive();
            Console.WriteLine();
        }
    }
}
