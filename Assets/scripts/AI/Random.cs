using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random: Composite {

	public Random(string name, Behavior parent):base(name, parent)
    {
        this.children = new List<Behavior>();
    }

    public override void reset()
    {
        int index = UnityEngine.Random.Range(0, children.Count - 1);

        while (index == children.IndexOf(currentChild))
        {
            index = UnityEngine.Random.Range(0, children.Count - 1);
        }

        currentChild = children[index];
    }

    public override void Resolve(bool result)
    {
        base.Resolve(result);

        int index = UnityEngine.Random.Range(0, children.Count - 1);
        
        while (index == children.IndexOf(currentChild))
        {
            index = UnityEngine.Random.Range(0, children.Count - 1);
        }

        if (result == true && index < children.Count)
        {
            currentChild = children[index];
            Debug.Log("Starting: " + currentChild.name);
        }
        else
        {
            Debug.Log("Resolved: " + name);
            this.parent.Resolve(result);
        }
    }
}
