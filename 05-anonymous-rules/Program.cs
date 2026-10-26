List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7, 24, 36 };

// TODO: Kall PrintMatching minst tre ganger med ulike lambdas.

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
