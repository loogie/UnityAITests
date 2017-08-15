using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root: Behavior {

    private Behavior child;

    public Root(string name):base(name, null)
    {
    }

    public void addChild(Behavior child)
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
        Debug.Log("Root has resolved to " + result);
        this.child.reset();
    }
}
