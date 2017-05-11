namespace FerrariTask
{
    public interface ICar
    {
        string DriverName { get; }
        string Brake();
        string Gas();
    }
}