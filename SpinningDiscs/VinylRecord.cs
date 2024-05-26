namespace SpinningDiscs;

public class VinylRecord : Media, IVariableRPM
{

    public int Diameter { get; set; }

    public VinylRecord(string name, int diameter) : base(name, "record", 0, 440)
    {
        Diameter = diameter;
        CalculateSpinRate();
    }

    public override string ToString()
    {
        return base.ToString() + GetFormattedFileList("Tracks");
    }

    // Instance methods

    public void PressVinyl(MediaFile[] fileArr)
    {
        string nl = Environment.NewLine;
        double totalSize = 0;
        foreach (MediaFile file in fileArr)
        {
            totalSize += file.Size;
        }
        if (totalSize <= Capacity)
        {
            files.AddRange(fileArr);
            Console.WriteLine(nl + "Vinyl pressed with all tracks for " + Name + ".");
        }
        else
        {
            Console.WriteLine(nl + "There is not enough space for all the files to be pressed to vinyl.");
        }
    }

    public void PlayTrack(MediaFile file)
    {
        if (FileIsPresent(file))
        {
            SpinDisc();
            Console.WriteLine("Positioning needle...");
            Console.WriteLine("You are now listening to " + file.Name + ".");
        }
        else {
            Console.WriteLine("That track does not exist on this record.");
        }
    }

    // Method required by IVariableRPM
    
    public int CalculateSpinRate()
    {
        Dictionary<int, int> speeds = new() {
            { 12, 33 },
            { 7, 45 },
            { 10, 78 }
        };

        return speeds[Diameter];
    }

}
