namespace SyzygyEngine.Collisions;

public class Collider
{
    private GameObject gameObject;

    public GameObject GameObject { get => gameObject; set => gameObject = value; }

    public Collider(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }
}