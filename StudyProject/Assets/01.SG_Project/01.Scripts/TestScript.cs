using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    void Start()
    {
        TestTwoScript testTwoScript = default;
        testTwoScript?.DebugTest();


        int a = 10;

        string b = a == 0? "°¡³ª´Ù" : "ABC";
        Debug.Log(b);

    }

    
    void Update()
    {
        
    }

}       // ClassEnd
