using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    public float distance = 2f;
    private GameObject player;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        float physicalDistance = Vector3.Distance(player.GetComponent<Rigidbody>().position, transform.position) - 2.55f;
        if (physicalDistance <= distance) {
            Vector3 direction = new Vector3(transform.position.x - player.GetComponent<Rigidbody>().position.x, 0, transform.position.z - player.GetComponent<Rigidbody>().position.z);
            transform.Translate(direction * 3f * Time.deltaTime);
        }
    }
}
