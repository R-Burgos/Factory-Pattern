namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                                      *-------------------*");
            Console.WriteLine("                                      |  Ding Ding Ding!  |");
            Console.WriteLine("                                      *-------------------*\n");
            Console.WriteLine("                ***Today is your lucky day! You have won a new vehicle!***");
            Thread.Sleep(1000);
            Console.WriteLine("Please enter the amount of tires you would like this vehicle to possess and it will be yours!");
            Console.WriteLine("");
            Console.WriteLine("Also, just between us pals... it's been a rough go lately. PLEASE don't try an funny buisness.");
            Console.WriteLine("The last jerk I tried to give away a free vehicle to entered -1... Don't be THAT person...\n");

            var tires = UserInput.CheckingUserInput();
            var userVehicle = VehicleFactory.GetVehicle(tires);
            userVehicle.Drive();

            Console.ReadLine();
        }
    }
}
