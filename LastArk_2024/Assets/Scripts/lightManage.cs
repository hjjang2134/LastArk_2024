using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class lightManage : MonoBehaviour
{
    // Start is called before the first frame update
    public Image windowLight;
    public Image directLight;
    public Image darkLight;
    public GameObject particle;

    void Start()
    {
        windowLight.enabled = true;
        directLight.enabled = true;
        darkLight.enabled = true;
        particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(UI.현침식도 <= 40)
        {
            windowLight.DOFade(0.1f, 4.0f);
            directLight.DOFade(0.14f, 4.0f);
            particle.SetActive(true);
            darkLight.enabled = false;
        }
        else if((UI.현침식도 > 40) &&(UI.현침식도 <= 60))
        {
            windowLight.DOFade(0f, 4.0f);
            directLight.DOFade(0f, 4.0f);
            particle.SetActive(false);
            darkLight.DOFade(0f, 4.0f);
        }
        else if((UI.현침식도 > 60) && (UI.현침식도 <= 80))
        {
            windowLight.DOFade(0f, 4.0f);
            directLight.DOFade(0f, 4.0f);
            particle.SetActive(false);
            darkLight.DOFade(0.5f, 4.0f);
        }
        else if ((UI.현침식도 > 80) && (UI.현침식도 <= 90))
        {
            windowLight.DOFade(0f, 4.0f);
            directLight.DOFade(0f, 4.0f);
            particle.SetActive(false);
            darkLight.DOFade(0.7f, 4.0f);
        }
        else
        {
            windowLight.DOFade(0f, 4.0f);
            directLight.DOFade(0f, 4.0f);
            particle.SetActive(false);
            darkLight.DOFade(0.8f, 4.0f);
        }
    }
}
