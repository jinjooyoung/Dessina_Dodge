using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test_1 : MonoBehaviour
{
    //변수를 선언하는 방법은 타입과 변수명을 선언하고 세미콜론을 붙여준다.

    public int test_int;   //정수를 할당할 때 int타입으로 변수를 선언하다.
    public float test_float;       //정수도 가능하지만 소수의 값을 저장할 때 float 타입의 변수를 선언하다.
    public string test_string;     //문자열을 할당해줄 때 string타입의 변수를 선언해준다.
    public bool test_bool;     //true와 false의 값. 즉, 참과 거짓의 값을 할당할 때 bool타입의 변수를 선언해준다.

    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/


    public int test_bool1;
    public int test_bool2;

    public bool test_while;

    public int[] test_arrary_int = new int[2];           //int타입의 배열 변수 선언 방법 //이 상태만으로는 변수가 0칸이라 따로 설정을 해줘야함
    //위의 변수 선언문 뒤에  = new int[2];를 붙이면 2칸의 변수가 0으로 설정된채로 컴포넌트가 생성된다

    private void Start()
    {
        //아래 함수는 int i = 0으로 시작해서 i < 10 일 때까지 i++ 하나씩 증가하는 함수
        //i를 위에서 public int i 로 변수 설정을 안 했는데 어떻게 가능한건지? - for문이라서
        //for문은 반복하는 함수? 인건지? - 맞음
        //bool 변수가 뭔지 이해가 안 감... - true 아니면 false 두개중 하나로 값이 저장됨

        /*for (int i = 0; i < 10; i++)    
        
        {
            Debug.Log(i);
        }*/

        //test_method(test_int2, test_int3);
        //test_int4 = test_method2(test_int2, test_int3);
        //test_arrary_int[0] = 1;             //배열 0번째 인덱스에 1의 값을 할당
        //test_int = test_arrary_int[0];      //배열 0번째 인덱스에 있는 1의 값을 test_int에 할당
    }

    private void Update()
    {
        /*if (test_bool)  //bool타입 변수 사용방법 예시
        {
            Debug.Log("참");
        }
        else
        {
            Debug.Log("거짓");
        }
        //컴포넌트에 체크박스가 있는데 체크가 되어있으면 참, 안 되어 있으면 거짓이라서 로그창에 참과 거짓이 출력된다.

        //while문은 괄호 안에 있는 값이 만족을 할 때까지만 반복을 한다.
        while (test_bool1 < 10)
        {
            test_bool1++;
        }*/

        //비교 연산자 종류
        //a > b a는 b보다 크다.
        //a < b a는 b보다 작다.
        //a == b a는 b와 같다.
        //a <= b a는 b와 같거나 작다.
        //a >= b a는 b와 같거나 크다.
        //a != b a와 b는 다르다.

        //논리연산자 종류
        // && 그리고 를 뜻함.
        // || 또는 을 뜻함.
        // ! 아니다 를 뜻함.

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (test_bool1 > test_bool2)    //(test_bool1 > test_bool2)가 참일때 밑의 로그가 출력됨.
            {
                Debug.Log("if문 실행 (참이다.)");
            }
            else if (test_bool1 == test_bool2)      //(test_bool1 > test_bool2)가 아니면서 (test_bool1 == test_bool2)일 때 
            {
                Debug.Log("else if문 실행 (참이다.)");
            }
            else        //위의 조건문에 모두 해당이 되지 않을 때 밑의 로그가 출력됨
            {
                Debug.Log("else문 실행 (모두 거짓이다.)");
            }
        }*/
    }

    //Ctrl + X 는 그 줄 잘라내기 (드래그해서 전체를 잘라내기 할 수도 있음
    //Ctrl + Shift + / 하면 전체를 주석처리 할 수 있음
    //(또는 Ctrl + K + Ctrl + C) 해제하려면 (Ctrl + K + Ctrl + U)

    /*void test_method(int a, int b)  //return을 안 해주는 함수. 함수명 옆에 void로 선언해준다.
    {
        Debug.Log(a + b);
    }

    int test_method2(int a, int b)  //return을 해주는 함수. 옆에는 반환되는 값의 타입을 지정해준다.
    {
        return a + b;
    }*/
}
