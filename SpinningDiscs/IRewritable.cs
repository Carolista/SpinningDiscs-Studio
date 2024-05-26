namespace SpinningDiscs;

public interface IRewritable
{
    void WriteFile(MediaFile file);
    void RunFile(MediaFile file);
    void RemoveFile(MediaFile file);
    void Reformat();
}
