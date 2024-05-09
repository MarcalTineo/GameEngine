namespace SyzygyEngine;


public class GameObject : Obj
{

    //variables
    private bool isActive;
    private Transform transform;

    //properties
    public bool IsActive { get => isActive; }
    public Transform Transform { get => transform; set => transform = value; }

    //constructor
    public GameObject()
    {

    }
    //private methods


    //public methods
    public void SetActive(bool active)
    {
        isActive = active;
    }

    public virtual void Start() { }
    public virtual void Update() { }
    public virtual void LateUpdate() { }
    public virtual void Draw() { }

    public virtual void OnDestroy() { }

    public bool Destroy()
    {

        return true;
    }

    //static methods
    /// <summary>
    /// Finds the first object in scene with the specified name.
    /// </summary>
    /// <returns>The GameObject. Null if the object is not found.</returns>
    public static GameObject Find(string name)
    {
        return null;
    }

    /// <summary>
    /// Finds the object with the specified id.
    /// </summary>
    /// <returns>The GameObject. Null if the object is not found.</returns>
    public static GameObject Find(int id)
    {
        return null;
    }

    /// <summary>
    /// Finds all gameObjects with the specified name.
    /// </summary>
    /// <returns>A list containg all gameObjects. Null if not found.</returns>
    public static List<GameObject> FindAll(string name)
    {
        return null;
    }

    /// <summary>
    /// Finds all objects with the specified tag.
    /// </summary>
    /// <returns>A list containg all gameObjects. Null if not found.</returns>
    public static List<GameObject> FindAll(/*tag*/)
    {
        return null;
    }

}