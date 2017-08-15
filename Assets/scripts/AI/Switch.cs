using UnityEngine;
using System.Collections;

public class Switch : Decorator
{
    GameObject agent;

    public Switch(string name, Behavior parent, Behavior child, GameObject agent):base(name, parent, child)
    {
        this.agent = agent;
    }
}
