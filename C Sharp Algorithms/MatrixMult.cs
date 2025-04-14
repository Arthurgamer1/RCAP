using System;

class MatrixMultiplication
{
    public static double[,] Multiply(double[,] A, double[,] B)
    {
        int aRows = A.GetLength(0);
        int aCols = A.GetLength(1);
        int bRows = B.GetLength(0);
        int bCols = B.GetLength(1);

        if (aCols != bRows)
            throw new InvalidOperationException("Matrix dimensions are not compatible for multiplication.");

        double[,] result = new double[aRows, bCols];

        for (int i = 0; i < aRows; i++)
        {
            for (int j = 0; j < bCols; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < aCols; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        return result;
    }

    public static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        double[,] A = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        double[,] B = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        double[,] result = Multiply(A, B);

        Console.WriteLine("Result:");
        PrintMatrix(result);
    }
}
