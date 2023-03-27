using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollect : TriggerObj
{
    public Collector collector;
    public int sendNum;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    public override void activate() {
        collector.register(sendNum);
    }
}
