using SpinningDiscs;

/* CD AND DVD CLASSES */

void RunCDsAndDVDs()
{
    // Create objects of the CD and DVD classes
    CD theNorthBorders = new("The North Borders", true);
    CD graphicDesignProjects = new("Graphic Design Projects");
    DVD friendsSeason3 = new("Friends: Season 3");

    // Create File objects and add them to the CD and DVD objects using writeData()
    MediaFile firstFires = new("First Fires", 50);
    MediaFile cirrus = new("Cirrus", 61);
    MediaFile transit = new("Transit", 57);
    theNorthBorders.WriteFile(firstFires);
    theNorthBorders.WriteFile(cirrus);
    theNorthBorders.WriteFile(transit);

    MediaFile festivalPoster = new("festival-poster.psd", 240);
    MediaFile companyLogo = new("company-logo.ai", 52);
    graphicDesignProjects.WriteFile(festivalPoster);
    graphicDesignProjects.WriteFile(companyLogo);

    MediaFile s3e1 = new("S3:E1 - The One with the Princess Leia Fantasy", 420);
    MediaFile s3e2 = new("S3:E1 - The One Where No One's Ready", 420);
    MediaFile s3e3 = new("S3:E1 - The One with the Jam", 420);
    MediaFile s3e4 = new("S3:E1 - The One with the Metaphorical Tunnel", 420);
    friendsSeason3.WriteFile(s3e1);
    friendsSeason3.WriteFile(s3e2);
    friendsSeason3.WriteFile(s3e3);
    friendsSeason3.WriteFile(s3e4);

    // Print each CD and DVD object
    Console.WriteLine(theNorthBorders);
    Console.WriteLine(graphicDesignProjects);
    Console.WriteLine(friendsSeason3);

    // Use runFile() on both CD files
    theNorthBorders.RunFile(cirrus);
    graphicDesignProjects.RunFile(companyLogo);

    // Try to write a file to the DVD that has already been written
    friendsSeason3.WriteFile(s3e2);

    // Use eraseData() to remove one file from the CD-ROM object, and then try to run that file
    graphicDesignProjects.RemoveFile(festivalPoster);
    theNorthBorders.RunFile(festivalPoster);

    // Use reformatDisc() to wipe all files from the music CD, and then try to run a file from it
    theNorthBorders.ReformatDisc();
    theNorthBorders.RunFile(transit);

    // Create a 720 MB MP4 file and try to write it to the CD that is no longer a music CD
    MediaFile tooBigFile = new("too-big-file.mp4", 720);
    theNorthBorders.WriteFile(tooBigFile);
}

RunCDsAndDVDs();

/* FLOPPYDISK & VINYLRECORD CLASSES */

void RunFloppyDiskAndRecord()
{

}

/* FRISBEE & WHEEL CLASSES */

void RunFrisbeeAndWheel()
{

}