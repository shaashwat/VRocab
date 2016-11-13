using UnityEngine;
using System.Collections;


public class Colliider : MonoBehaviour
{

void Start () {
    Debug.Log("collision detected");
}

void Update() {
}

void OnTriggerEnter (Collider other)
    {

       
            Destroy(other.gameObject);
	    
}
}
