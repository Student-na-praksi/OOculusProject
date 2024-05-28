using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f; // the speed of rotation
    public bool useTarget = false; // if true, the sphere will rotate around the target
    public Transform target; // the target the spotlights are pointing to
    // Update is called once per frame

    void Update()
    {
        // Rotate the sphere around the y axis at speed degrees per second
        if (!useTarget)
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        else
            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
    }
}
