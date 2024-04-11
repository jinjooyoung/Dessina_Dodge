using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;               //UI���� ���̺귯��
using UnityEngine.SceneManagement;  //�� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameover_text;        //���� ������ Ȱ��ȭ �� �ؽ�Ʈ ���� ������Ʈ
    public Text time_text;
    public Text record_text;

    private float survive_time;         //���� �ð�
    bool is_gameover;                   //���ӿ��� ����

    // Start is called before the first frame update
    void Start()
    {
        //�����ð��� ���ӿ������� �ʱ�ȭ
        survive_time = 0;
        is_gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        //���ӿ����� �ƴ� ����
        if (!is_gameover)
        {
            //���� �ð� ����
            survive_time += Time.deltaTime;
            //������ ���� �ð��� time_text �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            time_text.text = "Time" + (int)survive_time;
        }
        else
        {
            //���� ������ ���¿��� R Ű�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                // Dodge �� �ε�
                SceneManager.LoadScene("Dodge_scene");
                //File > Build Setting �� ���� ���� �־���� �۵���
            }
        }
    }
    //���� ������ ���ӿ��� ���·� �����ϴ� �ż���
    public void EndGame()
    {
        //���� ���¸� ���ӿ��� ���·� ��ȯ
        is_gameover = true;
        //���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameover_text.SetActive(true);

        //Best_time Ű�� ����� ���������� �ְ� ��� ��������
        float best_time = PlayerPrefs.GetFloat("Best_Time");

        //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if(survive_time > best_time)
        {
            //�ְ� ��� ���� ���� ���� �ð� ������ ����
            best_time = survive_time;
            //����� �ְ� ����� Best_time Ű�� ����
            PlayerPrefs.SetFloat("Best_time", best_time);
        }
        //�ְ� ����� record_text �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        record_text.text = "Best Time : " + (int)best_time;
    }
}
