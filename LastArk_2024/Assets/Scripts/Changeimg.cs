using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changeimg : MonoBehaviour
{
    public GameObject img1, img2, img3, img4, img5, img6, img7, img8, img9;

    public void Start()
    {
        img1.SetActive(true);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
        img7.SetActive(false);
        img8.SetActive(false);
        img9.SetActive(false);
    }
    public void Update()
    {
        if ((UI.��ħ�ĵ� >= 0) && (UI.��ħ�ĵ� <= 20))
        {
            img1.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }

        else if ((UI.��ħ�ĵ� >= 21) && (UI.��ħ�ĵ� <= 30))
        {
            img2.SetActive(true);
            img1.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }

        else if ((UI.��ħ�ĵ� >= 31) && (UI.��ħ�ĵ� <= 40))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(true);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }

        else if ((41 <= UI.��ħ�ĵ�) && (UI.��ħ�ĵ�<= 50))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(true);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.��ħ�ĵ� >= 51) && (UI.��ħ�ĵ� <= 60))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(true);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.��ħ�ĵ� >= 61) && (UI.��ħ�ĵ� <= 70))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(true);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.��ħ�ĵ� >= 71) && (UI.��ħ�ĵ� <= 80))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(true);
            img8.SetActive(false);
            img9.SetActive(false);
        }
        else if ((UI.��ħ�ĵ� >= 81) && (UI.��ħ�ĵ� <= 90))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(true);
            img9.SetActive(false);
        }
        else if ((UI.��ħ�ĵ� >= 91) && (UI.��ħ�ĵ� <= 100))
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
            img4.SetActive(false);
            img5.SetActive(false);
            img6.SetActive(false);
            img7.SetActive(false);
            img8.SetActive(false);
            img9.SetActive(true);
        }
    }
}
