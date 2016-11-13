using UnityEngine;
using System.Collections;

public class wordChanger2 : MonoBehaviour
{

    // Use this for initialization
    string[] words = new string[4];

    // Use this for initialization
    void Start()
    {
        string[] words = new string[] { "Hello", "Car", "Dog", "Apple" };
        GetComponent<TextMesh>().text = words[3];

    }

    // Update is called once per frame
    void Update()
    {

    }
}
