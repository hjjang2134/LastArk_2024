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
    public GameObject ���;
    public GameObject ��ư;
    public TextMeshProUGUI ���1;
    public TextMeshProUGUI ���2;
    public TextMeshProUGUI ���3;
    public static int count=0;

    void Start()
    {
        �̹���1.SetActive(true);
        �̹���2.SetActive(false);
        �̹���3.SetActive(false);
        �̹���4.SetActive(false);
        ���.SetActive(false);
    }

    public void Onclick�Լ�()
    {   
        if (count<=2)
        {
            if (count == 0)
            {
                ���.SetActive(true);
                if (Clipboard.ħ�ĵ����� == true)
                {
                    ���1.text = "����� ���� ����߽��ϴ�.";
                }
                else if (Clipboard.�ķ����� == true)
                {
                    ���1.text = "����� ���� ����߽��ϴ�.";
                }
                else if (Clipboard.�α����� == true)
                {
                    ���1.text = "����� ���� ����߽��ϴ�";
                }
            }

            else if (count == 1)
            {
                �̹���1.SetActive(false);
                �̹���2.SetActive(true);
                �̹���3.SetActive(false);
                �̹���4.SetActive(false);
                if (Clipboard.ħ�ĵ����� == true)
                {
                    ���2.text = "�Ϻ��� ��ο��� ����� ���� ������� ������ �������ϴ�.";
                }
                else if (Clipboard.�ķ����� == true)
                {
                    ���2.text = "�� ���� ��� ������� ������ ��������� ���� �װų� �������ϴ�";
                }
                else if (Clipboard.�α����� == true)
                {
                    ���2.text = "���� ����, ���, ���������� ���� ������� õõ�� �׾��, �� ������ ���� �ʾҽ��ϴ�.";
                }
            }
            else if (count==2)
            {
                �̹���1.SetActive(false);
                �̹���2.SetActive(false);
                �̹���3.SetActive(true);
                �̹���4.SetActive(false);
                if (Clipboard.ħ�ĵ����� == true)
                {
                    ���3.text = "���� �ֹε��� �ݶ��� �����׽��ϴ�. ������� ����� �ܵδ뿡 �÷� ó���մϴ�.";
                }
                else if (Clipboard.�ķ����� == true)
                {
                    ���3.text = "����� ���㰡 �� �� �ȿ��� ȥ�� ���� ���ָ��� ������ �׾�ϴ�.";
                }
                else if (Clipboard.�α����� == true)
                {
                    ���3.text = "�ƹ��� ���� ���� ������ ����� ȥ�� ������ ���� �ٶ󺾴ϴ�";
                }
            }
      
        }
        
        else
        {
            �̹���1.SetActive(false);
            �̹���2.SetActive(false);
            �̹���3.SetActive(false);
            �̹���4.SetActive(true);
            ��ư.SetActive(false);

        }

        count++;

        
    }
    

}
