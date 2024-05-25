using System;

namespace SpinningDiscs
{
    public class DVD : Media, IRewritable
    {
        public DVD(string name) : base(name, "DVD", 1200, 4700) {}

        public override string ToString()
        {
            return base.ToString() + GetFormattedFileList("Video Files");
        }

        public void WriteFile(MediaFile file)
        {
            SpinDisc();
            if (files.Contains(file)) {
                Console.WriteLine("The video " + file.Name + " has already been added.");
            } else if (GetSpaceUsed() + file.Size > Capacity) {
                Console.WriteLine("WARNING: There is not enough space on the " + DiscType + " for " + file.Name + ".");
            } else {
                files.Add(file);
                Console.WriteLine("The video " + file.Name + " has been added to " + Name + ".");
            }
        }

        public void RunFile(MediaFile file)
        {
            SpinDisc();
            if (FileIsPresent(file))
            {
                Console.WriteLine("Watching " + file.Name + "...");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public void RemoveFile(MediaFile file)
        {
            SpinDisc();
            if (FileIsPresent(file))
            {
                files.Remove(file);
                Console.WriteLine("The file " + file.Name + " has been removed from the " + DiscType + ".");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public void ReformatDisc()
        {
            SpinDisc();
            files.Clear();
            Console.WriteLine("Disc reformatted to a blank " + DiscType + ".");
        }

    }
}

