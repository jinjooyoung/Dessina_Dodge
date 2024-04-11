using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner : MonoBehaviour
{
    public GameObject bullet_prefab;        //������ ź���� ���� ������
    public float spawn_rate_min = 0.5f;     //�ּ� ���� �ֱ�
    public float spawn_rate_max = 3f;       //�ִ� ���� �ֱ�

    Transform target;             //�߻��� ���
    float spawn_rate;             //���� �ֱ�
    float time_after_spawn;   //�ֱ� ���� �������� ���� �ð�

    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        time_after_spawn = 0;
        //ź�� ���� ������ spawn_rate_min�� spawn_rate_max ���̿��� ���� ����
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);                      //������ (�ּڰ�, �ִ�) ������ ������ ���� ����
        //Player_controller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<Player_controller>().transform;                                   //��� ������Ʈ�� �˻��ϱ� ������ ������Ʈ�� ������ ���� ��û���� �߻�
        //�������� ���� ������Ʈ Ÿ���� ���������
        //FindObjectsOfType<Player_controller>().transform;     (Object�ڿ� s)

        //�̰� Player_controller ������Ʈ�� ���� ������Ʈ�� ã�� �ż����ΰ�?
        //�׷��� if������ player �±׸� ���� �긦 �����ϴ°Ŷ� �������� ����
        //�Ѵ� �������°� ���� �ٵ� if���� �ε��������� ���� �д°��̶� �ణ �ٸ�
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn ����
        time_after_spawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (time_after_spawn >= spawn_rate)
        {
            //������ �ð��� ����
            time_after_spawn = 0;

            //bullet_prefab�� ��������
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);       
            //�������� ���纻�� �����ϴ� ��...�ڿ� �ΰ��� ����� ��ġ�� �����ϴ� ��. �� ��ũ��Ʈ�� ���� �ִ� ������Ʈ�� ������, �����̼� ������ �����
            //�������̶� �����̶� �������� ����? ������ȭ ���Ѽ� ������ ���� ������ ������ �����ϸ� ���������� ���� ����ǳ�?
            //������ ���纻���� ���������� ����� overrides���� apply �ϸ� ������ ������ �����
            //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);        //z��(������Ʈ�� ����)�� Ÿ�ٿ�����Ʈ�� ���ϵ��� ��

            //������ ���� ������ spawn_rate_min, spawn_rate_max ���̿��� ���� ����
            spawn_rate = Random.Range(spawn_rate, spawn_rate_max);
        }
    }
}
