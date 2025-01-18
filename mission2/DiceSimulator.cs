namespace mission2;

public class DiceSimulator
{
    private Random random = new Random();
    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13];

        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            int sum = roll1 + roll2;

            results[sum]++;
        }

        return results;
    }
}