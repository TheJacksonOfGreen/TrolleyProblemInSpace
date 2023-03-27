using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private int tracker;

    // Start is called before the first frame update
    void Start() {
        tracker = 1;
    }

    // Update is called once per frame
    void Update() {}

    public void register(int n) {
        tracker += n;
    }

    public int getResult() {
        return tracker;
    }
}
