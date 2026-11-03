ArtifactService service = new ArtifactService();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Show all");
    Console.WriteLine("2 - Show high risk");
    Console.WriteLine("3 - Search origin");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        List<Artifact> artifacts = service.GetAll();

        foreach (Artifact artifact in artifacts)
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Origin} | {artifact.Risk}");
        }
    }
    else if (choice == "2")
    {
        List<Artifact> highRisk = service.GetHighRisk();
        
        foreach (Artifact artifact in highRisk)
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Risk}");
        }
    }
    else if (choice == "3")
    {
        Console.Write("Origin: ");
        string? origin = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(origin))
        {
            List<Artifact> matches = service.SearchByOrigin(origin);

            foreach (Artifact artifact in matches)
            {
                Console.WriteLine(artifact.Name);
            }
        }
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}