Console.Write("nge matrisernas storlek: ");
int size = int.Parse(Console.ReadLine());

int[,] A = new int[size, size]; // Matris 1
int[,] B = new int[size, size]; // Matris 2
int[,] C = new int[size, size]; // Resulterande matris

int row, col;

// Läs in första matrisen
Console.WriteLine("Ange elementen för matris A med storleken {0} x {0}", size);
for (row  = 0; row  < size; row ++)
{
    for (col = 0; col < size; col++)
    {
        Console.Write("Ange A[{0}, {1}]: ", row, col);
        A[row, col] = int.Parse(Console.ReadLine());
    }
}

// Läs in andra matrisen
Console.WriteLine("\n\nAnge elementen för matris B med storleken {0} x {0}", size);
for (row  = 0; row  < size; row ++)
{
    for (col = 0; col < size; col++)
    {
        Console.Write("Ange B[{0}, {1}]: ", row col);
        B[row, col] = int.Parse(Console.ReadLine());
    }
}

// Addera matriserna, element för element
for (row = 0; row < size; row++)
{
    for (col = 0; col < size; col++)
    {
        C[row, col] = A[row, col] + B[row, col];
    }
}

// Skriv ut resultatmatrisen C
Console.WriteLine("\n\nMatriswrna summerade element för element:");
for (row = 0; row < size; row++)
{
    for (col = 0; col < size; col++)
    {
        Console.Write("{0} ", C[row, col]);
    }
    Console.WriteLine();
}





Console.Write("\n\nTryck på en tangent för att stänga");
Console.ReadKey();
