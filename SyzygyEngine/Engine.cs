

using SFML.Graphics;
using SFML.Window;

namespace SyzygyEngine;

public sealed class Engine
{
    //singleton
    private static readonly Engine instance = new Engine();

    static Engine() { }
    internal Engine() { }

    public static Engine Instance { get { return instance; } }

    //variables
    Game game;
    RenderWindow window;
    IdManager idManager = new IdManager();

    //properties
    public Game Game { get => game; }
    public Scene Scene { get => game.LoadedScene; }
    internal IdManager IdManager { get => idManager; }

    //methods
    internal void Run(Game game)
    {
        this.game = game;

        VideoMode mode = new VideoMode((uint)game.WindowSize.X, (uint)game.WindowSize.Y);
        window = new RenderWindow(mode, game.Name);

        window.SetVerticalSyncEnabled(true);

        window.Closed += (sender, args) => window.Close();

        while (window.IsOpen)
        {
            HandleEvents();
            Input.UpdateInput();
            Update();
            LateUpdate();
            HandleNewObjects();
            HandleDestructions();
            Draw();
        }

    }

    private void HandleDestructions()
    {
        foreach (GameObject item in Instance.Scene.deleteObjects)
        {
            item.OnDestroy();
            item.SetActive(false);
            Instance.Scene.sceneActors.Remove(item);
        }
    }

    private void HandleNewObjects()
    {
        foreach (GameObject item in Instance.Scene.newObjects)
        {
            item.Start();
            Instance.Scene.sceneActors.Add(item);
        }
        Instance.Scene.newObjects.Clear();
    }

    private void Draw()
    {
        throw new NotImplementedException();
    }

    private void LateUpdate()
    {
        foreach (GameObject item in Instance.Scene.sceneActors)
        {
            item.LateUpdate();
        }
    }

    private void Update()
    {
        foreach (GameObject item in Instance.Scene.sceneActors)
        {
            item.Update();
        }
    }

    private void HandleEvents()
    {
        window.DispatchEvents();
    }
}
