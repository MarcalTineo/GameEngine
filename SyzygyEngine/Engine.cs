namespace SyzygyEngine;

public sealed class Engine
{
    //singleton
    private static readonly Engine instance = new Engine();

    static Engine() { }
    internal Engine() { }

    public static Engine Instance { get { return instance; } }



    //variables
    IdManager idManager = new IdManager();

    //properties
    internal IdManager IdManager { get => idManager; }

    internal void Run(Game game)
    {

    }
}
