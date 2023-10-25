using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public float speed; //날아가는 속도
    GameObject Fire;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("DestroyF", 2f);
        this.Fire = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * -1 * speed * Time.deltaTime); //설정한 속도에 맞춰서 날아가는 방향 설정
        if (transform.position.x < -10.0f) // 특정 지점 지날시 삭제
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position; 
        Vector2 p2 = this.Fire.transform.position; 
        Vector2 dir = p1 - p2; 

        float d = dir.magnitude;
        float r1 = 0.1f;//플레이어의 위치
        float r2 = 0.5f;//투사체의 위치

        if (d<r1+r2)// 두 개체의 거리를 계산해 가까워질시 UIController쪽으로 체력 감소 보내고 맞은 투사체는 삭제
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }
    }

}
