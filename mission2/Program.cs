namespace mission2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());
        
        DiceSimulator simulator = new DiceSimulator();
        int[] rollResults = simulator.SimulateRolls(numberOfRolls);
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            double percentage = (rollResults[i] / (double)numberOfRolls) * 100;
            int stars = (int)Math.Round(percentage);
            Console.WriteLine($"{i}: {new string('*', stars)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}