using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFunction : MonoBehaviour
{
    public GameObject cube;

    public Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {
        // �I�u�W�F�N�g���
        Debug.Log(gameObject.name);
        // �J�����R���|�[�l���g�擾
        Camera camera = gameObject.GetComponent<Camera>();
        // �C�ӂ̃I�u�W�F�N�g
        Debug.Log(cube.name);
        // �C�ӂ̃R���|�[�l���g
        Debug.Log(lightComponent.color);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update��");
        // �L�[���擾
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);
    }
}
