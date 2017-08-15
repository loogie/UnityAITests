using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence: Composite {

	public Sequence(string name, Behavior parent):base(name, parent)
    {
        this.children = new List<Behavior>();
    }

    public override void Resolve(bool result)
    {
        int index = children.IndexOf(currentChild) + 1;
        if (result == true && index < children.Count)
        {
            currentChild = children[index];
            Debug.Log("Starting: " + currentChild.name);
        }
        else
        {
            Debug.Log("Resolved: " + name);
            parent.Resolve(result);
        }
    }
}
