using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttackController : MonoBehaviour
{
    public GameObject Fire;
    public Transform Pos;
    public float coolTime;
    private float curTime;
    private int result; //�߻� ���� Ȯ��
    private int projectilesFired = 0;//�߻��� ����ü ��
    private bool canFire = true; //�߻� ����
    private float reloadTime = 10.0f; //������ �ð�
    private bool isReloading = false;

    // Update is called once per frame
    void Update()
    {
        int py = Random.Range(-3, 3);//�߻� ��ġ�� ���� ���� y�� ����
        result = Random.Range(1, 3);//�߻� ������ ���� ������

        if (canFire && curTime <= 0)
        {
            if (result == 1)
            {
                Pos.transform.position = new Vector3(9, py, 0);
                Instantiate(Fire, Pos.position, transform.rotation);
                projectilesFired++;

                if (projectilesFired >= 30) //30�� �߻� ����
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

