ArtifactArchive archive = new ArtifactArchive();
archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));

var highRiskArtifacts = archive.FindArtifacts(artifact => artifact.Risk > 60);
var moonArtifacts = archive.FindArtifacts(artifact => artifact.Origin == "Moon");
var artifactsContainingS = archive.FindArtifacts(artifact => artifact.Name.ToLower().Contains("s"));

foreach (Artifact artifact in highRiskArtifacts)
{
    Console.WriteLine($"High Risk Artifact: {artifact.Name} ({artifact.Risk})");
}
Console.WriteLine(" "); //spacing
        
foreach (Artifact artifact in moonArtifacts)
{
    Console.WriteLine($"Artifacts with origin Moon: {artifact.Name}");
}
Console.WriteLine(" "); //spacing
        
foreach (Artifact artifact in artifactsContainingS)
{
    Console.WriteLine($"Artifact name containing 'S': {artifact.Name}");
}