using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour {
    private Rigidbody rigidBody;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.I)) {
            rigidBody.position += new Vector3(0f, 0f, 1f) * (speed / 10) * Time.fixedDeltaTime;
        } else if (Input.GetKey(KeyCode.K)) {
            rigidBody.position += new Vector3(0f, 0f, -1f) * (speed / 10) * Time.fixedDeltaTime;
        } else if (Input.GetKey(KeyCode.J)) {
            rigidBody.position += new Vector3(-1f, 0f, 0f) * (speed / 10) * Time.fixedDeltaTime;
        } else if (Input.GetKey(KeyCode.L)) {
            rigidBody.position += new Vector3(1f, 0f, 0f) * (speed / 10) * Time.fixedDeltaTime;
        }
    }
}
