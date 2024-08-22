using System.Net.WebSockets;

int[][] KClosest(int[][] points, int k)
{
    Dictionary<int, double> distances = new Dictionary<int, double>();
    List<int[]> closest = new List<int[]>();
    for (int i = 0; i < points.Length; i++)
    {
        distances.Add(i, Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]));
    }

    var sortedList = distances.OrderBy(distance => distance.Value).ToArray();
    for (int i = 0; i <= k; i++)
    {
        closest.Add(points[sortedList[i].Key]);
    }
    return closest.ToArray();
}

KClosest([[3, 3], [5, -1], [-2, 4]], 2);