using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour {

    private Rigidbody2D body;
    private float power = 15f;

    public static Vector2 jumpVector;
    public static bool triggerJump;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
        triggerJump = false;
    }

    void FixedUpdate() {
        if (triggerJump) {
            body.AddForce(jumpVector * power, ForceMode2D.Impulse);
            triggerJump = false;
        }
    }
}
