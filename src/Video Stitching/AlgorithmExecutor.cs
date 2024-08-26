namespace AlgorithmPractice.VideoStitching;

public class AlgorithmExecutor
{
    public int VideoStitching(int[][] clips, int time)
    {
        var total = 0;
        // Create 3 list : startList, endList, middleList
        List<int[]> startList = new List<int[]>();
        List<int[]> endList = new List<int[]>();
        List<int[]> middleList = new List<int[]>();

        foreach (var clip in clips)
        {
            if (clip[0] == 0) startList.Add(clip);
            if (clip[0] < time && clip[1] >= time) endList.Add(clip);
            middleList.Add(clip);
        }

        // Return -1 if there is no clip that start with 0 or end with time
        if (startList.Count == 0 || endList.Count == 0) return -1;

        // Find the longest in startList and endList
        var start = findTheLongest(startList);
        var end = findTheLongest(endList);

        // If the longest start is enough for use, return 1
        total++;
        if (start[1] >= time) return total;

        // If the longest start and longest end is enough, return 2
        total++;
        if (start[1] >= end[0]) return total;


        // Continue to find the total base on middleList
        FindConsecuteClip(start);
        return total;

        // Find the consecute clip base on the previous clip
        void FindConsecuteClip(int[] nextStart)
        {
            var maxEnd = nextStart[1];
            int[] replacement = [0, 0];
            foreach (var clip in middleList)
            {
                if (clip[0] <= nextStart[1] && clip[1] > maxEnd)
                {
                    maxEnd = clip[1];
                    replacement = clip;
                }
            }
            // If can not find the consecute clip, return -1
            if (replacement[0] == 0 && replacement[1] == 0)
            {
                total = -1;
                return;
            };
            total++;
            // If the function has reached the end clip, return the total
            if (replacement[1] >= end[0]) return;

            FindConsecuteClip(replacement);
        }


        // Find the longest function
        int[] findTheLongest(List<int[]> list)
        {
            var longest = -1;
            int[] longestClip = [];
            foreach (var clip in list)
            {
                if (clip[1] - clip[0] > longest)
                {
                    longest = clip[1] - clip[0];
                    longestClip = clip;
                }
            }
            return longestClip;
        }

    }

    //int[][] a = [[3, 8], [0, 1], [1, 3]];
    //VideoStitching(a, 2);
}
