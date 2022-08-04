using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public bool DestroyAble = false;
    public float time;

	// Use this for initialization
	void Start () {
        if (DestroyAble)
        {
            Destroy(gameObject, time);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject, 0);
    }
}
