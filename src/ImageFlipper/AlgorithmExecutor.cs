public class AlgorithmExecutor
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        var temp = 0;
        for (int i = 0; i < image.Length; i++)
        {
            // Check even odd
            if (image[i].Length % 2 != 0)
            {
                image[i][image[i].Length / 2] = image[i][image[i].Length / 2] == 1 ? 0 : 1;
            }
            for (int j = 0; j < image[i].Length / 2; j++)
            {
                temp = image[i][j];
                image[i][j] = image[i][image[i].Length - 1 - j] == 1 ? 0 : 1;
                image[i][image.Length - 1 - j] = temp == 1 ? 0 : 1;
            }
        }
        return image;

    }
}

//int[][] image = [
//[1, 1, 0],
//[1, 0, 1],
//[0, 0, 0]
//];
//Console.WriteLine(FlipAndInvertImage(image));