string[] stringSets = { "Algoritma,3", "Algoritma,5", "Algoritma,2", "Algoritma,0" };
foreach (var item in stringSets)
{
    string[] splittedSets = item.Split(",");
    int removeCharAt = int.Parse(splittedSets[1]);
    Console.WriteLine($"{item.Remove(removeCharAt, 1)}");
}