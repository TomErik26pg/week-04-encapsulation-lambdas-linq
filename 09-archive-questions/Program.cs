List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Any og Count til å svare på spørsmålene.
//- Finnes minst ett artifact med `Risk > 90`? Bruk `Any`.
var above90Risk = artifacts.Any(artifact => artifact.Risk > 90);
if (above90Risk)
{
    Console.WriteLine("Yes, there exists an artifact with risk > 90.");
}
else
{
    Console.WriteLine("No, there exists no artifacts with risk > 90.");
}

//- Hvor mange kommer fra `Mars`? Bruk `Count` med predicate.
var fromMarsCount = artifacts.Count(artifact => artifact.Origin == "Mars");
Console.WriteLine($"There are {fromMarsCount} artifacts with origin 'Mars'");

//- Hvor mange artifacts finnes totalt? Bruk `Count()` eller collectionens `Count` og diskuter forskjellen.
var numTotalArtifacts = artifacts.Count();
Console.WriteLine($"There are {numTotalArtifacts} artifacts in the collection.");
//Count() er en metode knyttet til LINQ, som lar oss filtrere søket, hvorav
//Count kun gir oss verdien på listen der egenskapen ettersøkes.


//- Finnes minst ett artifact fra `Venus`?
var artifactsFromVenus = artifacts.Any(artifact => artifact.Origin == "Venus");
if (artifactsFromVenus)
{
    Console.WriteLine("Yes, there exists at least 1 artifact from 'Venus'");
}
else
{
    Console.WriteLine("No, there are no artifacts from 'Venus'");
}
