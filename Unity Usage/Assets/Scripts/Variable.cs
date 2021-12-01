using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    int variable = 30;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Ç±ÇÒÇ…ÇøÇÕ{variable}");
        Debug.Log(variable);
        Debug.Log(Hello("ç≤ì°"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Hello(string name)
    {
        return $"Ç±ÇÒÇ…ÇøÇÕ {name}Ç≥ÇÒ";
    }
}
