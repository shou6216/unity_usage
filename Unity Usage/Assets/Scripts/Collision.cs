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
        // �Փ˂����I�u�W�F�N�g�̏���\��
        Debug.Log($"{collision.gameObject.name}�ƂԂ�����");
    }

    void OnTriggerEnter(Collider other)
    {
        // ���������I�u�W�F�N�g�̏���\��
        Debug.Log($"{other.gameObject.name}�Ƃ�������");
    }
}
