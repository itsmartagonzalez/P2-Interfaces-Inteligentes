using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    GameObject player;
    GameObject capsule;
    // Start is called before the first frame update
    void Start() {
        player  = GameObject.FindWithTag("Player");      
        capsule  = GameObject.FindWithTag("Capsule");      
    }

    // Update is called once per frame
    void Update() {
        float distanceWithPlayer = Vector3.Distance(player.GetComponent<Rigidbody>().position, transform.position);
        if (distanceWithPlayer < 4f) {
            transform.localScale = new Vector3(2, 2, 2);
        }
        float distanceWithCapsule = Vector3.Distance(capsule.GetComponent<Rigidbody>().position, transform.position);
        if (distanceWithCapsule < 4f) {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
