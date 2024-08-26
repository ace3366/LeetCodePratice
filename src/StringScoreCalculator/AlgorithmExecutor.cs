namespace AlgorithmPractice.StringScoreCalculator;

public class AlgorithmExecutor
{
    public int ScoreOfString(string s)
    {
        var convertedString = new List<int>();
        // Convert to ASCII
        foreach (var c in s)
        {
            convertedString.Add(c);
        }
        // Get Score of String
        var total = 0;
        for (int i = 0; i < convertedString.Count; i++)
        {
            total += i == convertedString.Count - 1 ? 0 :
                Math.Abs(convertedString[i + 1] - convertedString[i]);
        }
        return total;
    }

    //var inputString = "zaz";
    //Console.WriteLine(ScoreOfString(inputString));
}