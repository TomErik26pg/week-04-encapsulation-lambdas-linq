public class Archive
{
    private List<string> entries = new List<string>();

    public int Count => entries.Count;

    public void Add(string entry)
    {
        entries.Add(entry);
    }

    public List<string> GetEntries()
    {
        // DESIGNFEIL med vilje: denne lekker den interne listen.
        return entries;
    }
}
