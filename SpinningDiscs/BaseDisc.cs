namespace SpinningDiscs;

public abstract class BaseDisc
{
    private static int nextId = 1;
    public readonly int id;

    public string Name { get; set; }
    public string DiscType { get; set; }
    public int SpinRate { get; set; }

    public BaseDisc(string name, string discType, int spinRate)
    {
        id = nextId;
        nextId++;
        Name = name;
        DiscType = discType;
        SpinRate = spinRate;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        string stars = "*****";
        return nl + stars + " " + Name + " " + stars + nl
            + "ID: " + id + nl
            + "Disc Type: " + DiscType + nl
            + "Spin Rate: " + SpinRate + " RPM" + nl;
    }

    public void SpinDisc() 
    {
        string nl = Environment.NewLine;
        Console.WriteLine(nl + "The " + DiscType + " " + Name
            + " is spinning at " + SpinRate + " RPM.");
    }
}
