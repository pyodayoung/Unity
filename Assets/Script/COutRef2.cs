using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class COutRef2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int value1, value2;

        // value1, value2에 각각 10, 20을 저장하는 Ref 함수를 만들어 보세요.
        // 함수명 : InputRef(...)

        // ref 키워드는 value1, value2의 값을 초기화 하지 않으면 에러발생
        // InputRef(ref value1, ref value2);
        
        // out 키워드 : ref 키워드를 같은 목적으로 사용됨
        // [ref 사용]
        // 함수 호출 : 함수명 (ref 비참조형변수);
        // 함수 정의 : void 함수명 (out 비참조형매개 변수) (... 사용할때는 ref 제외...)
        // 특징 : out 매개변수로 넘기는 비참조형변수는 반드시 값이 초기화 되어야함
        InputOut(out value1, out value2);

        Debug.Log("value1 + :" + value1 + "value2 :" + value2);
    }

    void InputOut(out int value1, out int value2)
    {
        value1 = 10;
        value2 = 20;
    }

    void InputRef(ref int value1, ref int value2)
    {
        value1 = 10;
        value2 = 20;
    }
}
