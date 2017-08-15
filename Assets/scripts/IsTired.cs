using UnityEngine;
using System.Collections;

public class IsTired : Leaf
{
    GameObject agent;

    public IsTired(string name, Behavior parent, GameObject agent): base(name, parent)
    {
        this.agent = agent;
    }

    public override void Resolve(bool result)
    {
        AIController aic = agent.GetComponent<AIController>();

        if (aic.stamina <= aic.stamina_threshold)
        {
            aic.isTired = true;
            this.parent.Resolve(true);
        }
        else
        {
            this.parent.Resolve(false);
        }
    }
}
