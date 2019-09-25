using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 플레이어가 생성되면서 현재 존재하는 몬스터의
        // 숫자를 파악하고 있음
        Monster.PrintCount();
    }

        // Update is called once per frame
    
    void Update()
    {
        
    }
}
