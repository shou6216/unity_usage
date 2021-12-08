using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        // 衝突したオブジェクトの情報を表示
        Debug.Log($"{collision.gameObject.name}とぶつかった");
    }

    void OnTriggerEnter(Collider other)
    {
        // すれ違ったオブジェクトの情報を表示
        Debug.Log($"{other.gameObject.name}とすれ違った");
    }
}
