public class SpecimenVault
{
    private List<string> specimens = new List<string>();

    public void Add(string specimen)
    {
        specimens.Add(specimen);
    }

    public bool Remove(string specimen)
    {
        if (specimens.Contains(specimen))
        {
            specimens.Remove(specimen);
            return true;
        }
        return false;
    }

    public void PrintAll()
    {
        foreach (string specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }
}
