using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner : MonoBehaviour
{
    public GameObject bullet_prefab;        //생성할 탄알의 원본 프리팹
    public float spawn_rate_min = 0.5f;     //최소 생성 주기
    public float spawn_rate_max = 3f;       //최대 생성 주기

    Transform target;             //발사할 대상
    float spawn_rate;             //생성 주기
    float time_after_spawn;   //최근 생성 시점에서 지난 시간

    // Start is called before the first frame update
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0으로 초기화
        time_after_spawn = 0;
        //탄알 생성 간격을 spawn_rate_min과 spawn_rate_max 사이에서 랜덤 지정
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);                      //변수에 (최솟값, 최댓값) 사이의 랜덤한 값을 저장
        //Player_controller 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 설정
        target = FindObjectOfType<Player_controller>().transform;                                   //모든 오브젝트를 검사하기 때문에 업데이트에 넣으면 렉이 엄청나게 발생
        //가져오고 싶은 오브젝트 타입이 여러개라면
        //FindObjectsOfType<Player_controller>().transform;     (Object뒤에 s)

        //이게 Player_controller 컴포넌트를 가진 오브젝트를 찾는 매서드인가?
        //그러면 if문으로 player 태그를 가진 얘를 지정하는거랑 차이점이 뭐지
        //둘다 가져오는건 맞음 근데 if문은 부딪혔을때만 값을 읽는것이라 약간 다름
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn 갱신
        time_after_spawn += Time.deltaTime;

        //최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (time_after_spawn >= spawn_rate)
        {
            //누적된 시간을 리셋
            time_after_spawn = 0;

            //bullet_prefab의 복제본을
            //transform.position 위치와 transform.rotation 회전으로 생성
            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);       
            //프리팹의 복사본을 생성하는 것...뒤에 두개는 복사될 위치를 지정하는 것. 이 스크립트를 갖고 있는 오브젝트의 포지션, 로테이션 값에서 복사됨
            //프리팹이랑 복붙이랑 차이점은 뭐지? 프리팹화 시켜서 가져온 것은 프리팹 원본을 수정하면 수정사항이 같이 적용되나?
            //프리팹 복사본에서 수정사항이 생기면 overrides에서 apply 하면 프리팹 원본에 적용됨
            //생성된 bullet 게임 오브젝트의 정면 방향이 target을 향하도록 회전
            bullet.transform.LookAt(target);        //z축(오브젝트의 정면)이 타겟오브젝트를 향하도록 함

            //다음번 생성 간격을 spawn_rate_min, spawn_rate_max 사이에서 랜덤 지정
            spawn_rate = Random.Range(spawn_rate, spawn_rate_max);
        }
    }
}
