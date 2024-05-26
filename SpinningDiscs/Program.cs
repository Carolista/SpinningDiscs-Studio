using SpinningDiscs;

/* CD AND DVD CLASSES */

static void RunCDAndDVD()
{
    // Create objects of the CD and DVD classes
    CD theNorthBorders = new("The North Borders", true);
    CD graphicDesignProjects = new("Graphic Design Projects");
    DVD friendsSeason3 = new("Friends: Season 3");

    // Create MediaFile objects
    MediaFile firstFires = new("First Fires", 50);
    MediaFile cirrus = new("Cirrus", 61);
    MediaFile transit = new("Transit", 57);

    MediaFile festivalPoster = new("festival-poster.psd", 240);
    MediaFile companyLogo = new("company-logo.ai", 52);

    MediaFile s3e1 = new("S3:E1 - The One with the Princess Leia Fantasy", 420);
    MediaFile s3e2 = new("S3:E2 - The One Where No One's Ready", 420);
    MediaFile s3e3 = new("S3:E3 - The One with the Jam", 420);
    MediaFile s3e4 = new("S3:E4 - The One with the Metaphorical Tunnel", 420);

    // Write files to the CDs and DVD
    theNorthBorders.WriteFile(firstFires);
    theNorthBorders.WriteFile(cirrus);
    theNorthBorders.WriteFile(transit);
    graphicDesignProjects.WriteFile(festivalPoster);
    graphicDesignProjects.WriteFile(companyLogo);
    friendsSeason3.WriteFile(s3e1);
    friendsSeason3.WriteFile(s3e2);
    friendsSeason3.WriteFile(s3e3);
    friendsSeason3.WriteFile(s3e4);

    // Print each CD and DVD object
    Console.WriteLine(theNorthBorders);
    Console.WriteLine(graphicDesignProjects);
    Console.WriteLine(friendsSeason3);

    // Run some CD files
    theNorthBorders.RunFile(cirrus);
    graphicDesignProjects.RunFile(companyLogo);

    // Try to write a file that has already been written to the DVD
    friendsSeason3.WriteFile(s3e2);

    // Remove one file from the CD-RW object, then try to run that file
    graphicDesignProjects.RemoveFile(festivalPoster);
    graphicDesignProjects.RunFile(festivalPoster);

    // Wipe all files from the music CD, then try to run a file from it
    theNorthBorders.Reformat();
    theNorthBorders.RunFile(transit);

    // Try to write the file below to the CD that is no longer a music CD
    MediaFile tooBigFile = new("too-big-file.mp4", 720);
    theNorthBorders.WriteFile(tooBigFile);
}

RunCDAndDVD();

// Bonus missions handled in Part 2 — see the solution-bonus branch
