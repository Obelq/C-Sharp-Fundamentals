namespace FerrariTask
{
    public class Ferrari : ICar
    {
        public const string Model = "488-Spider";

        public Ferrari(string driverName)
        {
            DriverName = driverName;
        }

        public string DriverName { get; }

        public string Brake()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{Model}/{this.Brake()}/{this.Gas()}/{this.DriverName}";
        }
    }
}