using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    int variable = 30;
    const string CONST_VARIABLE = "XXXXX";
    string[] arrays = { "aaa", "bbb", "ccc" };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"こんにちは{variable}");
        Debug.Log(variable);
        Debug.Log(Hello("佐藤"));

        foreach(string a in arrays)
        {
            Debug.Log(a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Hello(string name)
    {
        return $"こんにちは {name}さん";
    }
}
