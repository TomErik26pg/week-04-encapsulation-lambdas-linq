public class Archive
{
    private List<string> entries = new List<string>();

    public int Count => entries.Count;

    public void Add(string entry)
    {
        entries.Add(entry);
    }

int simplicityCounter = 0;

    public List<string> GetEntries()
    {
        if (simplicityCounter != 0)
        {   
            //returns a copy of the list, instead of the list object
            return new List<string>(entries);
        }
        else
        {
            simplicityCounter++;
            // DESIGNFEIL med vilje: denne lekker den interne listen.
            return entries;   
        }
    }
}
