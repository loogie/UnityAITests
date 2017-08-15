using UnityEngine;
using UnityEditor;

public abstract class Leaf : Behavior
{
    public Leaf(string name, Behavior parent):base(name, parent)
    {

    }
}