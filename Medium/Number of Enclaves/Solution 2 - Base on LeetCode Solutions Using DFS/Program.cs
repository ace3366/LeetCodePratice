int NumEnclaves(int[][] grid)
{
    /* 
     * Find all the land cells that lay on the border
     * replace that land cell and all the adjacent cells with value = 0 
     * using DFS
    */

    // Height
    var n = grid.Length;
    // Length
    var m = grid[0].Length;

    // First row
    for (int r = 0; r < m; r++)
    {
        if (grid[0][r] == 1)
        {
            DFS(r, 0, grid);
        }
    }

    // Last row
    for (int r = 0; r < m; r++)
    {
        if (grid[n -1][r] == 1)
        {
            DFS(r, n - 1, grid);
        }
    }

    // First column
    for (int h = 0; h < n; h++)
    {
        if (grid[h][0] == 1)
        {
            DFS(0, h, grid);
        }
    }

    // Last column
    for (int h = 0; h < n; h++)
    {
        if (grid[h][m-1] == 1)
        {
            DFS(m - 1, h, grid);
        }
    }



    // Find the rest land cell
    var res = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            res += grid[i][j];
        }

    }
    return res;
    // DFS function
    void DFS(int w, int h, int[][] grid)
    {
        if (w < 0 || w >= m || h < 0 || h >= n) return;
        if (grid[h][w] == 0) return;
        grid[h][w] = 0;

        DFS(w + 1, h, grid);
        DFS(w - 1, h, grid);
        DFS(w, h + 1, grid);
        DFS(w, h - 1, grid);
    }
}

int[][] a = [
    [0, 0, 0, 1, 1, 1, 0, 1, 0, 0], 
    [1, 1, 0, 0, 0, 1, 0, 1, 1, 1], 
    [0, 0, 0, 1, 1, 1, 0, 1, 0, 0], 
    [0, 1, 1, 0, 0, 0, 1, 0, 1, 0], 
    [0, 1, 1, 1, 1, 1, 0, 0, 1, 0], 
    [0, 0, 1, 0, 1, 1, 1, 1, 0, 1], 
    [0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 
    [0, 0, 1, 0, 0, 1, 0, 1, 0, 1], 
    [1, 0, 1, 0, 1, 1, 0, 0, 0, 0], 
    [0, 0, 0, 0, 1, 1, 0, 0, 0, 1]];
NumEnclaves(a);