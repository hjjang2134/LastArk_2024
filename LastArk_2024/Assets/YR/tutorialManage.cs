using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class tutorial : MonoBehaviour
{
    public TypeEffect text1;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("tutorialscript");
        image1.SetActive(true);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
        image7.SetActive(false);
        image8.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //클릭, 스페이스시 프린트스크립트
        {
            printNext();
        }
    }

    public void printNext()
    {
        switch (count)
        {
            case 1:
                text1.SetMsg("평화로웠던 세계.");
                break;
            case 2:
                text1.SetMsg("수많은 과거의 역사가 말했듯이, 평화는 잠시였습니다.");
                break;
            case 3:
                image1.SetActive(false);
                image2.SetActive(true);
                text1.SetMsg("각자의 욕심과 이기심이 부딪치고");
                break;
            case 4:
                text1.SetMsg("세계는 다툼과 전쟁이 끊이지 않았습니다.");
                break;
            case 5:
                image2.SetActive(false);
                image3.SetActive(true);
                text1.SetMsg("사람들은 점점 증오와 광기로 가득 차게 되었습니다.");
                break ;
            case 6:
                image3.SetActive(false);
                image4.SetActive(true);
                text1.SetMsg("반복되는 비극 속, 인간은 결국 금기를 범하고 말았습니다.");
                break;
            case 7:
                text1.SetMsg("세상의 빛을 모두 지워버리는 [암흑] 이라는 무기를 사용하고 만 것입니다.");
                break;
            case 8:
                image4.SetActive(false);
                image5.SetActive(true);
                text1.SetMsg("세계는 어둠으로 가득 차고");
                break;
            case 9:
                text1.SetMsg("풀 한 포기, 벌레 하나 남지 않았습니다.");
                break;
            case 10:
                image5.SetActive(false);
                image6.SetActive(true);
                text1.SetMsg("그 수라장 속에서, 끝까지 마음의 빛을 잃지 않았던 아이가 있었습니다.");
                break;
            case 11:
                image6.SetActive(false);
                image7.SetActive(true);    
            
                text1.SetMsg("어느날 그 아이의 앞에, 3명의 이방인이 갑자기 나타났습니다.");
                break;
            case 12:
                text1.SetMsg("그들은 각각 [암흑]에 굴하지 않는 한 줄기 빛과 물, 씨앗을 한 아이에게 남기고, 사라졌습니다.");
                break;
            case 13:
                image7.SetActive(false);
                image8.SetActive(true);
                text1.SetMsg("그 아이는 희망을 품은 마지막 생존자들을 모았고,");
                break;
            case 14:
                text1.SetMsg("사람들을 보호할 최후의 성을 세웠습니다.");
                break;
            case 15:
                text1.SetMsg("이 아이,");
                break;
            case 16:
                text1.SetMsg("즉 당신은 이 세계 마지막 요새의 성주입니다.");
                break;
            case 17:
                text1.SetMsg("어둠, 약탈자, 빈곤하고 악한 사람들이 가득한 세계에서…");
                break;
            case 18:
                text1.SetMsg("당신의 사람들을 지키며 살아남으십시오.");
                break;
            case 19:
                SceneManager.LoadScene("day Scene");
                break;
            

        }
        count++;
        
    }
   
    public void nextScene()
    {
        SceneManager.LoadScene("day Scene");
    }
}
