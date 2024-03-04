using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Globalization;
using System.Net.Mail;
using TMPro;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System;

using Random = UnityEngine.Random;
using System.Linq;

public class endingimg : MonoBehaviour
{
    public GameObject 이미지1;
    public GameObject 이미지2;
    public GameObject 이미지3;
    public GameObject 이미지4;
    public GameObject 버튼;
    public GameObject goMain;
    public TextMeshProUGUI 대사;
    public static int count=0;

    public TextMeshProUGUI goMainTxt; //안중요함
    public float speed = 1.0f;
    public Image black;


    void Start()
    {
        Color color = black.color;
        color.a = 0.0f;
        black.color = color;

        activeFalse();
        if(Clipboard.침식도엔딩 == true)
        {
            이미지1.SetActive(true);
        }
        else if (Clipboard.인구엔딩 == true)
        {
            이미지2.SetActive(true);
        }
        else if (Clipboard.희망엔딩 == true)
        {
            이미지3.SetActive(true);
        }
        else if (Clipboard.식량엔딩 == true)
        {
            이미지4.SetActive(true);
        }
    }

    public void activeFalse() //이미지 모두 끔
    {
        이미지1.SetActive(false);
        이미지2.SetActive(false);
        이미지3.SetActive(false);
        이미지4.SetActive(false);
    }

    public void goToMain()
    {
        SceneManager.LoadScene("Start Scene");
    } //start씬으로

    public void Onclick함수()
    {
        if (count == 0)
        {
            Color color = black.color;
            color.a = 0.2f;
            black.color = color;

            if (Clipboard.침식도엔딩 == true)
            {
                대사.text = "당신은 몰려오는 어둠으로부터 도시를 지키지 못했습니다.";
            }
            else if (Clipboard.인구엔딩 == true)
            {
                대사.text = "당신은 주민들의 지지를 잃었습니다.";
            }
            else if (Clipboard.희망엔딩 == true)
            {
                대사.text = "당신은 주민들의 희망을 시들게 했습니다.";
            }
            else if (Clipboard.식량엔딩 == true)
            {
                대사.text = "모든 물이 오염되고 곡물은 시들었습니다.";
            }
        }

        else if (count == 1)
        {
            Color color = black.color;
            color.a = 0.4f;
            black.color = color;

            if (Clipboard.침식도엔딩 == true)
            {
                대사.text = "세계의 마지막 빛은 꺼지고,";
            }
            else if (Clipboard.인구엔딩 == true)
            {
                대사.text = "잘못된 선택의 연속으로 인해 주민들은 신뢰를 잃었고,";
            }
            else if (Clipboard.희망엔딩 == true)
            {
                대사.text = "주민들은 더 이상 성 안에서의 행복한 미래를 꿈꾸지 못합니다.";
            }
            else if (Clipboard.식량엔딩 == true)
            {
                대사.text = "성의 저장고는 텅 비어 곡물 한톨 보이지 않습니다.";
            }
        }
        else if (count == 2)
        {
            Color color = black.color;
            color.a = 0.6f;
            black.color = color;

            if (Clipboard.침식도엔딩 == true)
            {
                대사.text = "온 세계는 어둠으로 가득 차게 되었습니다.";
            }
            else if (Clipboard.인구엔딩 == true)
            {
                대사.text = "모두가 당신의 자질을 의심합니다.";
            }
            else if (Clipboard.희망엔딩 == true)
            {
                대사.text = "주민들은 당신을 내쫓기 위해 반란을 모의했습니다.";
            }
            else if (Clipboard.식량엔딩 == true)
            {
                대사.text = "성 안은 굶주림에 미쳐버린 사람들로 가득합니다.";
            }
        }
        else if (count == 3)
        {
            Color color = black.color;
            color.a = 0.8f;
            black.color = color;

            if (Clipboard.침식도엔딩 == true)
            {
                대사.text = "당신과 주민들은 죽음만을 기다립니다.";
            }
            else if (Clipboard.인구엔딩 == true)
            {
                대사.text = "당신은 아무도 없는 텅 빈 성에서 혼자 쓸쓸히 죽음을 맞이합니다.";
            }
            else if (Clipboard.희망엔딩 == true)
            {
                대사.text = "당신은 주민들로 인해 처형당합니다. ";
            }
            else if (Clipboard.식량엔딩 == true)
            {
                대사.text = "당신을 포함한 모든 성 안의 사람들은 갈증과 굶주림으로 전부 사망할 것입니다.";
            }
        }
        else if (count == 4)
        {
            Color color = black.color;
            color.a = 1f;
            black.color = color;

            if (Clipboard.침식도엔딩 == true)
            {
                대사.text = "Bad Ending 4. 어둠";
            }
            else if (Clipboard.인구엔딩 == true)
            {
                대사.text = "Bad Ending 2. 텅 빈 폐허";
            }
            else if (Clipboard.희망엔딩 == true)
            {
                대사.text = "Bad Ending 1. 반란";
            }
            else if (Clipboard.식량엔딩 == true)
            {
                대사.text = "Bad Ending 3. 대기근";
            }
        }
        else
        {
            버튼.SetActive(false);
            goMain.SetActive(true);
        }

        count++;

        
    }

    private void Update()
    {
        float alpha = Mathf.PingPong(Time.time * speed, 1);
        Color currentColor = goMainTxt.color;
        currentColor.a = alpha;
        goMainTxt.color = currentColor;
    }


}