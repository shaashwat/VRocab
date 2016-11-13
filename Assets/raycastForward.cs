using UnityEngine;
using System.Collections;

public class raycastForward : MonoBehaviour {

	// Update is called once per frame
	void Update () {

	RaycastHit hit;
	float theDistance;

	Vector3 forward = transform.TransformDirection(Vector3.forward)*10;
	Debug.DrawRay(transform.position, forward, Color.green);

	if (Physics.Raycast(transform.position, (forward), out hit))  
	{

		string name = hit.collider.gameObject.name;
		Debug.Log(name);
       		GetComponent<TextMesh>().text = name;

	
	
	}
}

}
