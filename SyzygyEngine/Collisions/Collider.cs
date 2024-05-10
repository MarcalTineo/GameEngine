namespace SyzygyEngine.Collisions;

public class Collider
{
    private GameObject gameObject;

    public GameObject GameObject { get => gameObject; }

    public Collider(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    public virtual Collider CheckCollisions() { return null; }
}