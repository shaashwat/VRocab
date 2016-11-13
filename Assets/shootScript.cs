using UnityEngine;
using System.Collections;

public class shootScript : MonoBehaviour {


    public static int speed = 0;
    public Transform gameObject;
    Transform initialposition;
    // Use this for initialization


    void Start () {

        initialposition = transform;
	transform.position = Camera.main.gameObject.transform.position; 
	speed = 0; 
	}
	
	// Update is called once per frame
	void Update () {

	
        if (Input.GetMouseButton(0))
        {
	    speed = 20;

        } else {
            transform.position += gameObject.forward * speed * Time.deltaTime; 
	}
	}
}
