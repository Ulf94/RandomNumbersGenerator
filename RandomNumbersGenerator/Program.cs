var dictionary = new Dictionary<int, int>();

foreach (var number in GetNumbers(1, 100_000_000))
{
    if (dictionary.ContainsKey(number) is false)
        dictionary.Add(number, 1);
    else
    {
        dictionary[number]++;
    }
}

var maxValue = dictionary.Values.Max();

var topOccurrence = dictionary.Where(number => number.Value == maxValue);

foreach (var keyValuePair in topOccurrence)
{
    Console.WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");
}

IEnumerable<int> GetNumbers(int minValue, int maxValue)
{
    var random = new Random();

    for (var i = 0; i <= maxValue; i++)
    {
        yield return random.Next(minValue, maxValue);
    }
}
