// See https://aka.ms/new-console-template for more information
using PearlNecklace;

var pearlBag = new List<Pearl>();
for (int i = 0; i < 35; i++)
{
    pearlBag.Add(new Pearl { });
}


foreach (var item in pearlBag)
{
    Console.WriteLine($"{item}\n");
}


var freshPearls = new List<Pearl>();
List<Pearl> freshwaterPearls = pearlBag.FindAll(x => x.Type == PearlType.Freshwater);


var freshCount = 0;
foreach (var item in freshwaterPearls)
{
    freshCount++;
}
Console.WriteLine($"Amount of Freshwater Pearls: {freshCount}");

var saltPearls = new List<Pearl>();
List<Pearl> saltwaterPearls = pearlBag.FindAll(x => x.Type == PearlType.Saltwater);

var saltCount = 0;
foreach (var item in saltwaterPearls)
{
    saltCount++;
}
Console.WriteLine($"Amount of Saltwater Pearls: {saltCount}");

var size = 10;
var color = PearlColor.White;
var shape = PearlShape.Tear;

Console.WriteLine($"\nSearching for pearl with properties:\nSize: {size}\nColor: {color}\nShape: {shape}");
var askedPearl = pearlBag.Where(x => x.Size == size)
                         .Where(x => x.Color == color)
                         .Where(x => x.Shape == shape);

Console.WriteLine($"Found pearls: {askedPearl.Count()}");