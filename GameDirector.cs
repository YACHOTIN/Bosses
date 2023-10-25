using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpImage; // 이미지를 직접 선언합니다.

    // Start is called before the first frame update
    void Start()
    {
        // 이미지를 연결된 GameObject에서 찾아 할당합니다.
        hpImage = GameObject.Find("hpGauge").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecreaseHp()
    {
        // 이미지의 fillAmount를 감소시킵니다.
        hpImage.fillAmount -= 0.25f;
    }
}

