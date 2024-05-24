namespace SpinningDiscs;

public class MediaFile
{
    public string Name { get; set; }
    public double Size { get; set; }

    public MediaFile(string name, double size)
    {
        Name = name;
        Size = size;
    }

    public override string ToString()
    {
        return Name + " - " + Size + " MB";
    }
}
