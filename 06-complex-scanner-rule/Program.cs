List<int> readings = new List<int> { 20, 39, 40, 45, 50, 60, 61, 90 };

// TODO: Send en multi-line lambda til PrintMatching.
PrintMatching(readings, value =>
{
    int distanceFromCenter = Math.Abs(value - 50);
    bool isWithinRange = distanceFromCenter <= 10;

    return isWithinRange;
});

static void PrintMatching(List<int> values, Func<int, bool> condition)
{
    foreach (int value in values)
    {
        if (condition(value))
        {
            Console.WriteLine(value);
        }
    }
}
