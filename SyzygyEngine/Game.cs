using System.Numerics;

namespace SyzygyEngine;
public class Game
{
    string name;
    Vector2 windowSize;
    List<Scene> scenes;
    Dictionary<string, int> sceneIndex;

    public Scene LoadedScene { get => scenes[0]; }
    public Vector2 WindowSize { get => windowSize; }
    public string Name { get => name; }

    public Game(Vector2 size)
    {
        windowSize = size;
    }

    public bool LoadGame()
    {
        return true;
    }

    public bool LoadScene(int index)
    {
        return true;
    }

    public bool LoadScene(string name)
    {
        if (!sceneIndex.ContainsKey(name))
            return false;
        return LoadScene(sceneIndex[name]);
    }
}