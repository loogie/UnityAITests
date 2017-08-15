using UnityEngine;
using System.Collections;

public class IsHungry : Leaf
{
    GameObject agent;

    public IsHungry(string name, Behavior parent, GameObject agent): base(name, parent)
    {
        this.agent = agent;
    }

    public override void Resolve(bool result)
    {
        AIController aic = agent.GetComponent<AIController>();

        if (aic.hunger <= aic.hungry_threshold)
        {
            aic.isHungry = true;
            this.parent.Resolve(true);
        }
        else
        {
            this.parent.Resolve(false);
        }
    }
}
