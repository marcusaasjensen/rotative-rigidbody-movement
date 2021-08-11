using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public float moveSpeed;

    private Vector3 moveDirection;
    private Vector3 rotationDirection;
    private float yRotation;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    void Update()
    {
        yRotation = transform.eulerAngles.y*Mathf.Deg2Rad; // y rotation converted from degrees to radians
        if(Input.GetAxis("Vertical") != 0)
            moveDirection = new Vector3(Mathf.Cos(yRotation), 0, -Mathf.Sin(yRotation)) * Input.GetAxis("Vertical");
        if(Input.GetAxis("Horizontal") != 0)
            moveDirection = new Vector3(Mathf.Cos(yRotation + Mathf.PI/2), 0, -Mathf.Sin(yRotation + Mathf.PI/2)) * Input.GetAxis("Horizontal");
        player.velocity = moveDirection * moveSpeed * Time.deltaTime;
        Debug.Log("velocity.x = " + player.velocity.x + ", velocity.z = " + player.velocity.z + ", Cos(rot) = " + Mathf.Cos(yRotation) + ", Sin(rot) = " + Mathf.Sin(yRotation) + ", rot° = " + transform.eulerAngles.y);
    }
}
