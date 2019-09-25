using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonster : CCharacter
{
    public int _skillType;


    public void Skill()
    {
        Debug.Log(_name + " 님이 " + _skillType + "번째 스킬을 발동합니다.");
    }


    // Start is called before the first frame update
    void Start()
    {
        Move();
        Attack();
        Hit();
        Skill();
        Die();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
