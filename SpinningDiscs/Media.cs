using System.Text;

namespace SpinningDiscs;

public abstract class Media: BaseDisc
{
    public readonly List<MediaFile> files = new();

    public double Capacity { get; set; }

    public Media(string name, string discType, int spinRate, double capacity) : base(name, discType, spinRate)
    {
        Capacity = capacity;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString()
            + "Capacity: " + Capacity + " MB" + nl
            + "Space Used: " + GetSpaceUsed() + " MB" + nl
            + "Available Space: " + GetSpaceAvailable() + " MB" + nl;
    }

    public string GetFormattedFileList(string header)
    {
        StringBuilder fileList = new();
        string nl = Environment.NewLine;
        if (files.Count > 0)
        {
            fileList.Append(nl).Append(header).Append(':');
            foreach (MediaFile file in files) 
            {
                fileList.Append(nl).Append('\t').Append(file);
            }
        }
        return fileList.ToString();
    }

    public bool FileIsPresent(MediaFile file)
    {
        if (files.Contains(file))
        {
            return true;
        }
        else
        {
            Console.WriteLine("That file does not exist on this " + DiscType + ".");
            return false;
        }
    }

    public double GetSpaceUsed()
    {
        double total = 0.0;
        foreach (MediaFile file in files)
        {
            total += file.Size;
        }
        return total;
    }

    public double GetSpaceAvailable()
    {
        double space = Capacity == 0 ? 0 : Capacity - GetSpaceUsed();
        return Math.Round(space, 2);
    }
}
