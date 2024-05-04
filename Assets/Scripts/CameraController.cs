using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 current, previous;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            current = Input.mousePosition;
            gameObject.transform.Translate((previous-current).normalized/2);
            previous = current;
        }
    }
}
