List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Select til tre ulike projeksjoner.
//artifact names
var artifactNames = artifacts.Select(artifact => artifact.Name);

//risk digits
var artifactRisk = artifacts.Select(artifact => artifact.Risk);

//formatted string
var artifactString = artifacts.Select(artifact => $"{artifact.Name} ({artifact.Origin})");

//print names
foreach (var name in artifactNames)
{
    Console.WriteLine(name);
}

//print risk
foreach (var risk in artifactRisk)
{
    Console.WriteLine(risk);
}

//utskrift av beskrivelser
foreach (var description in artifactString)
{
    Console.WriteLine(description);
}