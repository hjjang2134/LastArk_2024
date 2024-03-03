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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //Ŭ��, �����̽��� ����Ʈ��ũ��Ʈ
        {
            printNext();
        }
    }

    public void printNext()
    {
        switch (count)
        {
            case 1:
                text1.SetMsg("��ȭ�ο��� ����.");
                break;
            case 2:
                text1.SetMsg("������ ������ ���簡 ���ߵ���, ��ȭ�� ��ÿ����ϴ�.");
                break;
            case 3:
                image1.SetActive(false);
                image2.SetActive(true);
                text1.SetMsg("������ ��ɰ� �̱���� �ε�ġ��");
                break;
            case 4:
                text1.SetMsg("����� ������ ������ ������ �ʾҽ��ϴ�.");
                break;
            case 5:
                image2.SetActive(false);
                image3.SetActive(true);
                text1.SetMsg("������� ���� ������ ����� ���� ���� �Ǿ����ϴ�.");
                break ;
            case 6:
                image3.SetActive(false);
                image4.SetActive(true);
                text1.SetMsg("�ݺ��Ǵ� ��� ��, �ΰ��� �ᱹ �ݱ⸦ ���ϰ� ���ҽ��ϴ�.");
                break;
            case 7:
                text1.SetMsg("������ ���� ��� ���������� [����] �̶�� ���⸦ ����ϰ� �� ���Դϴ�.");
                break;
            case 8:
                image4.SetActive(false);
                image5.SetActive(true);
                text1.SetMsg("����� ������� ���� ����");
                break;
            case 9:
                text1.SetMsg("Ǯ �� ����, ���� �ϳ� ���� �ʾҽ��ϴ�.");
                break;
            case 10:
                image5.SetActive(false);
                image6.SetActive(true);
                text1.SetMsg("�� ������ �ӿ���, ������ ������ ���� ���� �ʾҴ� ���̰� �־����ϴ�.");
                break;
            case 11:
                image6.SetActive(false);
                image7.SetActive(true);    
            
                text1.SetMsg("����� �� ������ �տ�, 3���� �̹����� ���ڱ� ��Ÿ�����ϴ�.");
                break;
            case 12:
                text1.SetMsg("�׵��� ���� [����]�� ������ �ʴ� �� �ٱ� ���� ��, ������ �� ���̿��� �����, ��������ϴ�.");
                break;
            case 13:
                image7.SetActive(false);
                image8.SetActive(true);
                text1.SetMsg("�� ���̴� ����� ǰ�� ������ �����ڵ��� ��Ұ�,");
                break;
            case 14:
                text1.SetMsg("������� ��ȣ�� ������ ���� �������ϴ�.");
                break;
            case 15:
                text1.SetMsg("�� ����,");
                break;
            case 16:
                text1.SetMsg("�� ����� �� ���� ������ ����� �����Դϴ�.");
                break;
            case 17:
                text1.SetMsg("���, ��Ż��, ����ϰ� ���� ������� ������ ���迡����");
                break;
            case 18:
                text1.SetMsg("����� ������� ��Ű�� ��Ƴ����ʽÿ�.");
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
