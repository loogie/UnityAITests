using UnityEngine;
using System.Collections;

public class MoveTo : Leaf
{
    private GameObject agent;
    private GameObject target;

    public MoveTo(string name, Behavior parent, GameObject agent, GameObject target): base(name, parent)
    {
        this.agent = agent;
        this.target = target;
    }

    public override void Update()
    {
        Vector2 
    }
}
