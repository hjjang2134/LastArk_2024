using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

public class NewShuffle : MonoBehaviour
{

    //���� �⺻��ҹ� �ʱ� ����Ʈ, Ư����ҹ� �ʱ� ����Ʈ, ���� ��ҹ��� ����Ʈ�̴�.
    //�۵������ Ư����ҹ��� �÷��׿� ���� �̰�, ������ ĭ�� �⺻��ҹ��� ��ȣ���� �̾ƿ´�.
    //�۵���Ŀ� ���� public �� ���� �̸� ����
    List<int> commonSSM = new List<int>();
    List<int> specialSSM = new List<int>();
    List<int> dailySSM = new List<int>();

    int maxNum, ranNum, indexNum;

    int yy = 2023;
    int mm = 1;
    int m_count = 1;
    GameObject gameDate;

    bool isExit;

    // �� ������ ������ �� ������ �Լ�
    void Start()
    {
        this.gameDate = GameObject.Find("Date"); //��¥ ���� TEXT������Ʈ�� �޾ƿ�. ������Ʈ �̸� ���� ����. �̶� TEXT�� �ƴҰ�� ��� ������Ʈ �� ��ȯ�ؾ�.

        for (int i = 0; i < 200; i++) //200�� ���� ��ҹ� ����, ��ҹ� ���� ������ ����
        {
            commonSSM.Add(i);
        }
        for (int i = 0; i < 7; i++) //7�� ó�� ������ Ư�� ��ҹ� ����, �̶� ��ȣ�� 150~156�̶� +150.
        {
            specialSSM.Add(i+150);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBtn()
    {
        //��ư Ŭ���� �켱 ������ ��ҹ� ����Ʈ�� ���� ����
        dailySSM.Clear();

        print("��ư Ŭ��");
        date_ctr();
        special();
        common();
        daily();
    }

    //list1���� �ش�Ǵ� index�� ��Ҹ� �̾� list2�� �Ű��ִ� �Լ�, �⺻ ��ҹ��� ���δ�
    void pop(List<int> list1, List<int> list2, int index)
    {
        int num = list1[index];
        list1.RemoveAt(index);
        list2.Add(num);
    }

    //list1���� �ش�Ǵ� index�� ��Ҹ� list2�� �������ִ� �Լ�, Ư�� ��ҹ��� ���δ�
    void peek(List<int> list1, List<int> list2, int index)
    {
        int num = list1[index];
        list2.Add(num);
        isExit = true;
    }

    //�⺻ ����Ʈ���� �ε��� ��ȣ�� �������� �̾� ���� ����Ʈ�� �ִ� �Լ�, ���� ��ȣ�� �⺻ ����Ʈ���� ����
    void common()
    {
        if (isExit)
        {
            for (int i = 0; i < 7; i++)
            {
                maxNum = commonSSM.Count;
                ranNum = Random.Range(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);
            }
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                maxNum = commonSSM.Count;
                ranNum = Random.Range(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);
            }
        }
    }
    
    //�÷��׿� ���� ���� ����Ʈ�� �ִ� �Լ�. �Ѵ� �� �ִ�1���� �� �� �ִ�.
    //�÷��׿� ���� ��ȣ�� ���� ����Ʈ�� �����Ͽ� �ִ´�
    void special()
    {
        indexNum = -1;
        isExit = false;

        if (m_count == 1)
            indexNum = 0;
        else if (m_count == 7)
            indexNum = 1;
        else if (m_count == 8 /*&& RayAlive*/)
            indexNum = 2;
        else if (m_count == 11 /*&& main1*/)
            indexNum = 3;
        else if (m_count == 14 /*&& main2_1*/)
            indexNum = 4;
        else if (m_count == 16 /*&& main3*/)
            indexNum = 5;
        else if (m_count == 17)
            indexNum = 6;

        if (indexNum>=0)
        {
            peek(specialSSM, dailySSM, indexNum);
        }

    }

    void daily()
    {
        if(dailySSM.Count != 8)
        {
            print("Error");
        }
        //������Ʈ ã�Ƽ� �ؽ�Ʈ �ٲٱ�, ���⼭�� ��ȣ�� ��ġ��
        for (int i = 0; i < dailySSM.Count; i++)
        {
            GameObject.Find("card" + (i + 1)).GetComponent<TextMeshProUGUI>().text = Convert.ToString(dailySSM[i]);
        }
    }

    void date_ctr() //��¥ �ٲ��ִ� �Լ�
    {
        mm++;
        m_count++;
        if (mm > 12)
        {
            mm = 1;
            yy++;
        }

        /*��¥�� ���� ���� �ο�. ������ �־��� Ȥ�� ���� �ּ�ó��
        if (mm >= 6) second_level = true;
        if (mm >= 12) third_level = true;
        */

        if (mm >= 10) //�ؽ�Ʈ ����
        {
            this.gameDate.GetComponent<TextMeshProUGUI>().text = yy + ". " + mm + ". 01";
        }
        else
        {
            this.gameDate.GetComponent<TextMeshProUGUI>().text = yy + ". 0" + mm + ". 01";
        }
    }

}
