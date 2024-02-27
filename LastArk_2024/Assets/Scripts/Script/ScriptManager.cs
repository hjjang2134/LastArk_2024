using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScriptManager : MonoBehaviour
{
    
    public TypeEffect scriptText;
    public TextMeshProUGUI nameText;
    public static bool scriptscene = true, isChoiceDisplayed = false; //��ũ��Ʈ���ΰ� Ȯ���ϱ�, ȭ��Ŭ������
    public static int count = 0, ������count = 0; //��ҹ� �ѹ� �޾ƿ���

    public GameObject ��Į��Image, ����Image, ����Image;
    public static string story = "sub1", person = "Character";
    public TextMeshProUGUI ������1, ������2, ������3;
    public GameObject ��������ưob1, ��������ưob2, ��������ưob3;
    public Button ������bt1, ������bt2, ������bt3;

    public bool gogoodendingok = false, gorealendingok = false;



    void Start()
    {
        scriptscene = true; 
        scriptText = GameObject.Find("ScriptText").GetComponent<TypeEffect>();
        nameText = GameObject.Find("NameText").GetComponent<TextMeshProUGUI>();
        
        ��Į��Image.SetActive(false);
        ����Image.SetActive(false);
        ����Image.SetActive(false);

        ������bt1 = GameObject.Find("��������ư1").GetComponent<Button>();
        ������bt2 = GameObject.Find("��������ư2").GetComponent<Button>();
        ������bt3 = GameObject.Find("��������ư3").GetComponent<Button>();

        ��������ưob1.SetActive(false);
        ��������ưob2.SetActive(false);
        ��������ưob3.SetActive(false);

        printscript();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //Ŭ��, �����̽��� ����Ʈ��ũ��Ʈ
        {
            if (!isChoiceDisplayed)
            {
                printscript();
                Debug.Log("mmmm����Ʈ��ũ��Ʈ����mmmmmmmm ");
            }
        }
    }

    public void printscript() //�������� �޾ƿ���
    {
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("���丮 �뺻");
        Debug.Log(story);
        Debug.Log(data_Dialog[count]["story"].ToString());
        Debug.Log(count);

        if (story == data_Dialog[count]["story"].ToString()) //story �� ���� �ٲ��� �ʴ´ٸ�
        {
            if ((person != data_Dialog[count]["person"].ToString())||(count == 147)) //person�� ���� �ٲ�ٸ�
            {
                if (person == "��Į��") ��Į��Image.SetActive(false); //ĳ���� �׸� �������
                if (person == "����") ����Image.SetActive(false);
                if (person == "����") ����Image.SetActive(false);
                
                person = data_Dialog[count]["person"].ToString(); //person ����
                if (person == "��") ��Action();
                CharacterAction(person); //ĳ���� ���� �Լ� ���� (�̹���, �̸� �ٲ�)
            }
            string content = data_Dialog[count]["content"].ToString(); //script �ҷ��ͼ� �ؽ�Ʈ �ٲ�
            scriptText.SetMsg(content);
        }
        else
        {
            story = data_Dialog[count]["story"].ToString();
            if((count == 324) || (count == 319)) 
            {
                if (gogoodendingok == true) SceneManager.LoadScene("GoodEnding");
                else if (gorealendingok == true) SceneManager.LoadScene("RealEnding");
            }
            else if (count != 50 && count != 93 && count != 159 && count != 290)
            //����ȯ ����, ��ưŬ�� �� ���� 
            //ex: sub2-1�� ù��°
            {
                count--;
                scriptscene = false;
                SceneManager.LoadScene("Main Scene");
            }
        }
        if (count == 78) //�ǳʶٱ� (ex: sub2-1 >> sub3),
                         //����: sub2-1 ������, count: sub3�� ù��°
        {
            count = 84;
        }
        else if (count == 121)
        {
            count = 125;
            //story = "main1";
        }
        else if (count == 214)
        {
            count = 218;
            //story = "main3";
        }
        else
        {
            count++;
            Debug.Log("count++�Ϸ� count : " + count);
        }
       
        Debug.Log("���� count : " + count);
        if (count > 324) SceneManager.LoadScene("Main Scene");
    }

    public void CharacterAction(string name) //ĳ���� �׸� �ö���� �̸� �ٲ��
    {
        nameText.text = name;

        if (name == "��Į��") 
        {
            ��Į��Image.SetActive(true);
        }
        if (name == "����") 
        {
            ����Image.SetActive(true);
        }
        if (name == "����") 
        {
            ����Image.SetActive(true);
        }
    }

    public void ��Action() //������ ���̰� �ϴ� �Լ�
    {
      
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("������");
        string choice1 = data_Dialog[������count]["choice1"].ToString();
        ������1.text = choice1;
        ��������ưob1.SetActive(true);
        string choice2 = data_Dialog[������count]["choice2"].ToString();
        if (choice2 != "null" && !string.IsNullOrEmpty(choice2))
        {
            ������2.text = choice2;
            ��������ưob2.SetActive(true);
        }
        string choice3 = data_Dialog[������count]["choice3"].ToString();
        if (choice3 != "null" && !string.IsNullOrEmpty(choice3))
        {
            ������3.text = choice3;
            ��������ưob3.SetActive(true);
        }
        ������count++;
        Debug.Log("������ī��Ʈ : " + ������count);
        isChoiceDisplayed = true;

        // ���⼭���� ��ư Ŭ�� �� �ǳʶٴ� �ڵ�
        //����: �б����� ������ ��ȣ count: sub2-2�� ù��° ������count: �ǳʶٰ��� �ϴ� ������ ����
        if (������count == 5)
        {
            Debug.Log("�Ѿ��");
            ������bt1.onClick.RemoveAllListeners();
            ������bt1.onClick.AddListener(() =>
            {
                story = "sub2-1";
                BtnAction();
            });
            ������bt2.onClick.RemoveAllListeners();
            ������bt2.onClick.AddListener(() =>
            {
                story = "sub2-2";
                count = 79;
                ������count = 6;
                BtnAction();
            });
        }
        else if (������count == 9)
        {
            Debug.Log("�Ѿ��");
            ������bt1.onClick.RemoveAllListeners();
            ������bt1.onClick.AddListener(() =>
            {
                story = "sub3-1";
                BtnAction();
            });
            ������bt2.onClick.RemoveAllListeners();
            ������bt2.onClick.AddListener(() =>
            {
                story = "sub3-2";
                count = 122;
                BtnAction();
            });
        }
        else if (������count == 13)
        {
            Debug.Log("�Ѿ��");
            ������bt1.onClick.RemoveAllListeners();
            ������bt1.onClick.AddListener(() =>
            {
                story = "main2-1";
                BtnAction();
                Clipboard.main2_1 = true;
            });
            ������bt2.onClick.RemoveAllListeners();
            ������bt2.onClick.AddListener(() =>
            {
                story = "main2-2&3";
                count = 215;
                ������count = 18;
                BtnAction();
            });
            ������bt3.onClick.RemoveAllListeners();
            ������bt3.onClick.AddListener(() =>
            {
                story = "main2-2&3";
                count = 215;
                ������count = 18;
                BtnAction();
            });
        }
        else if (������count == 23)
        {
            Debug.Log("�Ѿ��");
            ������bt1.onClick.RemoveAllListeners();
            ������bt1.onClick.AddListener(() =>
            {
                story = "main4-1&3";
                count = 320;
                BtnAction();
                gogoodendingok = true;
            });
            ������bt2.onClick.RemoveAllListeners();
            ������bt2.onClick.AddListener(() =>
            {
                story = "main4-2";
                BtnAction();
                gorealendingok = true;
            });
            ������bt3.onClick.RemoveAllListeners();
            ������bt3.onClick.AddListener(() =>
            {
                story = "main4-1&3";
                count = 320;
                BtnAction();
                gogoodendingok = true;
            });
        }
        else
        {
            ������bt1.onClick.RemoveAllListeners();
            ������bt1.onClick.AddListener(BtnAction);
            ������bt2.onClick.RemoveAllListeners();
            ������bt2.onClick.AddListener(BtnAction);
            ������bt3.onClick.RemoveAllListeners();
            ������bt3.onClick.AddListener(BtnAction);
        }
        Debug.Log("���׼ǳ�");
    }
    public void BtnAction()//������ ��ư Ŭ���ϸ� 
    {
        ��������ưob1.SetActive(false); //�����
        ��������ưob2.SetActive(false);
        ��������ưob3.SetActive(false);
        printscript();
        isChoiceDisplayed = false;
        Debug.Log("BtnAction��");
    }


}
