using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Use physics raycast hit from mouse click to set agent destination
[RequireComponent(typeof(NavMeshAgent))]
public class AIController : Controller {

    NavMeshAgent m_Agent;
    RaycastHit m_HitInfo = new RaycastHit();

    public int hunger = 100;
    public int hungry_threshold = 50;
    public bool isHungry = false;

    public int stamina = 100;
    public int stamina_threshold = 75;
    public bool isTired = false;

    Root needs;
    Root wants;

    // Use this for initialization
    protected override void Start () {
        m_Agent = GetComponent<NavMeshAgent>();

        wants = new Root("Wants");

        Sequence ns = new Sequence("wants Sequence", wants);

        GameObject wa = GameObject.Find("WorkArea");
        GameObject ea = GameObject.Find("EatArea");
        GameObject ra = GameObject.Find("RestArea");
        GameObject ra2 = GameObject.Find("RestArea2");

        MoveTo m1 = new MoveTo("MoveToWork", ns, this.gameObject, wa);
        MoveTo m2 = new MoveTo("MoveToEat", ns, this.gameObject, ea);
        MoveTo m3 = new MoveTo("MoveToRest", ns, this.gameObject, ra);
        MoveTo m4 = new MoveTo("MoveToRest2", ns, this.gameObject, ra2);

        ns.addChild(m1);
        ns.addChild(m2);
        ns.addChild(m3);
        ns.addChild(m4);

        wants.addChild(ns);
    }

    // Update is called once per frame
    protected override void Update () {
        wants.Update();
    }


    public void moveTo(Vector3 target)
    {
        m_Agent.destination = target;
        this.hunger -= 5;
    }
}
