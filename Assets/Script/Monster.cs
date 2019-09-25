using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // static 몬스터 생성 수 변수 생성
    private static int count = 0;

    public static void CountUp()
    {
        // hp는 static 변수가 아니므로 static 메소드에서 접근이 불가함
        // hp = 10;
         Monster.count++;
    }


    public static void PrintCount()
    {
        // static 메소드 접근
        // -> 클래스명.변수(속성) 또는 메소드 () 접근
        Debug.Log(Monster.count + "번재 몬스터 생성");
    }


    // Start is called before the first frame update

    void Awake()
    {
        //몬스터 카운트 증가
        Monster.CountUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

