// See https://aka.ms/new-console-template for more information
using Pärlhalsband;

var pearlBag = new List<Pearl>();
for (int i = 0; i < 30; i++)
{
    pearlBag.Add(new Pearl { });
}


foreach (var item in pearlBag)
{
    Console.WriteLine($"{item}\n");
}