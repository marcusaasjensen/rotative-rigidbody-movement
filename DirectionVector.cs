using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionVector : MonoBehaviour
{
    public Rigidbody rb;
    public float length;
    public float size;

    private float directionIntensity;
    private float offSet;
    private float magnitude;
    void Update()
    {
        directionIntensity = Mathf.Abs(rb.velocity.x + rb.velocity.z);
        offSet = transform.parent.transform.localScale.x/2;
        magnitude = directionIntensity * length / 2;

        transform.localScale = new Vector3(magnitude * Input.GetAxisRaw("Vertical") + size, size, magnitude * -Input.GetAxisRaw("Horizontal") + size);
        transform.localPosition = new Vector3((magnitude + offSet) * Input.GetAxisRaw("Vertical"), transform.localPosition.y, (magnitude + offSet) * -Input.GetAxisRaw("Horizontal"));
    }
}
