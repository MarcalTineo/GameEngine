namespace SyzygyEngine;


public class GameObject : TaggableObject
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
        foreach (GameObject item in Engine.Instance.Scene.sceneActors)
        {
            if (item.Name == name)
                return item;
        }
        return null;
    }

    /// <summary>
    /// Finds the object with the specified id.
    /// </summary>
    /// <returns>The GameObject. Null if the object is not found.</returns>
    public static GameObject Find(int id)
    {
        foreach (GameObject item in Engine.Instance.Scene.sceneActors)
        {
            if (item.Id == id)
                return item;
        }
        return null;
    }

    /// <summary>
    /// Finds all gameObjects with the specified name.
    /// </summary>
    /// <returns>A list containg all gameObjects. Empty list if not found any.</returns>
    public static List<GameObject> FindAllName(string name)
    {
        List<GameObject> list = new List<GameObject>();
        foreach (GameObject item in Engine.Instance.Scene.sceneActors)
        {
            if (item.Name == name)
                list.Add(item);
        }
        return list;
    }

    /// <summary>
    /// Finds all objects with the specified tag.
    /// </summary>
    /// <returns>A list containg all gameObjects. Null if not found.</returns>
    public static List<GameObject> FindAllTag(string tag)
    {
        List<GameObject> list = new List<GameObject>();
        foreach (GameObject item in Engine.Instance.Scene.sceneActors)
        {
            if (item.CompareTag(tag))
                list.Add(item);
        }
        return list;
    }

}