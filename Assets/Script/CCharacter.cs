using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

    [상속]
    - 같은 성질을 가진 여러 클래스들의 공통적인 부분을 재사용하도록 하는 것 
    
    [상속의 특징]
    1. 공통된 성질을 가진 클래스를 부모(기반) 클래스라고 지칭함
    2. 공통된 성질을 물려 받는 클래스를 자식(파생) 클래스라고 지칭함
    3. 상속시 기반클래스의 생성자는 파생클래스에서 명시적을 호출해줘야 함

    [상속과 접근지정자]
    - protected; 상속 상의 클래스들간에만 공유 가능한 접근 지정자

    [상속 문법]
    publci class 기반 클래스 {
           protected  멤버들 (변수, 함수)
           public 멤버들 (변수, 함수)
           }

    public class 파생 클래스 : 기반 클래스 {
           protected 멤버들 (변수, 함수)
           }
   
 */

// Playter와 Monster와 Creature의 부모 클래스(기반 클래스)

public class CCharacter : MonoBehaviour
{
    //공통 성질(멤버 변수들)들
    public string _name;
    public int _hp;
    public int _damage;

   

    // virtual : 현재 클래스의 virtual 키워드가 붙은 메소드는 자식 클래스에서 확장
    // 할 수있는 메소드를 의미함 (확장 -> 덮어씀)


    //공통 메소드(멤버 함수들)들

    public virtual void Move()
    {
        Debug.Log(_name + "님이 이동을 합니다.");
    }


    public void Attack()
    {
        Debug.Log(_name + "님이" + _damage + "의 공격을 수행합니다.");
    }

    public void Hit()
    {
        Debug.Log(_name + " 님이 공격을 당해 피해를 입었습니다.");
    }

    public void Die()
    {
        Debug.Log(_name + "님이 사망하였습니다.");
        ;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
