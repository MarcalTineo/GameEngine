using SFML.Window;

namespace SyzygyEngine;

public static class Input
{
    static bool enabled;
    static bool[] keysPressed = new bool[(int)Keyboard.Key.KeyCount];
    static bool[] lastKeyPressed = new bool[(int)Keyboard.Key.KeyCount];

    public static bool Enabled { get => enabled; }
    public static void Enable() { enabled = true; }
    public static void Disable() { enabled = false; }

    public static bool GetKey(Keyboard.Key key)
    {
        return keysPressed[(int)key];
    }
    public static bool GetKeyDown(Keyboard.Key key)
    {
        return keysPressed[(int)key] && !lastKeyPressed[(int)key];
    }
    public static bool GetKeyUp(Keyboard.Key key)
    {
        return !keysPressed[(int)key] && lastKeyPressed[(int)key];
    }
    public static bool AnyKey(Keyboard.Key key)
    {
        return keysPressed.Contains(true);
    }

    internal static void UpdateInput()
    {
        lastKeyPressed = keysPressed;
        for (int i = 0; i < (int)Keyboard.Key.KeyCount; i++)
            keysPressed[i] = Keyboard.IsKeyPressed((Keyboard.Key)i);
    }



}