List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Cold Lens", "Europa", 28)
};

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
        foreach (Artifact artifact in artifacts)
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Origin} | {artifact.Risk}");
        }
    }
    else if (choice == "2")
    {
        List<Artifact> highRisk = artifacts.Where(a => a.Risk >= 60).ToList();
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
            List<Artifact> matches = artifacts
                .Where(a => a.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase))
                .ToList();

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

// TODO: Refaktorer den fungerende monolitten til tydelige ansvar/layers.

public class Artifact
{
    public string Name { get; set; }
    public string Origin { get; set; }
    public int Risk { get; set; }

    public Artifact(string name, string origin, int risk)
    {
        Name = name;
        Origin = origin;
        Risk = risk;
    }
}
