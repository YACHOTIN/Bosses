using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttackController : MonoBehaviour
{
    public GameObject Fire;
    public Transform Pos;
    public float coolTime;
    private float curTime;
    private int result; //발사 여부 확인
    private int projectilesFired = 0;//발사할 투사체 수
    private bool canFire = true; //발사 제한
    private float reloadTime = 10.0f; //딜레이 시간
    private bool isReloading = false;

    // Update is called once per frame
    void Update()
    {
        int py = Random.Range(-3, 3);//발사 위치를 위한 랜덤 y값 변수
        result = Random.Range(1, 3);//발사 간격을 위한 랜덤값

        if (canFire && curTime <= 0)
        {
            if (result == 1)
            {
                Pos.transform.position = new Vector3(9, py, 0);
                Instantiate(Fire, Pos.position, transform.rotation);
                projectilesFired++;

                if (projectilesFired >= 30) //30개 발사 제한
                {
                    canFire = false; 
                    StartCoroutine(Reload());
                }

                curTime = coolTime;
            }
        }
        curTime -= Time.deltaTime;
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        canFire = true;
        projectilesFired = 0;
    }
}

