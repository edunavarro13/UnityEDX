using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    public GameObject stone;
    public GameObject capsule;
    public float fireRate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ThrowStone());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ThrowStone()
    {
        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            // Ejercicio propuesto 5.2: al azar a veces crea un cuadrado y a veces una capsula 
            if(Random.value > 0.5f)
            {
                Instantiate(stone, transform.position, Random.rotation);
            }
            else
            {
                Instantiate(capsule, transform.position, Random.rotation);
            }
            yield return new WaitForSeconds(fireRate);
        }
    }
}
