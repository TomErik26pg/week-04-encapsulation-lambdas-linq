public class Archive
{
    private List<string> entries = new List<string>();

    public int Count => entries.Count;

    public void Add(string entry)
    {
        entries.Add(entry);
    }

    //metode som bevarer originale feilen for å simplifisere teste av del A og B til en kjøring
    public List<String> GetEntriesLeaking() //returnerer referanse til den interne listen
    {
        return entries;
    }

    //korrigert GetEntries metode som ikke returnerer en kopi av den interne listen
    public List<string> GetEntries() //returnerer kopi av den interne listen
    {
        //returns a copy of the list, instead of the list object
        return new List<string>(entries);
    }
}
