List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7, 24, 36 };

// TODO: Kall PrintMatching minst tre ganger med ulike lambdas.

PrintMatching(readings, value => value % 2 == 0);
PrintMatching(readings, value => value > 40);
PrintMatching(readings, value => value >= 40 && value <= 80);

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
