using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public float cannonSpeed;
    public float ironSpeed;
    public float dartSpeed;
    public float bombSpeed;
    public Rigidbody cannonBall;
    public Rigidbody ironBall;
    public Rigidbody dart;
    public Rigidbody bomb;
    public Transform where;
    int choice;


    // Use this for initialization
    void Start()
    {
        choice = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("1"))
        {
            choice = 1;
        }
        else if (Input.GetKey("2"))
        {
            choice = 2;
        }
        else if (Input.GetKey("3"))
        {
            choice = 3;
        }
        else if (Input.GetKey("4"))
        {
            choice = 4;
        }

        if (Input.GetButtonDown("Fire1") && choice == 2)
        {
            Rigidbody ironInstance;
            ironInstance = Instantiate(ironBall, where.position, where.rotation) as Rigidbody;
            ironInstance.AddForce(where.forward * ironSpeed * 500);
        }

        if (Input.GetButtonDown("Fire1") && choice == 1)
        {
            Rigidbody cannonInstance;
            cannonInstance = Instantiate(cannonBall, where.position, where.rotation) as Rigidbody;
            cannonInstance.AddForce(where.forward * cannonSpeed * 500);
        }

        if (Input.GetButtonDown("Fire1") && choice == 3)
        {
            Rigidbody dartThing;
            dartThing = Instantiate(dart, where.position, where.rotation) as Rigidbody;
            dartThing.AddForce(where.forward * dartSpeed * 500);
        }

        if (Input.GetButtonDown("Fire1") && choice == 4)
        {
            Rigidbody bomby;
            bomby = Instantiate(bomb, where.position, where.rotation) as Rigidbody;
            bomby.AddForce(where.forward * bombSpeed * 300);
            bomby.AddForce(where.up * bombSpeed * 100);
        }


        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(gameObject.scene.buildIndex);
        }
    }
}
