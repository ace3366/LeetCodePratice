public class AlgorithmExecutor
{
    string LargestTimeFromDigits(int[] arr)
    {
        int[] time = [10, 10, 10, 10];
        List<int> hoursInTenIndex = [];
        Array.Sort(arr);
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            // First digit of the Time
            if (arr[i] <= 2)
            {
                hoursInTenIndex.Add(i);
            }
        }
        // If there are no index of hours in ten digit, return empty string
        if (hoursInTenIndex.Count == 0) return "";
        // Find the others
        foreach (var hourIndex in hoursInTenIndex)
        {
            time = [10, 10, 10, 10];
            time[0] = arr[hourIndex];
            arr[hourIndex] = 10;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // Second digit of the Time
                if (time[0] == 2 && arr[i] <= 3 && arr[i] != 10 && time[1] == 10)
                {
                    time[1] = arr[i];
                    continue;
                }
                if (time[0] <= 1 && arr[i] != 10 && time[1] == 10)
                {
                    time[1] = arr[i];
                    continue;
                }
                // Third digit of the Time
                if (arr[i] <= 5 && time[2] == 10)
                {
                    time[2] = arr[i];
                    continue;
                }
                // Fourth digit of the Time
                if (arr[i] != 10 && time[3] == 10)
                {
                    time[3] = arr[i];
                    continue;
                }
            }
            arr[hourIndex] = time[0];
            // If the time has been found, break the loop
            if (!time.Contains(10)) break;
        }

        // If the time hasn't been found in the loop, return empty string
        if (time.Contains(10)) return "";
        return $"{time[0]}{time[1]}:{time[2]}{time[3]}";
    }

    //int[] arr = [2, 0, 6, 6];
    //Console.WriteLine(LargestTimeFromDigits(arr));
}