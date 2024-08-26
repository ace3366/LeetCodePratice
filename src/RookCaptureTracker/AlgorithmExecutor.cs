public class AlgorithmExecutor
{
    public int NumRookCaptures(char[][] board)
    {
        int possibleMove = 0;
        Tuple<int, int> rook = new Tuple<int, int>(0, 0);
        // Get rook position
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (board[i][j] == 'R') rook = new Tuple<int, int>(i, j);
            }
        }
        // Move every possible direction to find possible atkMove

        // UP
        for (int i = rook.Item1 - 1; i >= 0; i--)
        {
            if (board[i][rook.Item2] == 'B')
            {
                break;
            }
            if (board[i][rook.Item2] == 'p')
            {
                possibleMove++;
                break;
            }
        }
        // DOWN
        for (int i = rook.Item1 + 1; i < 8; i++)
        {
            if (board[i][rook.Item2] == 'B')
            {
                break;
            }
            if (board[i][rook.Item2] == 'p')
            {
                possibleMove++;
                break;
            }
        }
        // RIGHT
        for (int j = rook.Item2 + 1; j < 8; j++)
        {
            if (board[rook.Item1][j] == 'B')
            {
                break;
            }
            if (board[rook.Item1][j] == 'p')
            {
                possibleMove++;
                break;
            }
        }
        // LEFT
        for (int j = rook.Item2 - 1; j >= 0; j--)
        {
            if (board[rook.Item1][j] == 'B')
            {
                break;
            }
            if (board[rook.Item1][j] == 'p')
            {
                possibleMove++;
                break;
            }
        }
        return possibleMove;
    }
    //char[][] board =
    //[
    //['.', '.', '.', '.', '.', '.', '.', '.'],
    //    ['.', '.', 'B', 'B', 'B', 'B', 'B', '.'],
    //    ['.', 'p', 'B', 'p', 'p', 'p', 'B', 'p'],
    //    ['.', 'p', 'B', 'p', 'R', 'p', 'B', 'p'],
    //    ['.', 'p', 'B', 'p', 'p', 'p', 'B', 'p'],
    //    ['.', '.', 'B', 'B', 'B', 'B', 'B', '.'],
    //    ['.', '.', '.', 'p', 'p', 'p', '.', '.'],
    //    ['.', '.', '.', '.', '.', '.', '.', '.']
    //]


    //;
    //Console.WriteLine(NumRookCaptures(board));
}