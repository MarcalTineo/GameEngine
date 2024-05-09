namespace SyzygyEngine;

internal class IdManager
{
    //variables
    private List<int> usedIds = new List<int>();
    Random rnd;

    //constructor
    public IdManager()
    {
        rnd = new Random();
    }

    //public methods
    /// <summary>
    /// Creates a new valid id.
    /// </summary>
    /// <returns>The new id</returns>
    public int GetNewId()
    {
        int newId;
        do
        {
            newId = rnd.Next(2147483647);
        } while (IdExists(newId));
        return newId;
    }

    /// <summary>
    /// Deletes the specified id from the id registry.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>True if the specified id is successfully removed; otherwise, false.</returns>
    public bool RetireId(int id)
    {
        return usedIds.Remove(id);
    }

    //provate methods
    private bool IdExists(int _id)
    {
        foreach (int id in usedIds)
        {
            if (id == _id)
                return true;
        }
        return false;
    }







}
