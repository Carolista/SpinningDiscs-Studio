namespace SpinningDiscs
{
    public class CD : Media, IRewritable
    {

        public bool IsMusicCD { get; set; }

        public CD(string name, bool isMusicCD) : base(name, isMusicCD ? "music CD" : "CD-RW", 800, 700)
        {
            IsMusicCD = isMusicCD;
        }

        public CD(string name) : this(name, false) { }

        public override string ToString()
        {
            string header = IsMusicCD ? "Tracks" : "Files";
            return base.ToString() + GetFormattedFileList(header);
        }

        public void WriteFile(MediaFile file)
        {
            SpinDisc();
            string fileType = IsMusicCD ? "track" : "file";
            if (files.Contains(file))
            {
                Console.WriteLine("The " + fileType + file.Name + " has already been added.");
            }
            else if (GetSpaceUsed() + file.Size > Capacity)
            {
                Console.WriteLine("WARNING: There is not enough space on the " + DiscType + " for " + file.Name + ".");
            }
            else
            {
                files.Add(file);
                Console.WriteLine("The " + fileType + " " + file.Name + " has been added to " + Name + ".");
            }
        }

        public void RunFile(MediaFile file)
        {
            SpinDisc();
            if (FileIsPresent(file))
            {
                string verb = IsMusicCD ? "Playing " : "Opening file ";
                Console.WriteLine(verb + file.Name + "...");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public void RemoveFile(MediaFile file)
        {
            if (IsMusicCD)
            {
                Console.WriteLine("Individual files cannot be removed from a music CD once written.");
            } else {
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
        }

        public void ReformatDisc()
        {
            SpinDisc();
            files.Clear();
            IsMusicCD = false;
            DiscType = "CD-RW";
            Console.WriteLine("Disc reformatted to a blank " + DiscType + ".");
        }
    }
}

