using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SendText(string str)
    {
        if (str == null)
        {
            GetComponent<Text>().text = "";
        } else
        {
            GetComponent<Text>().text = str;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
