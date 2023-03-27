using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneCond : TriggerObj
{
    public List<TriggerObj> worstEndingTargets;
    public List<TriggerObj> badEndingTargets;
    public List<TriggerObj> neutralEndingTargets;
    public List<TriggerObj> goodEndingTargets;
    public List<TriggerObj> bestEndingTargets;
    private List<TriggerObj> targets;
    public Collector collector;
    public bool active = true;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    void OnTriggerStay(Collider c) {
        if (c.name == "Player" && active) {
            switch (collector.getResult()) {
                case 0:
                    targets = new List<TriggerObj>(worstEndingTargets);
                    break;
                case 1:
                    targets = new List<TriggerObj>(badEndingTargets);
                    break;
                case 2:
                    targets = new List<TriggerObj>(badEndingTargets);
                    break;
                case 3:
                    targets = new List<TriggerObj>(badEndingTargets);
                    break;
                case 4:
                    targets = new List<TriggerObj>(neutralEndingTargets);
                    break;
                case 5:
                    targets = new List<TriggerObj>(goodEndingTargets);
                    break;
                case 6:
                    targets = new List<TriggerObj>(goodEndingTargets);
                    break;
                case 7:
                    targets = new List<TriggerObj>(goodEndingTargets);
                    break;
                case 8:
                    targets = new List<TriggerObj>(bestEndingTargets);
                    break;
            }
            foreach (TriggerObj target in targets) {
                target.activate();
            }
            active = false;
        }
    }

    public override void activate() {
        active = !active;
    }
}
