using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    private Vector3 mousePos;
    private bool isDragging = false;

    void Update() {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null && hit.transform.gameObject.name == "Sphere") {
                isDragging = true;
            }
        } else if (Input.GetMouseButtonUp(0) && isDragging) {
            isDragging = false;
            Impulse.jumpVector = (transform.position - mousePos).normalized;
            Impulse.triggerJump = true;
        }
    }
}
