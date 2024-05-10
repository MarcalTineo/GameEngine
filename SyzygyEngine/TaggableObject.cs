namespace SyzygyEngine;

public class TaggableObject : Obj
{
    List<string> tags;

    public List<string> Tags { get => tags; }

    /// <summary>
    /// Adds a tag to the gameObject.
    /// </summary>
    public void AddTag(string tag)
    {
        if (!tags.Contains(tag))
            tags.Add(tag);
    }

    /// <summary>
    /// Removes a tag from the gameObject.
    /// </summary>
    public void RemoveTag(string tag)
    {
        tags.Remove(tag);
    }

    /// <summary>
    /// Check if the gameObject has the specified tag.
    /// </summary>
    /// <returns>True if it has the tag. False if it doesn't.</returns>
    public bool CompareTag(string tag)
    {
        if (tags.Contains(tag))
            return true;
        return false;
    }
}