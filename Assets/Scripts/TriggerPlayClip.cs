using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayClip : TriggerObj
{
    public AudioSource source;
    public AudioClip soundClip;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    public override void activate() {
        source.clip = soundClip;
        source.Play();
    }
}
