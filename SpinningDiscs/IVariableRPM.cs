namespace SpinningDiscs;

public interface IVariableRPM
{
    const double PI = 3.1417;
    const int INCHES_PER_MILE = 63360;

    bool IsValid();
    int CalculateSpinRate();
}
