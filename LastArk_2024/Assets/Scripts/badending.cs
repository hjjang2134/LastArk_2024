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
    public GameObject �̹���1;
    public GameObject �̹���2;
    public GameObject �̹���3;
    public GameObject �̹���4;
    public GameObject ��ư;
    public GameObject goMain;
    public TextMeshProUGUI ���;
    public static int count=0;

    public TextMeshProUGUI goMainTxt; //���߿���
    public float speed = 1.0f;

    void Start()
    {
        activeFalse();
        if(Clipboard.ħ�ĵ����� == true)
        {
            �̹���1.SetActive(true);
        }
        else if (Clipboard.�α����� == true)
        {
            �̹���2.SetActive(true);
        }
        else if (Clipboard.������� == true)
        {
            �̹���3.SetActive(true);
        }
        else if (Clipboard.�ķ����� == true)
        {
            �̹���4.SetActive(true);
        }
    }

    public void activeFalse() //�̹��� ��� ��
    {
        �̹���1.SetActive(false);
        �̹���2.SetActive(false);
        �̹���3.SetActive(false);
        �̹���4.SetActive(false);
    }

    public void goToMain()
    {
        SceneManager.LoadScene("Start Scene");
    } //start������

    public void Onclick�Լ�()
    {
        if (count == 0)
        {
            if (Clipboard.ħ�ĵ����� == true)
            {
                ���.text = "����� �������� ������κ��� ���ø� ��Ű�� ���߽��ϴ�.";
            }
            else if (Clipboard.�α����� == true)
            {
                ���.text = "����� �ֹε��� ������ �Ҿ����ϴ�.";
            }
            else if (Clipboard.������� == true)
            {
                ���.text = "����� �ֹε��� ����� �õ�� �߽��ϴ�.";
            }
            else if (Clipboard.�ķ����� == true)
            {
                ���.text = "��� ���� �����ǰ� ��� �õ�����ϴ�.";
            }
        }

        else if (count == 1)
        {
            if (Clipboard.ħ�ĵ����� == true)
            {
                ���.text = "������ ������ ���� ������,";
            }
            else if (Clipboard.�α����� == true)
            {
                ���.text = "�߸��� ������ �������� ���� �ֹε��� �ŷڸ� �Ҿ���,";
            }
            else if (Clipboard.������� == true)
            {
                ���.text = "�ֹε��� �� �̻� �� �ȿ����� �ູ�� �̷��� �޲��� ���մϴ�.";
            }
            else if (Clipboard.�ķ����� == true)
            {
                ���.text = "���� ������ �� ��� � ���� ������ �ʽ��ϴ�.";
            }
        }
        else if (count == 2)
        {
            if (Clipboard.ħ�ĵ����� == true)
            {
                ���.text = "�� ����� ������� ���� ���� �Ǿ����ϴ�.";
            }
            else if (Clipboard.�α����� == true)
            {
                ���.text = "��ΰ� ����� ������ �ǽ��մϴ�.";
            }
            else if (Clipboard.������� == true)
            {
                ���.text = "�ֹε��� ����� ���ѱ� ���� �ݶ��� �����߽��ϴ�.";
            }
            else if (Clipboard.�ķ����� == true)
            {
                ���.text = "�� ���� ���ָ��� ���Ĺ��� ������ �����մϴ�.";
            }
        }
        else if (count == 3)
        {
            if (Clipboard.ħ�ĵ����� == true)
            {
                ���.text = "��Ű� �ֹε��� �������� ��ٸ��ϴ�.";
            }
            else if (Clipboard.�α����� == true)
            {
                ���.text = "����� �ƹ��� ���� �� �� ������ ȥ�� ������ ������ �����մϴ�.";
            }
            else if (Clipboard.������� == true)
            {
                ���.text = "����� �ֹε�� ���� ó�����մϴ�. ";
            }
            else if (Clipboard.�ķ����� == true)
            {
                ���.text = "����� ������ ��� �� ���� ������� ������ ���ָ����� ���� ����� ���Դϴ�.";
            }
        }
        else if (count == 4)
        {
            if (Clipboard.ħ�ĵ����� == true)
            {
                ���.text = "Bad Ending 4. ���";
            }
            else if (Clipboard.�α����� == true)
            {
                ���.text = "Bad Ending 2. �� �� ����";
            }
            else if (Clipboard.������� == true)
            {
                ���.text = "Bad Ending 1. �ݶ�";
            }
            else if (Clipboard.�ķ����� == true)
            {
                ���.text = "Bad Ending 3. ����";
            }
        }
        else
        {
            ��ư.SetActive(false);
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
