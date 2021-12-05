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
        // オブジェクト情報
        Debug.Log(gameObject.name);
        // カメラコンポーネント取得
        Camera camera = gameObject.GetComponent<Camera>();
        // 任意のオブジェクト
        Debug.Log(cube.name);
        // 任意のコンポーネント
        Debug.Log(lightComponent.color);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update中");
        // キー情報取得
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);
    }
}
