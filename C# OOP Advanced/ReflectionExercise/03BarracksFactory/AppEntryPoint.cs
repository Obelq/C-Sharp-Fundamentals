class AppEntryPoint
{
    static void Main(string[] args)
    {
        IRepository repository = new UnitRepository();
        IUnitFactory unitFactory = new UnitFactory();
        ICommandFactory commandFactory = new CommandFactory();
        ICommandInterpreter commandInterpreter = new CommandInterpreter(repository, unitFactory, commandFactory);
        IRunnable engine = new Engine(commandInterpreter);
        engine.Run();
    }
}

