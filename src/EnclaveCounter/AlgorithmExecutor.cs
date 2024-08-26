public class AlgorithmExecutor
{
    public int NumEnclaves(int[][] grid)
    {
        // Find adjacent of the land cell
        int[][] AddToAdjacent(int m, int n)
        {
            List<int[]> adjacent = new List<int[]>();
            adjacent.Add([m, n]);
            // UP 
            if (m > 0 && grid[m - 1][n] == 1) adjacent.Add([m - 1, n]);
            // DOWN 
            if (m < grid.Length && grid[m + 1][n] == 1) adjacent.Add([m + 1, n]);
            // LEFT
            if (n > 0 && grid[m][n - 1] == 1) adjacent.Add([m, n - 1]);
            // RIGHT
            if (n < grid[n].Length && grid[m][n + 1] == 1) adjacent.Add([m, n + 1]);
            return adjacent.ToArray();
        }

        bool IsAdjacent(int[] a, int[] b)
        {
            // Up & Down
            if (a[0] == b[0] && (b[1] - a[1] == 1 || a[1] - b[1] == 1)) return true;
            // Left and Right
            if (a[1] == b[1] && (b[0] - a[0] == 1 || a[0] - b[0] == 1)) return true;
            return false;
        }

        /* 
         * Find all the land cells
         * If the land cell is lay at the border, add into borderList
         * Otherwise, add into landCellList
        */
        List<int[]> borderList = new List<int[]>();
        List<int[]> landCellList = new List<int[]>();
        for (int n = 0; n < grid.Length; n++)
        {
            for (int m = 0; m < grid[n].Length; m++)
            {
                if (grid[n][n] == 1)
                {
                    if (m == grid[n].Length - 1
                        || m == 0
                        || n == grid.Length - 1
                        || n == 0)
                    {
                        borderList.Add([m, n]);
                        continue;
                    }
                    landCellList.Add([m, n]);
                }
            }
        }
        // Find the other adjacent base on the adjacents just found
        void NumberOfIsolateLandCell(List<int[]> borderList)
        {
            List<int[]> tempBorderList = new List<int[]>();
            for (int i = 0; i < borderList.Count; i++)
            {
                for (int j = 0; j < landCellList.Count; j++)
                {
                    if (IsAdjacent(borderList[i], landCellList[j]))
                    {
                        tempBorderList.Add(landCellList[j]);
                        landCellList.RemoveAt(j);
                        j--;
                    }
                }
            }
            if (tempBorderList.Count == 0) return;
            NumberOfIsolateLandCell(tempBorderList);
        }
        NumberOfIsolateLandCell(borderList);
        var a = landCellList.Count();
        return a;

    }
    //int[][] a = [[0, 0, 0, 0], [1, 0, 1, 0], [0, 1, 1, 0], [0, 0, 0, 0]];
    //NumEnclaves(a);
}