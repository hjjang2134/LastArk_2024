using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightManage : MonoBehaviour
{
    // Start is called before the first frame update
    public Image windowLight;
    public Image directLight;
    public Image darkLight;
    public GameObject particle;

    void Start()
    {
        windowLight.enabled = false;
        directLight.enabled = false;
        darkLight.enabled = false;
        particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(UI.��ħ�ĵ� <= 40)
        {
            windowLight.enabled = true;
            directLight.enabled = true;
            particle.SetActive(true);
            darkLight.enabled = false;
        }
        else if((UI.��ħ�ĵ� > 40) &&(UI.��ħ�ĵ� <= 60))
        {
            windowLight.enabled = false;
            directLight.enabled = false;
            particle.SetActive(false);
            darkLight.enabled = false;
        }
        else if((UI.��ħ�ĵ� > 60) && (UI.��ħ�ĵ� <= 80))
        {
            windowLight.enabled = false;
            directLight.enabled = false;
            particle.SetActive(false);
            darkLight.enabled = true;
        }
    }
}
