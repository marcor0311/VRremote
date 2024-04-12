using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) {
 
        if (collision.relativeVelocity.magnitude > 1)
            GetComponent<AudioSource>().Play();
       
        Debug.Log(collision.collider.name);
    }
}
