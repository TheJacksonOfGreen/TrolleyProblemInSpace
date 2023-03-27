using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPass : TriggerObj
{
    public List<TriggerObj> targets;
    public float delaySeconds = 0.0f;
    private bool active = false;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {
        if (active) {
            if (delaySeconds > 0) {
                delaySeconds -= (float) Time.deltaTime;
            }

            if (delaySeconds <= 0) {
                active = false;
                foreach (TriggerObj target in targets) {
                    target.activate();
                }
            }
        }
    }

    public override void activate() {
        active = true;
    }
}
