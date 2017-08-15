using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator: Behavior {

    private Behavior child;

	public Decorator(string name, Behavior parent, Behavior child):base(name, parent)
    {
        this.child = child;
    }

    public override void Update()
    {
        if (this.child != null)
        {
            this.child.Update();
        }
    }

    public override void Resolve(bool result)
    {
        this.parent.Resolve(result);
    }
}
