using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


bool HasGroupsSizeX(int[] deck)
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
    var gcd = findGcd(partitions.Values.ToArray());

    return gcd == 1 ? false : true;
}

int gcd(int a, int b)
{
    if (a == 0) return b;
    return a > b ? gcd(a % b, b) : gcd(b % a, a);
}
int findGcd(int[] arr)
{
    return arr.Aggregate(gcd);
}

int[] deck = [1, 2, 3, 4, 4, 3, 2, 1];

Console.WriteLine($"Result : {HasGroupsSizeX(deck)}");
