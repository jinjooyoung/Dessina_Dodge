using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Rigidbody player_rigidbody;
    public float speed = 8f;
    int test;       //그럼 이것처럼 앞에 퍼블릭 같은게 없는거는 뭐지?

    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 RigidBody 컴포넌트를 찾아 player_rigidbody에 할당
        player_rigidbody = GetComponent<Rigidbody>();

        //Debug.Log("안녕하세요.");
    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //리지드바디의 속도에 newVelocity 할당
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
