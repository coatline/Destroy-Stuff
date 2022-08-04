using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Jump");
        

        if (x > .4f)
        {
            x = .4f;
        }

        else if (x < -.4f)
        {
            x = -.4f;
        }

        if (y > .2f)
        {
            y = .2f;
        }

        else if (y < -.2f)
        {
            y = -.2f;
        }

        if (z > .4f)
        {
            z = .4f;
        }

        else if (z < -.4f)
        {
            z = -.4f;
        }
        

        rigidbody.AddForce(x * 20, y * 20, z * 20);
    }

    


    
}
