string[] beers = {"Zagorka", "Ariana", "Shumensko", "Astika",
                "Kamenitza", "Bolyarka", "Amstel", "Heineken"};

Console.WriteLine("Osorterat: {0}", string.Join(", ", beers));

// Arrayen beers är av typ string, så det går bra att sortera
Array.Sort(beers);

Console.WriteLine("Sorterat: {0}", string.Join(", ", beers));



Console.Write("\n\nTryck på en tangent för att stänga");
Console.ReadKey();
