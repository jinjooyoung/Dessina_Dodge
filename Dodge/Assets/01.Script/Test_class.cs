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
        /*junhee = new Human();       //HumanŸ���� ��ü�� �������� (�ν��Ͻ�ȭ)
        junhee.age = 25;            //����� ���̸� ������
        junhee.name = "����";       //����� �̸��� ������ //�������� �ߴ� ������ �Ʒ��� �޸� Ŭ�������� public�� �ƴ� private�� ����߱� ����
        junhee.test_protected = "����";       //�������� �ߴ� ������ �Ʒ��� �޸� Ŭ�������� protected�� ���������
                                            //�� Ŭ���������� Human Ŭ������ ��ӹ��� �ʾұ� ����
        Debug.Log("�̸� : " + junhee.name + ", ���� : " + junhee.age);
        junhee_1 = junhee;
        Debug.Log("�̸� : " + junhee_1.name + ", ���� : " + junhee_1.age);
        junhee_1.age = 15;                      //junhee_1�� age(����)�� 15�� �ٲ���
        Debug.Log("���� : " + junhee.age);      //Ŭ������ ����Ÿ���̶� junhee_1�� ���̸� �ٲٸ� junhee���� �ȿ� �ִ� ���� ���� �ٲ�
        Debug.Log("���� : " + junhee_1.age);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Human
{
    //public string name;
    private string name;        //public ���� private�� �����ϴ� ���� �ִ� Test_class Ŭ�������� ������ ����
    public int age;
    protected string test_protected;
    //Ŭ������ ����� ������ ��������? �׳� �⺻ Ŭ���� �� ���� ���� ������ ���ִ°Ͱ� ���� �ٸ�����

    void Test_method()
    {
        /*name = "�̸�";
        age = 25;*/
    }
}

public class Test_Human2 : Human
{
    void Test_method()
    {
        //test_protected = "�׽�Ʈ�� ���ڿ�";        //protected�� ������ �Ǿ��־ �ܺο��� ���� �Ұ��� ������ ��ӹ��� Ŭ���������� ���ٰ���
    }
}

//public Ŭ������ �ܺο����� ������ ���� (���� ������)
//private Ŭ������ ���ο����� ������ ���� (���� �����)
//protected Ŭ������ �ܺο��� ������ �Ұ��� ������ ��ӹ��� Ŭ���������� ������ �����ϴ� (�߰�)
//�߰�ȣ�� ��������� �θ���