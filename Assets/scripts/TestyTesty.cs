using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestyTesty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        foreach (var i in list)
        {
            Debug.Log(i);
        }
        Debug.Log("hit666");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
