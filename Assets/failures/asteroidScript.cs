using UnityEngine;
using System.Collections;

public class asteroidScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        masterScript masterScript = GetComponent<masterScript>();
        Debug.Log(masterScript.words[1]);
        int index = Random.Range(0, masterScript.words.Length);
        string wordtodisplay = masterScript.words[index];
        string definitiontodisplay = masterScript.definitions[index];
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
