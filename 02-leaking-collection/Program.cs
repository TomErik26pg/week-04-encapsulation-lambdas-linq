Archive archive = new Archive();
archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");

List<string> outsideList = archive.GetEntries();

// TODO del A: Clear outsideList og observer archive.Count.
// TODO del B: Fiks GetEntries(), og prøv eksperimentet på nytt.

Console.WriteLine($"Archive count: {archive.Count}");
