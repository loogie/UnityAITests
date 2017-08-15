using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Behavior {

    public string name;
    public Behavior parent;

	public Behavior(string name, Behavior parent)
    {
        this.name = name;
        this.parent = parent;
    }

    public abstract void Update();
    public abstract void Resolve(bool result);
}
