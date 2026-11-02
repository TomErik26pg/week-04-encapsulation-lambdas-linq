List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};

var sortedArtifacts = artifacts
    .Where(artifact => artifact.Risk >= 30) //reference
    .OrderBy(artifact => artifact.Name) //reference
    .Select(artifact => $"Name [{artifact.Name}] | Risk ({artifact.Risk})"); //transforms to string

foreach (string artifact in sortedArtifacts)
{
    Console.WriteLine(artifact);
}

Console.WriteLine(" "); //spacing
var artifactsByRisk = artifacts.OrderBy(artifact => artifact.Risk);

foreach (Artifact artifact in artifactsByRisk)
{
    Console.WriteLine($"Name [{artifact.Name}] | Risk ({artifact.Risk})");
}