﻿int[,] matrix =
{
    {7, 1, 3, 3, 2, 1 },
    {1, 3, 9, 8, 5, 6 },
    {4, 6, 7, 9, 1, 0 }
};

int bestSum = int.MinValue;
for (int row = 0; row < matrix.GetLength(0)-1; row++)
{
    for (int col = 0; col < matrix.GetLength(1)-1; col++)
    {
        int sum = matrix[row, col] + matrix[row, col + 1]
            + matrix[row + 1, col] + matrix[row + 1, col + 1];
        if (sum > bestSum)
        {
            bestSum = sum;
        }
    }
}

Console.WriteLine("Maximal summa = {0}", bestSum);


Console.Write("\n\nTryck på en tangent för att stänga");
Console.ReadKey();
