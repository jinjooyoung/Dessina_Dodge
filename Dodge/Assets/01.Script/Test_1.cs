using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test_1 : MonoBehaviour
{
    //������ �����ϴ� ����� Ÿ�԰� �������� �����ϰ� �����ݷ��� �ٿ��ش�.

    public int test_int;   //������ �Ҵ��� �� intŸ������ ������ �����ϴ�.
    public float test_float;       //������ ���������� �Ҽ��� ���� ������ �� float Ÿ���� ������ �����ϴ�.
    public string test_string;     //���ڿ��� �Ҵ����� �� stringŸ���� ������ �������ش�.
    public bool test_bool;     //true�� false�� ��. ��, ���� ������ ���� �Ҵ��� �� boolŸ���� ������ �������ش�.

    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/


    public int test_bool1;
    public int test_bool2;

    public bool test_while;

    public int[] test_arrary_int = new int[2];           //intŸ���� �迭 ���� ���� ��� //�� ���¸����δ� ������ 0ĭ�̶� ���� ������ �������
    //���� ���� ���� �ڿ�  = new int[2];�� ���̸� 2ĭ�� ������ 0���� ������ä�� ������Ʈ�� �����ȴ�

    private void Start()
    {
        //�Ʒ� �Լ��� int i = 0���� �����ؼ� i < 10 �� ������ i++ �ϳ��� �����ϴ� �Լ�
        //i�� ������ public int i �� ���� ������ �� �ߴµ� ��� �����Ѱ���? - for���̶�
        //for���� �ݺ��ϴ� �Լ�? �ΰ���? - ����
        //bool ������ ���� ���ذ� �� ��... - true �ƴϸ� false �ΰ��� �ϳ��� ���� �����

        /*for (int i = 0; i < 10; i++)    
        
        {
            Debug.Log(i);
        }*/

        //test_method(test_int2, test_int3);
        //test_int4 = test_method2(test_int2, test_int3);
        //test_arrary_int[0] = 1;             //�迭 0��° �ε����� 1�� ���� �Ҵ�
        //test_int = test_arrary_int[0];      //�迭 0��° �ε����� �ִ� 1�� ���� test_int�� �Ҵ�
    }

    private void Update()
    {
        /*if (test_bool)  //boolŸ�� ���� ����� ����
        {
            Debug.Log("��");
        }
        else
        {
            Debug.Log("����");
        }
        //������Ʈ�� üũ�ڽ��� �ִµ� üũ�� �Ǿ������� ��, �� �Ǿ� ������ �����̶� �α�â�� ���� ������ ��µȴ�.

        //while���� ��ȣ �ȿ� �ִ� ���� ������ �� �������� �ݺ��� �Ѵ�.
        while (test_bool1 < 10)
        {
            test_bool1++;
        }*/

        //�� ������ ����
        //a > b a�� b���� ũ��.
        //a < b a�� b���� �۴�.
        //a == b a�� b�� ����.
        //a <= b a�� b�� ���ų� �۴�.
        //a >= b a�� b�� ���ų� ũ��.
        //a != b a�� b�� �ٸ���.

        //�������� ����
        // && �׸��� �� ����.
        // || �Ǵ� �� ����.
        // ! �ƴϴ� �� ����.

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (test_bool1 > test_bool2)    //(test_bool1 > test_bool2)�� ���϶� ���� �αװ� ��µ�.
            {
                Debug.Log("if�� ���� (���̴�.)");
            }
            else if (test_bool1 == test_bool2)      //(test_bool1 > test_bool2)�� �ƴϸ鼭 (test_bool1 == test_bool2)�� �� 
            {
                Debug.Log("else if�� ���� (���̴�.)");
            }
            else        //���� ���ǹ��� ��� �ش��� ���� ���� �� ���� �αװ� ��µ�
            {
                Debug.Log("else�� ���� (��� �����̴�.)");
            }
        }*/
    }

    //Ctrl + X �� �� �� �߶󳻱� (�巡���ؼ� ��ü�� �߶󳻱� �� ���� ����
    //Ctrl + Shift + / �ϸ� ��ü�� �ּ�ó�� �� �� ����
    //(�Ǵ� Ctrl + K + Ctrl + C) �����Ϸ��� (Ctrl + K + Ctrl + U)

    /*void test_method(int a, int b)  //return�� �� ���ִ� �Լ�. �Լ��� ���� void�� �������ش�.
    {
        Debug.Log(a + b);
    }

    int test_method2(int a, int b)  //return�� ���ִ� �Լ�. ������ ��ȯ�Ǵ� ���� Ÿ���� �������ش�.
    {
        return a + b;
    }*/
}
