using System.Numerics;

namespace SyzygyEngine;


public class Obj
{
    //variables
    private int id;
    private string name;

    //properties
    public int Id { get => id; }
    public string Name { get => name; set => name = value; }

    //constructor

    public Obj()
    {
        name = "";
        id = GetId();
    }

    //private methods
    protected int GetId()
    {
        return Engine.Instance.IdManager.GetNewId();
    }

    //public methods

    public override string ToString()
    {
        Type type = this.GetType();
        return $"{name}({type})";
    }




    //static methods


}