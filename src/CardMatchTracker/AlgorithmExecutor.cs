public class AlgorithmExecutor
{
    public bool HasGroupsSizeX(int[] deck)
    {
        // Divide all the cards into partitions
        var partitions = new Dictionary<int, int>();
        foreach (var card in deck)
        {
            if (!partitions.ContainsKey(card))
            {
                partitions.Add(card, 1);
                continue;
            }
            var currentTotal = partitions[card];
            partitions[card] = currentTotal + 1;
        }
        // Find all the greatest common divisor
        var gcd = FindGreatestCommonDivisor([.. partitions.Values]);

        return gcd == 1 ? false : true;
    }

    private int GreatestCommonDivisor(int a, int b)
    {
        if (a == 0) return b;
        return a > b ? GreatestCommonDivisor(a % b, b) : GreatestCommonDivisor(b % a, a);
    }
    private int FindGreatestCommonDivisor(int[] arr)
    {
        return arr.Aggregate(GreatestCommonDivisor);
    }

    //int[] deck = [1, 2, 3, 4, 4, 3, 2, 1];

    //Console.WriteLine($"Result : {HasGroupsSizeX(deck)}");
}