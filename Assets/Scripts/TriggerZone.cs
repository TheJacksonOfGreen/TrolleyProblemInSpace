using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : TriggerObj
{
    public List<TriggerObj> targets;
    public bool active = true;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    void OnTriggerStay(Collider c) {
        if (c.name == "Player" && active) {
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
