using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpImage; // �̹����� ���� �����մϴ�.

    // Start is called before the first frame update
    void Start()
    {
        // �̹����� ����� GameObject���� ã�� �Ҵ��մϴ�.
        hpImage = GameObject.Find("hpGauge").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecreaseHp()
    {
        // �̹����� fillAmount�� ���ҽ�ŵ�ϴ�.
        hpImage.fillAmount -= 0.25f;
    }
}

