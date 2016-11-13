using UnityEngine;
using System.Collections;

public class ShootingB : MonoBehaviour {


    public static int speed = 0;
    public Transform gameObject;
    Transform initialposition;
    // Use this for initialization
    void Start () {

        initialposition = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Mouse X")<-.2)
        {
	    speed = 35;

        } else {
            transform.position += gameObject.forward * speed * Time.deltaTime; 
	}
	}
}
