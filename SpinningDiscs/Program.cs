using SpinningDiscs;

/* CD AND DVD CLASSES */

static void RunCDAndDVD()
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

RunCDAndDVD();


/* FLOPPYDISK & VINYLRECORD CLASSES */

static void RunFloppyDiskAndRecord()
{
    // Create objects of the FloppyDisk and VinylRecord classes
    FloppyDisk philosophyPapers = new("Philosophy Papers", 3.5);
    VinylRecord magCityInstr = new("Magnificent City Instrumentals", 12);

    // Create File objects and add them to the FloppyDisk object using writeData()
    MediaFile historyOfPhilosophy = new("history-of-philosophy.doc", 0.4);
    MediaFile absoluteTruths = new("absolute-truths.doc", 0.63);
    philosophyPapers.WriteFile(historyOfPhilosophy);
    philosophyPapers.WriteFile(absoluteTruths);

    // Create File objects and add them (as an array) to the VinylRecord object using pressVinyl()
    MediaFile aBeautifulMine = new("A Beautiful Mine", 53);
    MediaFile fire = new("Fire", 41);
    MediaFile aSundayMystery = new("A Sunday Mystery", 13);
    MediaFile[] files = { aBeautifulMine, fire, aSundayMystery };
    magCityInstr.PressVinyl(files);

    // Print both objects
    Console.WriteLine(philosophyPapers);
    Console.WriteLine(magCityInstr);

    // Run a file from the FloppyDisk object
    philosophyPapers.RunFile(absoluteTruths);

    // Play a track from the VinylRecord object
    magCityInstr.PlayTrack(aBeautifulMine);
}

RunFloppyDiskAndRecord();


/* FRISBEE & WHEEL CLASSES */

static void RunFrisbeeAndWheel()
{
    // Create multiple objects of the Wheel and Frisbee classes
        Wheel michelin = new("Michelin Defender 2 235/60 R18 106H", 18);
        Wheel goodyear = new("Goodyear Edge A/T 225/75 R15", 15);
        Frisbee ultimateDisc = new("Innova Pulsar", "Ultimate disc");
        Frisbee freestyleDisc = new("Discraft Sky Styler", "Freestyle disc");

        // Print each object
        Console.WriteLine(michelin);
        Console.WriteLine(goodyear);
        Console.WriteLine(ultimateDisc);
        Console.WriteLine(freestyleDisc);

        // Drive a car for one Wheel object
        michelin.DriveCar();

        // Change the MPH of both wheels and drive cars
        michelin.MilesPerHour = 45;
        goodyear.MilesPerHour = 70;
        michelin.DriveCar();
        goodyear.DriveCar();

        // Throw a disc for each Frisbee object
        ultimateDisc.ThrowFrisbee();
        freestyleDisc.ThrowFrisbee();
}

RunFrisbeeAndWheel();