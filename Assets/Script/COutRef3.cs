using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Values
{
    public int value1;
    public int value2;
    public int value3;
    public int value4;
}

public class COutRef3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Values val; // 구조체 생성

        InputValues(out val); //다영 out으로 바뀌면 참조로 바뀜

        PrintValues(val);
        //PrintRefValues(ref val);
    }

    // val 구조체 전체가 매개변수에 복사됨
    void PrintValues(Values val)
    {
        Debug.Log("val1 :" + val.value1);
        Debug.Log("val2 :" + val.value2);
        Debug.Log("val3 :" + val.value3);
        Debug.Log("val4 :" + val.value4);
    }

    // val 구조체의 참조값만 매개변수에 복사됨(이득)
    void PrintRefValues(ref Values val)
    {
        Debug.Log("val1 :" + val.value1);
        Debug.Log("val2 :" + val.value2);
        Debug.Log("val3 :" + val.value3);
        Debug.Log("val4 :" + val.value4);
    }

    void InputValues(out Values val)
    {
        val.value1 = 10;
        val.value2 = 20;
        val.value3 = 30;
        val.value4 = 40;
    }
}
