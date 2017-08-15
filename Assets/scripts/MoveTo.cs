using UnityEngine;
using System.Collections;
using System;

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
        if (isAt(target))
        {
            this.Resolve(true);
        }
        else
        {
            if (true) //(TODO: check if agent can still try to move)
            {
                AIController aic = agent.GetComponent<AIController>();
                aic.moveTo(target.transform.position);
            }
        }
    }

    private bool isAt(GameObject target)
    {
        Collider zone = target.GetComponentInChildren<Collider>();
        if (zone.bounds.Contains(agent.transform.position))
        {
            return true;
        }

        return false;
    }

    public override void Resolve(bool result)
    {
        this.parent.Resolve(result);
    }
}
