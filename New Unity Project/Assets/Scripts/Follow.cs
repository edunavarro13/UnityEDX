using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target; // La esfera
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // LateUpdate hara que primero se actualizara la esfera y luego la camara
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
