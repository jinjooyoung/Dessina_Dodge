using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_class : MonoBehaviour
{
    public Human junhee;
    public Human junhee_1;

    // Start is called before the first frame update
    void Start()
    {
        /*junhee = new Human();       //Human타입의 객체를 만들어줬다 (인스턴스화)
        junhee.age = 25;            //사람의 나이를 정해줌
        junhee.name = "준희";       //사람의 이름을 정해줌 //빨간줄이 뜨는 이유는 아래의 휴먼 클래스에서 public이 아닌 private를 사용했기 때문
        junhee.test_protected = "준희";       //빨간줄이 뜨는 이유는 아래의 휴먼 클래스에서 protected를 사용했지만
                                            //이 클래스에서는 Human 클래스를 상속받지 않았기 때문
        Debug.Log("이름 : " + junhee.name + ", 나이 : " + junhee.age);
        junhee_1 = junhee;
        Debug.Log("이름 : " + junhee_1.name + ", 나이 : " + junhee_1.age);
        junhee_1.age = 15;                      //junhee_1의 age(나이)를 15로 바꿔줌
        Debug.Log("나이 : " + junhee.age);      //클래스가 참조타입이라 junhee_1의 나이를 바꾸면 junhee변수 안에 있는 나이 값도 바뀜
        Debug.Log("나이 : " + junhee_1.age);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Human
{
    //public string name;
    private string name;        //public 에서 private로 변경하니 위에 있는 Test_class 클래스에서 접근을 못함
    public int age;
    protected string test_protected;
    //클래스를 만드는 이유가 무엇인지? 그냥 기본 클래스 맨 위에 변수 선언을 해주는것과 뭐가 다른거죠

    void Test_method()
    {
        /*name = "이름";
        age = 25;*/
    }
}

public class Test_Human2 : Human
{
    void Test_method()
    {
        //test_protected = "테스트용 문자열";        //protected로 선언이 되어있어서 외부에선 접근 불가능 하지만 상속받은 클래스에서는 접근가능
    }
}

//public 클래스는 외부에서도 접근이 가능 (가장 포괄적)
//private 클래스는 내부에서만 접근이 가능 (가장 폐쇄적)
//protected 클래스는 외부에서 접근이 불가능 하지만 상속받은 클래스에서는 접근이 가능하다 (중간)
//중괄호를 스코프라고 부른다