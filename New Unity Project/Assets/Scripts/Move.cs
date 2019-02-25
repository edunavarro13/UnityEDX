using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    // Version 1.0 -> en la que la bola se mueve, no se empuja con rigidbody
    //public float speed;
    public float forceValue;
    public float jumpValue;
    private Rigidbody rigidbody;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        // Version 1.0 -> en la que la bola se mueve, no se empuja con rigidbody
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 
        //    0,
        //    Input.GetAxis("Vertical") * speed * Time.deltaTime);

        // Input.GetButton Se ha de mantener pulsado para dar true
        // Input.GetButtonDown se ha de pulsar para dar true
        // Jump es espacio en el ordenador
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.01f)
        {
            rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            audio.Play();
        }
        // Para que la bola salte cuando pulsemos en la pantalla del movil
        if (Input.touchCount == 1)
        {
            if (Input.touches[0].phase == TouchPhase.Began && Mathf.Abs(rigidbody.velocity.y) < 0.01f)
            {
                rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
                audio.Play();
            }
        }
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")) * forceValue);

        // Para que la bola se mueva cuando se mueva el movil
        rigidbody.AddForce(new Vector3(Input.acceleration.x,
           0,
           Input.acceleration.y) * forceValue);
    }
}
