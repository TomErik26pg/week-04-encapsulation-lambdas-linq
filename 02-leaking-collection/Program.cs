Archive archive = new Archive();
archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");

List<string> outsideList = archive.GetEntriesLeaking();

// TODO del A: Clear outsideList og observer archive.Count.
Console.WriteLine("Oppgave del A:");
Console.WriteLine($"Before clear; {archive.Count}");
outsideList.Clear();
Console.WriteLine($"After clear; {archive.Count}");

//resetting task for simplicity of checking both
Console.WriteLine("------------------------");
archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");
outsideList = archive.GetEntries();
Console.WriteLine($"Refreshed archive count: {archive.Count}");
Console.WriteLine("------------------------");

// TODO del B: Fiks GetEntries(), og prøv eksperimentet på nytt.
Console.WriteLine("Oppgave del B:");
Console.WriteLine($"Before clear; {archive.Count}");
outsideList.Clear();
Console.WriteLine($"After clear; {archive.Count}");