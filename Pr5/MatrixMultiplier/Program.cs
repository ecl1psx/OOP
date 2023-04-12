namespace Program;

class Program3
{
    public static void Main()
    {
        var multiplier = new MatrixMultiplier(3);

        var result = multiplier.Multiply(
            new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6},
                { 7, 8, 9}
            }, 
                new int[,]
            {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            }, 
            (a, b) => a * b,
            (a, b) => a + b);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write($"{result[i,j].ToString()} ");
            }
            
            Console.Write("\n");
        }
    }
}