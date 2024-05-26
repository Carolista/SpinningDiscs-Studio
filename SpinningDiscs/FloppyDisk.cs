namespace SpinningDiscs;

public class FloppyDisk : Media, IRewritable, IVariableRPM
{
    public double Width { get; set; }

    public FloppyDisk(string name, double width)
        : base(name, "floppy disk", 0, 0)
    {
        Width = width;
        SpinRate = CalculateSpinRate();
        Capacity = CalculateCapacity();
    }

    public override string ToString()
    {
        return base.ToString() + GetFileList("Files");
    }

    private double CalculateCapacity()
    {
        Dictionary<double, double> capacities = new() { { 3.5, 1.44 }, { 5.25, 360 } };
        return capacities[Width];
    }

    // Methods required by IRewritable

    public void WriteFile(MediaFile file)
    {
        SpinDisc();
        if (files.Contains(file))
        {
            Console.WriteLine("The file " + file.Name + " has already been added.");
        }
        else if (GetSpaceUsed() + file.Size > Capacity)
        {
            Console.WriteLine(
                "WARNING: There is not enough space on the " + DiscType + " for " + file.Name + "."
            );
        }
        else
        {
            files.Add(file);
            Console.WriteLine("The file " + file.Name + " has been added to " + Name + ".");
        }
    }

    public void RunFile(MediaFile file)
    {
        SpinDisc();
        if (files.Contains(file))
        {
            Console.WriteLine("Opening " + file.Name + "...");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RemoveFile(MediaFile file)
    {
        SpinDisc();
        if (files.Contains(file))
        {
            files.Remove(file);
            Console.WriteLine(
                "The file " + file.Name + " has been removed from the " + DiscType + "."
            );
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void Reformat()
    {
        SpinDisc();
        files.Clear();
        Console.WriteLine("Disc reformatted to a blank " + DiscType + ".");
    }

    // Method required by VariableRPM

    public int CalculateSpinRate()
    {
        Dictionary<double, int> speeds = new() { { 3.5, 300 }, { 5.25, 360 } };
        return speeds[Width];
    }

}
