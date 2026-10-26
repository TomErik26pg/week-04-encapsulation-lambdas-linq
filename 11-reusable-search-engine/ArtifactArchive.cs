public class ArtifactArchive
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public List<Artifact> FindArtifacts(Func<Artifact, bool> condition)
    {
        // TODO: Bruk condition til å filtrere og returner en ny liste.
        return new List<Artifact>();
    }
}
