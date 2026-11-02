List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Lag tre separate Where-queries.
//get risk >= 60
var artifactRisk = artifacts.Where(artifact => artifact.Risk >= 60);

//get all from Moon
var artifactFromMoon = artifacts.Where(artifact => artifact.Origin == "Moon");

//all names containing 'e' case sensitive
var artifactsContainingLetterE = artifacts.Where(artifact => artifact.Name.Contains('e'));

//print alle resultater
for (int i = 0; i <4; i++)
{
    switch (i)
    {
        case 0:
            foreach (Artifact artifact in artifactRisk)
            {
                Console.WriteLine($"Risk >= 60: {artifact.Name} ({artifact.Risk})");
            }
            break;

        case 1:
            foreach (Artifact artifact in artifactFromMoon)
            {
                Console.WriteLine($"From Moon: {artifact.Name} ({artifact.Origin})");
            }
            break;
        
        case 2:
            foreach (Artifact artifact in artifactsContainingLetterE)
            {
                Console.WriteLine($"Contains E: {artifact.Name}");

            }
            break;
    }
}