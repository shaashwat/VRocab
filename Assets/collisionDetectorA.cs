using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class collisionDetectorA : MonoBehaviour {
    void Start()
    {
        Debug.Log("start");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered trigger!");

        Destroy(other.gameObject);

	SceneManager.LoadScene("Level 2");
        
    }
}
