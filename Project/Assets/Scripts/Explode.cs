using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    //public Transform explodePos;
    public Rigidbody myRb;
    public float power;
    bool ned;

    void Awake()
    {
        //myRb = GetComponent<Rigidbody>();
    }

    void Start () {

    }

	void Update () {

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, 100);
        foreach (Collider hit in colliders)
        {
            if (hit.gameObject.CompareTag("Ground")) {continue;}

            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (ned)
            {
                ned = false;
                rb.AddExplosionForce(power, explosionPos, 100f, 3f);
                Destroy(gameObject, .06f);
            }
         }
    }

    void OnCollisionEnter(Collision collision)
    {
        ned = true;
    }
}
