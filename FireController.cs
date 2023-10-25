using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public float speed; //���ư��� �ӵ�
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
        transform.Translate(transform.right * -1 * speed * Time.deltaTime); //������ �ӵ��� ���缭 ���ư��� ���� ����
        if (transform.position.x < -10.0f) // Ư�� ���� ������ ����
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position; 
        Vector2 p2 = this.Fire.transform.position; 
        Vector2 dir = p1 - p2; 

        float d = dir.magnitude;
        float r1 = 0.1f;//�÷��̾��� ��ġ
        float r2 = 0.5f;//����ü�� ��ġ

        if (d<r1+r2)// �� ��ü�� �Ÿ��� ����� ��������� UIController������ ü�� ���� ������ ���� ����ü�� ����
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }
    }

}
