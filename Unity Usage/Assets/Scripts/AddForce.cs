using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.AddForce(1000, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
