int[,] num =
{
    {22, 50, 11, 2, 49 },
    {92,63,12,64,37 },
    {75,23,64,12,99 },
    {21, 25, 71, 69, 39 },
    {19, 39, 58, 28, 83 }
};

int numRows = num.GetLength(0);
int numCols = num.GetLength(1);
int total = 0;

Console.Write("Elementen på huvuddiagonalen är: ");
//for (int row = 0; row < numRows; row++)
//{
//    for (int col = 0; col < numCols; col++)
//    {
//        if (row == col)
//        {
//            Console.Write(num[row, col] + " ");
//            total += num[row, col];
//        }
//    }
//}

// Enklare lösning:
for (int i = 0; i < numRows; i++)
{
    Console.Write(num[i, i] + " ");
    total += num[i, i];
}

Console.WriteLine($"Summan är {total}");


Console.Write("\n\nTryck på en tangent för att stänga");
Console.ReadKey();
