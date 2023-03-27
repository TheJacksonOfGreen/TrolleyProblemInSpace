using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody playerRigidbody;
    public float moveSpeed = 1.0f;
    private bool wDown = false;
    private bool aDown = false;
    private bool sDown = false;
    private bool dDown = false;
    private bool spaceDown = false;

    // Start is called before the first frame update
    void Start() {
        playerTransform = GetComponent<Transform>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        wDown = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        aDown = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        sDown = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        dDown = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        spaceDown = Input.GetKeyDown(KeyCode.Space);

        if (dDown) {
            if (wDown) {
                playerTransform.Translate(new Vector3((moveSpeed * 0.70710678118f), 0, (moveSpeed * 0.70710678118f)));
            } else if (sDown) {
                playerTransform.Translate(new Vector3((moveSpeed * 0.70710678118f), 0, (moveSpeed * -0.70710678118f)));
            } else {
                playerTransform.Translate(new Vector3(moveSpeed, 0, 0));
            }
        } else if (aDown) {
            if (wDown) {
                playerTransform.Translate(new Vector3((moveSpeed * -0.70710678118f), 0, (moveSpeed * 0.70710678118f)));
            } else if (sDown) {
                playerTransform.Translate(new Vector3((moveSpeed * -0.70710678118f), 0, (moveSpeed * -0.70710678118f)));
            } else {
                playerTransform.Translate(new Vector3((moveSpeed * -1), 0, 0));
            }
        } else if (wDown) {
            playerTransform.Translate(new Vector3(0, 0, moveSpeed));
        } else if (sDown) {
            playerTransform.Translate(new Vector3(0, 0, (-1 * moveSpeed)));
        }

        if (spaceDown) {
            playerRigidbody.AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
        }
    }
}
