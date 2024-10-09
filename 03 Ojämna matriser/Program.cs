int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
int[] sizes = new int[3];
int[] offsets = new int[3];

foreach (var number in numbers)
{
    int remainder = number % 3;
    sizes[remainder]++;
}

int[][] numbersByRemainder = new int[3][]
{
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
};

foreach (var number in numbers)
{
    int remainder = number % 3;
    int index = offsets[remainder];
    numbersByRemainder[remainder][index] = number;
    offsets[remainder]++;
}
for (int row = 0; row < 3; row++)
{
    Console.Write("numbersByRemainder[{0}]: ", row);
    for (int col = 0; col < numbersByRemainder[row].Length; col++)
    {
        Console.Write("{0} ", numbersByRemainder[row][col]);
    }
    Console.WriteLine();
}


Console.Write("\n\nTryck på en tangent för att stänga");
Console.ReadKey();
