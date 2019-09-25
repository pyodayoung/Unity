using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Player는 Character 명세를 물려 받음(상속 받음)

public class CPlayer : CCharacter
{
    public int _level;
    public int _gravity;
    public string _talkMessage;


    // [오버라이드] 
    // - 기반 클래스에서 상속 받은 메소드를 파생 클래스에서 재정의 해서 사용하는 것은
    // 메소드 오버라이드라고 한다. 

    // override : 현재 클래스가 상속한 클래스의 같은 이름을 가지고
    // virtual 키워드가 붙은 메소드는를 확장한 메소드를 의미함
    // (확장 메소드안에서 부모의 메소드를 접근할때 base 참조 키워드를 사용함)



    public override void Move()
    {
        Jump(); // 현재 자식 클래스의 Jump 메소드를 실행함
        base.Move();  // 현재 클래스의 Move메소드가 아닌 부모의 Move 메소드가 실행됨
    }

    public void Talk()
    {
        Debug.Log(_name + "대화내용 : " + _talkMessage);
    }


    public void Jump()
    {
        Debug.Log(_name + " 님이 점프를 수행합니다.");
    }


    // Start is called before the first frame update
    void Start()
    {
        Talk();
        Move();
        Jump();
        Hit();
        Die();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
