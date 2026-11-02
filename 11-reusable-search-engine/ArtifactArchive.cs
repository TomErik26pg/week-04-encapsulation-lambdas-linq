public class ArtifactArchive
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public List<Artifact> FindArtifacts(Func<Artifact, bool> condition)
    {
        //check condition and return a list of all true reference matches
        //returns new list, not private list
        return artifacts.Where(condition).ToList();
    }
}
