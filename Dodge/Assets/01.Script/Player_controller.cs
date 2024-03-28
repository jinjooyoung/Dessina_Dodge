using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Rigidbody player_rigidbody;
    public float speed = 8f;
    int test;       //�׷� �̰�ó�� �տ� �ۺ� ������ ���°Ŵ� ����?

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� RigidBody ������Ʈ�� ã�� player_rigidbody�� �Ҵ�
        player_rigidbody = GetComponent<Rigidbody>();

        //Debug.Log("�ȳ��ϼ���.");
    }

    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        player_rigidbody.velocity = newVelocity;



        /*if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            player_rigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            player_rigidbody.AddForce(0f, 0f, -speed);

        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            player_rigidbody.AddForce(-speed, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            player_rigidbody.AddForce(speed, 0f, 0f);

        }*/
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
