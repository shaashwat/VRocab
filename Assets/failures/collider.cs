using UnityEngine;
using System.Collections;

public class collider : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Asteroid")
        {
            Destroy(col.gameObject);
        }
}
}
