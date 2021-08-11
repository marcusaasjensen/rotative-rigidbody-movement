using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float rotationSpeed;
    
    private Vector3 rotation;
    
    void Start()
    {
        rotation = new Vector3(0,0,0);
    }

    void Update()
    {
        rotation += new Vector3(0,Input.GetAxis("Mouse ScrollWheel"),0);
        transform.rotation = Quaternion.Euler(rotation * rotationSpeed);
    }
}
