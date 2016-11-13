using UnityEngine;
using System.Collections;

public class masterScript : MonoBehaviour {

    public string[] words = new string[4];
    public string[] definitions = new string[4];
    public ArrayList wordarray = new ArrayList();
    // Use this for initialization
    void Start () {
        string[] words = new string[] { "Hello", "Car", "Dog", "Apple" };
        string[] definitions = new string[4]{ "Hello", "Car", "Dog", "Apple" };
        

    }
    int i;
    int g;
	public string returnWord(int i)
    {
        return words[i];
    }
    public string returnWordArray(int g)
    {
        return wordarray.ToString();
    }
    // Update is called once per frame
    void Update () {
	
    
	}
}
