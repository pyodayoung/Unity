using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 네임스페이스 : 같은 이름을 가진 클래스를 목적에 맞게 구분해줄때 사용

namespace My.Asset
{
    public class Character //Asset.Animation
    {
        public string type;
        public string uploadDate;
        public int price;
    }

    public class Util
    {
        public string name;
        public int price;
    }
    public class Animation
    {
        public float time;
    }
}

namespace  Game
{
    public class Character
    {
        public string name;
        public string level;
    }
}

public class NameSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Asset.Character 객체 생성
        My.Asset.Character assetCharacter= new My.Asset.Character();

        // Game.Animation t생성
        Game.Character gameCharacter = new Game.Character();
    }
}
