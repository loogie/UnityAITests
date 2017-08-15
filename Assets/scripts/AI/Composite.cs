using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Composite: Behavior {

    protected Behavior parent;
    protected Behavior currentChild;
    protected List<Behavior> children;

	public Composite(string name, Behavior parent):base(name, parent)
    {
        this.children = new List<Behavior>();
    }

    public void addChild(Behavior child)
    {
        children.Add(child);
        if (currentChild == null)
        {
            currentChild = child;
        }
    }

    public void removeChild(Behavior child)
    {
        children.Remove(child);
        if (currentChild == child)
        {
            currentChild = null;
        }
    }

    public override void Update()
    {
        if (this.currentChild != null)
        {
            this.currentChild.Update();
        }
    }
}
