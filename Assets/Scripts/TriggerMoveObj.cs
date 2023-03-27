using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMoveObj : TriggerObj
{
    public Vector3 motion;
    public float time;
    private Transform objTransform;
    private float elapsed = -99.0f;

    // Start is called before the first frame update
    void Start() {
        objTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        if (elapsed >= 0) {
            elapsed -= (float) Time.deltaTime;
            objTransform.Translate(motion * ((float) Time.deltaTime) / time);
        }
    }

    public override void activate() {
        elapsed = time;
    }
}
