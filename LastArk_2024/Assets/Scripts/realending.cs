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

public class realending : MonoBehaviour
{
    public TextMeshProUGUI ���1;
    public GameObject ��ư;
    public static int count = 1;

    void Start()
    {
        ���1.text = "����� ������ ����� �����½��ϴ�. ";



    }



    public void Ŭ��()
    {


        if (count == 1)
        {
            ���1.text = "����� ������ �ð����� ������ ����� ���縦 ���ѳ½��ϴ�.";



        }
        else if (count == 2)
        {


            ���1.text = "����, ����� �ŷ��ϴ� �����, ��ſ��� �漺�ϴ� �ֹε�, ������ ���� �Բ� �� ����� ���� �ȿ��� ��� ���� ���Դϴ�.";

        }



        else if (count == 3)
        {

            ���1.text = "�������� �ູ�ϰ�";


        }

        else if (count >= 4)
        {
            ��ư.SetActive(false);
        }

        count++;
    }


}
