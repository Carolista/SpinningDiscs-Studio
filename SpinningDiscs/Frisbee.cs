namespace SpinningDiscs;

public class Frisbee : BaseDisc, IVariableRPM
{

    public double Diameter { get; set;}

    public Frisbee(string name, string discType) : base(name, discType, 0)
    {
        SpinRate = CalculateSpinRate();
    }

    public override string ToString()
    {
        return base.ToString() + "DIAMETER: " + Diameter;
    }

    // Instance methods

    public double LookUpDiameter()
    {
        Dictionary<string, double> diameters = new() {
            { "Ultimate disc", 10.75 },
            { "Disc Golf disc", 8.27 },
            { "Freestyle disc", 10.0 }
        };

        return diameters[DiscType];
    }

    public void ThrowFrisbee()
    {
        SpinDisc();
        Console.WriteLine("Hey, nice throw!");
    }

    // Method required by IVariableRPM

    public int CalculateSpinRate()
    {
        const int avgFrisbeeMPH = 50;
        const int INCHES_PER_MILE = 63360;

        double diameter = LookUpDiameter();

        double rate = avgFrisbeeMPH * INCHES_PER_MILE / (diameter * Math.PI * 60);

        return (int)Math.Round(rate);
    }
}
