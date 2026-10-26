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
