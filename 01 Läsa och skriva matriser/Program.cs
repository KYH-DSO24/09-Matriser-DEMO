Console.Write("Ange antal rader: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Ange antal kolumner: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int row = 0; row < rows; row++)
{
    for (int column = 0; column < columns; column++)
    {
        Console.Write("matrix[{0}, {1}] = ", row, column);
        matrix[row, column] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0} ", matrix[i,j]);
    }
    Console.WriteLine();
}




Console.Write("\n\nTryck på en tangent för att stänga");
Console.ReadKey();
