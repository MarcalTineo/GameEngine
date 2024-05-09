using System.Numerics;

namespace SyzygyEngine;

public class Transform
{
    private Vector2 position;
    private Vector2 size;
    private float rotation;
    private GameObject gameObject;

    public Vector2 Position { get => position; set => position = value; }
    public Vector2 Size { get => size; set => size = value; }
    public float Rotation { get => rotation; set => rotation = value; }
    public GameObject GameObject { get => gameObject; set => gameObject = value; }

    public Transform(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    public void Translate(Vector2 translation)
    {
        position += translation;
    }

    public void Rotate(float degrees)
    {
        rotation += degrees;
    }


}