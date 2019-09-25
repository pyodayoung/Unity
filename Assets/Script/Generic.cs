using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// [제네릭]
// 데이타의 종류는 다르지만 취급 방법은 클래스를 구현하는 문법으로
// 임시 데이타를 만들고 해당 객체를 생성할때 데이타의 타입을 정해주는 문법

// [제레릭 클래스 선언]
// public class 클래스명 <임시타입>
// {
//    구현코드를
//    임시타입 취급데이타변수;
//    ...
// }

// [제네릭 객체 생성]
// 클래스명<지정타입> 객체변수명 = new 클래스명 <지정타입>();



public class CStack<T>
{
    int emptyStack; //빈스택 인덱스
    T[] items; // int 아이템 배열
    int top; // 현재 스택 커서(번호)
    int size; // 스택 크기(아이템 저장 갯수)

    // 스택 객체 생성자

    public CStack(int size)
    {
        this.size = size;
        items = new T[size];
        emptyStack = -1;
        top = emptyStack;
    }

    public void Push(T item)
    {
        items[++top] = item;
    }

    public T Pop()
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
public class Generic : MonoBehaviour
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
    }

    public class NoneGenericStackMain : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 제네틱 사용하지 않았을때 스택을 사용하는 코드

            int size = 5;
            CStack<int> istack = new CStack<int>(size);


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




            CStack<float> fstack = new CStack<float>(size);

            for (int i = 0; i < 7; i++)
            {
                if (!fstack.IsFull())
                {
                    fstack.Push(i * 1.2f);
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




            CStack<string> sstack = new CStack<string>(size);

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
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
