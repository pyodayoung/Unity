using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //[생성자]
    // - 객체를 생성할때 초기화할 수 있는 기능을 제공하는 특별한 메소드

    // [생성자 특징]
    // 1. 클래스명과 동일함
    // 2. 반환형을 지정하지 않음 
    // 3. 객체 생성 시 자동으로 호출됨 
    // 4. 객체 초기화는 속성 초기화를 의미함
    // 5. 생성자도 메소드이므로 오버로딩 할 수 있다.
    // 6. 생성자는 객체 생성 후 인위적(별도로) 호출할 수없다.

  
    // [생성자 선언]
    // public class 클래스명{
    //     public 클래스명(매게변수...) {
    //        초기화 코드들
    //     }
    //   }

    // [생성자 호출]
    // 클래스명 객체변수 = new 클래스명(매개변수);

    
    // 스택 클래스
public class CStackInt
{
    int emptyStack; //빈스택 인덱스
    int[] items; // int 아이템 배열
    int top; // 현재 스택 커서(번호)
    int size; // 스택 크기(아이템 저장 갯수)

    // 스택 객체 생성자

    public CStackInt(int size)
    {
        this.size = size;
        items = new int[size];
        emptyStack = -1; 
        top = emptyStack;
    }

    public void Push(int item)
    {
        items[++top] = item;
    }

    public int Pop()
    {
        return items[top--];
    }

    public bool IsFull()
    {
        return (top + 1) == size;
    }

    public bool IsEmpty()
    {
        return top == emptyStack;
    }
}



public class CStackFloat
{
    int emptyStack; //빈스택 인덱스
    float[] items; // int 아이템 배열
    int top; // 현재 스택 커서(번호)
    int size; // 스택 크기(아이템 저장 갯수)

    // 스택 객체 생성자

    public CStackFloat(int size)
    {
        this.size = size;
        items = new float[size];
        emptyStack = -1;
        top = emptyStack;
    }

    public void Push(float item)
    {
        items[++top] = item;
    }

    public float Pop()
    {
        return items[top--];
    }

    public bool IsFull()
    {
        return (top + 1) == size;
    }

    public bool IsEmpty()
    {
        return top == emptyStack;
    }
}

public class CStackString
{
    int emptyStack; // 빈스택 인덱스
    string[] items; // int 아이템 배열
    int top; // 현재 스택 커서(번호)
    int size; // 스택 크기(아이템 저장 갯수)

    // 스택 객체 생성자
    public CStackString(int size)
    {
        this.size = size;
        items = new string[size];
        emptyStack = -1;
        top = emptyStack;
    }

    public void Push(string item)
    {
        items[++top] = item;
    }

    public string Pop()
    {
        return items[top--];
    }

    public bool IsFull()
    {
        return (top + 1) == size;
    }

    public bool IsEmpty()
    {
        return top == emptyStack;
    }
}








public class NoneGenericStackMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 제네틱 사용하지 않았을때 스택을 사용하는 코드

        int size = 5;
        CStackInt istack = new CStackInt(size);


        for (int i = 0; i < 7; i++)
        {
            if (!istack.IsFull())
            {
                istack.Push(i);
            }
            else
            {
                Debug.Log("스택이 꽉 찼습니다. [저장 실패 : " + i + "]");
            }
        }

        while (!istack.IsEmpty())
        {
            Debug.Log(istack.Pop());
        }




        CStackFloat fstack = new CStackFloat(size);

        for (int i = 0; i < 7; i++)
        {
            if (!fstack.IsFull())
            {
                fstack.Push(i*1.2f);
            }
            else
            {
                Debug.Log("스택이 꽉 찼습니다. [저장 실패 : " + i + "]");
            }
        }

        while (!fstack.IsEmpty())
        {
            Debug.Log(fstack.Pop());
        }




        CStackString sstack = new CStackString(size);

        for (int i = 0; i < 7; i++)
        {
            if (!sstack.IsFull())
            {
                sstack.Push(i + "번");
            }
            else
            {
                Debug.Log("스택이 꽉 찼습니다. [저장 실패 : " + i + "]");
            }
        }

        while (!sstack.IsEmpty())
        {
            Debug.Log(sstack.Pop());
        }
    }





    // Update is called once per frame
    void Update()
    {

    }
}