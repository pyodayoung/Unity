using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCreature : CCharacter
{
    public int _time;


    public void Timer()
    {
        Debug.Log(_name + "님이" + _time + "뒤에 소멸합니다.");
    }

    // Start is called before the first frame update
    void Start()
    {
        //_hp = 100; //CCharacter 부모 클래스 속성이므로 접근 가능
        //Destroy(gameObject); //Object 부모 클래스 메소드이므로 접근 가능

        Move(); // CCharacter 부모 클래스 메소드이므로 접근 가능
        Attack();
        Hit();
        Timer();
        Die();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
