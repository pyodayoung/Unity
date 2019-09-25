using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using My.Asset; // Asset 사용
using Game; // Game 사용

public class NamespaceUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // using 사용할 경우  namespace 이름 생략 가능
        Util util = new Util();

        // 같은 클래스명을 가진 namespace가 using될 경우 참조의 모호성이 
        // 발생할 수있으므로 이때는 네임스페이스명을 같이 사용해 줌
        // Animation ani= new Animation(); //모호함
        My.Asset.Animation ani = new My.Asset.Animation(); // 모호하지 않음
    }

    // Update is called once per frame
    void Update()
    {
    }
}
