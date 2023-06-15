// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
IEnumerable<Eruption> firstChileEruption  = eruptions.Where(e => e.Location == "Chile").Take(1);
PrintEach(firstChileEruption, "first Chile eruption");

IEnumerable<Eruption> firstHawaiiEruption = eruptions.Where(e => e.Location == "Hawaiian Is").Take(1);
Console.WriteLine("First Hawaiian eruption:");
if (firstHawaiiEruption.Any())
{
    Console.WriteLine(firstHawaiiEruption.First().ToString());
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}

IEnumerable<Eruption> firstNEWZEAEruption = eruptions.Where(e => e.Location == "New Zealand" && e.Year > 1900);
PrintEach(firstNEWZEAEruption, "first NZ eruption");

IEnumerable<Eruption> higherthan2thouwow = eruptions.Where(e => e.ElevationInMeters > 2000 ).ToList();
PrintEach(higherthan2thouwow, "Higher than 2000");

IEnumerable<Eruption> takeTheL = eruptions.Where(e => e.Volcano.StartsWith("L"));
int numOfL = takeTheL.Count();
PrintEach(takeTheL, "Eruptions that start with L !");
Console.WriteLine($"{numOfL} eruptions Found ");

int bigNumYo = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Highest elevation is {bigNumYo}");

Eruption biggestBoy = eruptions.First(e => e.ElevationInMeters == bigNumYo);
string theBiggestBoy = biggestBoy.Volcano;
Console.WriteLine($"The volcano with the highest elevation is {theBiggestBoy}");

IEnumerable<string> NameSort = eruptions.Select(e => e.Volcano).OrderBy(volcano => volcano).ToList();


Console.WriteLine( "Sorted names?");
foreach (string Volcano in NameSort)
{
    Console.WriteLine(Volcano);
}

int summ = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine($"total elevation is {summ}!");

bool diditeruptlol = eruptions.Any(e => e.Year == 2000);
Console.WriteLine($"Did any erupt in 2000 lol? - {(diditeruptlol ? "Yes" : "No")}");


IEnumerable<Eruption> findEmStrat = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
PrintEach(findEmStrat, "3 stratovolcanos yo");


IEnumerable<Eruption> berfore1kAlpha = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
PrintEach(berfore1kAlpha, " Sorted list of eruptions before 1000  Alphabetically sorted by name");


IEnumerable<string> volcano1kPro = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();



Console.WriteLine("Names of volcanos before 1000 alphabetically");
foreach (string Volcano in volcano1kPro)
{
    Console.WriteLine(Volcano);
}


// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}



