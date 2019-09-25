using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COutRef : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int value1 = 10;
        int value2 = 20;

        Debug.Log("[교체전] value1 :" + value1);
        Debug.Log("[교체전] value2 :" + value2);


        // 두숫자의 값을 서로 바꿔서 출력하세요 (swap)

 
        /*
        int temp = value1;
        value1 = value2;
        value2 = temp;
        */

        // Swap(value1, value2);

        // ref 키워드 : 참조형이 아닌 변수들을 참조형 매개변수로 넘기고 싶을 때 사용
        // [ref 사용]
        // 함수 호출 : 함수명 (ref 비참조형변수);
        // 함수 정의 : void 함수명 (ref 비참조형매개 변수) (... 사용할때는 ref 제외)
        // 특징 : ref 매개변수로 넘기는 비참조형변수는 반드시 값이 초기화 되어야함


        RefSwap(ref value1, ref value2);

        Debug.Log("[교체후] value1 :" + value1);
        Debug.Log("[교체후] value2 :" + value2);

    }

    void Swap(int value1, int value2)
    {
        int temp = value1;
        value1 = value2;
        value2 = temp;
    }


    void RefSwap(ref int value1, ref int value2)
    {
        int temp = value1;
        value1 = value2;
        value2 = temp;
    }
       
}
