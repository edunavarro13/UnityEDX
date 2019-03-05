using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public float impulseForce = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Impulsa el cubo hacia arriba
        GetComponent<Rigidbody>().AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // Si cae por debajo de la posicion y < 0 se destruye
        if(transform.position.y < 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
