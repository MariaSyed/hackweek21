using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 randomVector = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
        GetComponent<Rigidbody2D>().AddForce(-collision.contacts[0].normal + randomVector);
    }
}
