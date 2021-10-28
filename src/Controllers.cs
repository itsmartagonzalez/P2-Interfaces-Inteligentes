using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllers : MonoBehaviour
{
    private Rigidbody rigidBody;
    private int puntuation = 0;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(rotation, 0.0f, translation) * (speed * 10) * Time.fixedDeltaTime;
        rigidBody.AddForce(dir);

        if (Input.GetKey(KeyCode.Q)) {
            rigidBody.AddTorque(transform.up * -1 * speed * 10 * Time.fixedDeltaTime);
        } else if (Input.GetKey(KeyCode.E)) {
            rigidBody.AddTorque(transform.up * 1 * speed * 10 * Time.fixedDeltaTime);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Cylinder") {
            Debug.Log("Puntuación del Jugador: " + (++puntuation));
            transform.localScale += new Vector3(1, 1, 1);
        } else if (collision.gameObject.tag == "A_Cylinder" && Input.GetKey(KeyCode.Space)) {
            Vector3 direction = new Vector3(collision.transform.position.x - rigidBody.position.x, 0, collision.transform.position.z - rigidBody.position.z);
            collision.transform.Translate(direction * 2f * Time.deltaTime);
        }
    }
}
