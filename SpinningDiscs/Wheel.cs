namespace SpinningDiscs;

public class Wheel : BaseDisc, IVariableRPM
{
    public int Radius { get; set; }
    public int MilesPerHour { get; set; } = 0;

    public Wheel(string name, int radius) : base(name, "wheel", 0)
    {
        Radius = radius;
        SpinRate = CalculateSpinRate();
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString()
            + "Radius: " + Radius + nl
            + "Current MPH: " + MilesPerHour + nl;
    }

    // Instance method

    public void DriveCar()
    {
        if (MilesPerHour > 0)
        {
            SpinDisc();
            Console.WriteLine("You are traveling at " + MilesPerHour + " MPH. Please drive safely!");
        }
        else 
        {
            Console.WriteLine("You're not going anywhere unless you set a MPH greater than 0!");
        }
    }

    // Method required by IVariableRPM

    public int CalculateSpinRate()
    {
        const int INCHES_PER_MILE = 63360;

        double rate = MilesPerHour * INCHES_PER_MILE / (2 * Radius * Math.PI * 60);

        return (int)Math.Round(rate);
    }
}
