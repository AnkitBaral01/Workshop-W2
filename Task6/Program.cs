Console.WriteLine("TASK 6: Collections");

List<string> fruits = new List<string> { "Lemon", "Avacado", "Kiwi" };

Console.WriteLine($"First fruit: {fruits[0]}");
Console.WriteLine($"Second fruit: {fruits[1]}");
Console.WriteLine($"Third fruit: {fruits[2]}");

fruits.Add("Lemon");
Console.WriteLine($"After add - Fourth fruit: {fruits[3]}");

fruits.Remove("Avacado");
Console.WriteLine($"After remove - Count: {fruits.Count}");
Console.WriteLine($"After remove - First fruit: {fruits[0]}");
Console.WriteLine($"After remove - Second fruit: {fruits[1]}");

Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Lemon" },
    { 2, "Avacado" },
    { 3, "Kiwi" }
};

fruitDict.Add(0, "Special Fruit");

Console.WriteLine($"Fruit at key 1: {fruitDict[1]}");
Console.WriteLine($"Fruit at key 2: {fruitDict[2]}");
Console.WriteLine($"Fruit at key 3: {fruitDict[3]}");
Console.WriteLine($"Fruit at key 0: {fruitDict[0]}");