namespace JaggedArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int[][] jag = new int[][]
            {
                new int[] {1,3,7,5},
                new int[] {7,5,3,4},
                new int[] {2,3,9,5},
                new int[] {1,3,9,5},
            };

            for (int i = 0; i < jag[i].Length; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    Console.WriteLine(jag[i][j]);
                }
            }
        }
    }
}