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
using JetBrains.Annotations;

public class Clipboard : MonoBehaviour 
{
   
    public static int stagenum=1; // stage ������ ���� 

    public static int ��ҹ�count=0; // ��ҹ����� ������ ���� 

    public static string ��ҹ�����;
    public static int ��ҹ�����;
    public static float �ּ� ;
    public static float �ִ�;
    public static int ����������;
    public static float ������ħ�ĵ�;
    public static float ���������;
    public static float �����ýķ�;
    public static float �������α�;
    public static float ���н�ħ�ĵ�;
    public static float ���н����;
    public static float ���нýķ�;
    public static float ���н��α�;
    public static float ���������;
    public static float �����ýķ�;
    public static float ������ħ�ĵ�;
    public static float �������α�;

    //���丮 ��ҹ� 
 
    public static string ���丮Ÿ��Ʋ;
    public static string ���丮����;
    public static string �������ڸ�Ʈ;
    public static string ���н��ڸ�Ʈ;
    public static string �������ڸ�Ʈ;
    public static int num;
    public static bool Sub1=false;
    public static bool main1 = false;
    public static bool main2 = false;
    public static bool main2_1 = false;
    public static bool main3 = false;
    public static bool main4_1 = false;
    public static bool RayAlive = true;
    public static bool EugeneAlive = true;
    public static bool �ð���1 = false;
    public static bool �ð���2 = false;
    public static bool �ð���3 = false;
    public static bool ���ð���1 = false;
    public static bool ���ð���2 = false;
    public static bool ���ð���3 = false;

    // ���� �÷���
    public static bool suc150 = false;
    public static bool fail150 = false;
    public static bool rej150 = false;
    public static bool suc151 = false;
    public static bool fail151 = false;
    public static bool rej151 = false;
    public static bool suc152 = false;
    public static bool fail152 = false;
    public static bool rej152 = false;
    public static bool suc153 = false;
    public static bool fail153 = false;
    public static bool rej153 = false;
    public static bool suc154 = false;
    public static bool fail154 = false;
    public static bool rej154 = false;
    public static bool suc155 = false;
    public static bool fail155 = false;
    public static bool rej155 = false;
    public static bool suc156 = false;
    public static bool fail156 = false;
    public static bool rej156 = false;
    public static bool common1 = false;
    public static bool common2 = false;
    public static bool common3 = false;
    public static bool ħ�ĵ����� = false;
    public static bool �α����� = false;
    public static bool �ķ����� = false;
    





    public static List<int> commonSSM = new List<int>();
    public static List<int> specialSSM = new List<int>();
    public static List<int> storySSM = new List<int>();
    public static List<int> dailySSM = new List<int>();
    public static List<int> ���ǻ�ҹ� = new List<int>();


    public static int maxNum;
    public static int ranNum;
    public static int indexNum;
    public static bool isExit;
    
    public TextMeshProUGUI Scinfo1;
    public GameObject ������ġ���ư;
    public GameObject Ư����ҹ�ǥ��; //�߰�
   
   





    //public static float ����Ȯ�� = 100 - UI.�����;
    public static float ����Ȯ�� = 0;
    public static int A ; // ���� or ���� Ȯ�� ���� 
    public static int B; //Ư����ҹ� �Ϲݻ�ҹ� ���� �Ϲݻ�ҹ��� ��� 1, Ư����ҹ��� 2, ���丮 ��ҹ��� ��� 3
    public static float ������; // �ҷ��ð�����
   


    private void Start()
    {

        ������ġ���ư.SetActive(true);
        Ư����ҹ�ǥ��.SetActive(false); //�߰�
        

    }
    private void update()
    {
        if (B==2)
        {
            Ư����ҹ�ǥ��.SetActive(true);
            Debug.Log("Ư��ǥ��2");
        }
    }


    public void �׽�Ʈ�Լ�()
    {
        List<int> �׽�Ʈ����Ʈ = new List<int>();
        �׽�Ʈ����Ʈ.Add(0);
        �׽�Ʈ����Ʈ.Add(1);
        int numbb = �׽�Ʈ����Ʈ[��ҹ�count];
        print(��ҹ�count);
        pickup�⺻��ҹ�(numbb);
        print(��ҹ�����);
        Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
        Scinfo1.text = ��ҹ�����;
       


        
        
       

    }

    public void ��������()
    {
        if (UI.��ħ�ĵ� >= 100)
        {
            ħ�ĵ����� = true;
            gobadending();

        }
        else if (UI.���α� <= 1000)
        {
            �α����� = true;
            gobadending();
        }
        else if (UI.���ķ� == 0)
        {
            �ķ����� = true;
            gobadending();
        }
    }
   



    

    public static void gobadending()
    {
            SceneManager.LoadScene("BadEnding");
    }
    public static void gogoodending()
    {
        SceneManager.LoadScene("GoodEnding");
    }
    
    public void ��ҹ������Լ�() //��ҹ� �����ų �� ������ �Լ�
    {
        int number = dailySSM[��ҹ�count];
       
        print(stagenum);
        print(number);
        if (number<=130)
        {
            pickup�⺻��ҹ�(number);
            Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
            Scinfo1.text = ��ҹ�����;

        }
        else if (number >= 150 && number <= 157)
        {
            pickup���丮��ҹ�(number-150);
            Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
         
            Scinfo1.text = ���丮����;

        }
        else 
        {
            Ư����ҹ�ǥ��.SetActive(true); //�߰�
            pickupƯ����ҹ�(number-200);
            Scinfo1 = GameObject.Find("scriptinfo1").GetComponent<TextMeshProUGUI>();
            Scinfo1.text = ��ҹ�����;

            Debug.Log("Ư��ǥ��");


        }
       






    }

  /* void Awake() // �ʱ� �� ���� ����Ʈ�� ä���
    {
       
       
        dailySSM.Clear();
        for (int i = 0; i < 130; i++) // �Ϲݻ�ҹ�
        {
            commonSSM.Add(i);
        }
        for (int i = 0; i < 8; i++) // ���丮��ҹ�
        {
            storySSM.Add(i + 150);
        }
        for (int i= 0; i<=30;i++)// Ư����ҹ����� ���������� ���� ��ҹ�
        {
            specialSSM.Add(i+200);
        }
        
        ���ϸ�����Ʈ(); //ó���� �� �� �̾���!

      
       
        
       

    }*/

    public static void ����Ʈ����()
    {
        for (int i = 0; i < 130; i++) // �Ϲݻ�ҹ�
        {
            commonSSM.Add(i);
        }
        for (int i = 0; i < 8; i++) // ���丮��ҹ�
        {
            storySSM.Add(i + 150);
        }
        for (int i = 0; i <= 30; i++)// Ư����ҹ����� ���������� ���� ��ҹ�
        {
            specialSSM.Add(i + 200);
        }
        ���ϸ�����Ʈ();
        for (int i = 0; i < dailySSM.Count; i++)
        {
            print(dailySSM[i]);
        }
    }


    private static void pop(List<int> list1, List<int> list2, int index) 
    {
        int num = list1[index];
        list1.RemoveAt(index);
        list2.Add(num);
    }

    private static void peek(List<int> list1, List<int> list2, int index)
    {
        int num = list1[index];
        list2.Add(num);
        isExit = true;
    }


    public static void ���ϸ�����Ʈ() // �־��� ��ҹ��� �� ó�������� dailyssm�� �ʱ�ȭ�ϰ� ���� �޾ƿ��� �Լ� 
    {
        
        dailySSM.Clear();
        story();
        common();
        special();
       
       







    }


    public static void common() // �Ϲݻ�ҹ� �̴� �Լ� 
    {
        System.Random random = new System.Random();
        int maxNum = 51;
        if (stagenum == 1)
        {
            maxNum = 50;
        }
        if (stagenum == 2)
        {
            maxNum = 44;
        }
        if (stagenum == 3)
        {
            maxNum = 37;
        }
        if (stagenum == 4)
        {
            maxNum = 30;
        }
        if (stagenum == 5)
        {
            maxNum = 23;
        }
        if (stagenum == 6)
        {
            maxNum = 16;
        }
        if (stagenum == 7)
        {
            maxNum = 66;
        }
        if (stagenum == 8)
        {
            maxNum = 59;
        }
        if (stagenum == 9)
        {
            maxNum = 52;
        }
        if (stagenum == 10)
        {
            maxNum = 45;
        }
        if (stagenum == 11)
        {
            maxNum = 38;
        }
        if (stagenum == 12)
        {
            maxNum = 68;
        }
        if (stagenum == 13)
        {
            maxNum = 61;
        }
        if (stagenum == 14)
        {
            maxNum = 54;
        }
        if (stagenum == 15)
        {
            maxNum = 47;
        }
        if (stagenum == 16)
        {
            maxNum = 40;
        }
        if (stagenum == 17)
        {
            maxNum = 33;
        }
        if (stagenum == 18)
        {
            maxNum = 26;
        }
        if (isExit) // ���丮��ҹ��� ��������
        {
            for (int i = 0; i < 6; i++)
            {

                int ranNum = random.Next(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);

            }



        }
        else // �� ��������
       
        {
            for (int i = 0; i < 7; i++)
            {


                int ranNum = random.Next(0, maxNum);
                pop(commonSSM, dailySSM, ranNum);

            }
        }
    }


    public static void story()//���丮��ҹ� �̴� �Լ� 
    {
        int indexNum = -1;
        isExit = false;

        if (stagenum == 1)
            indexNum = 0;
        else if (stagenum == 7)
            indexNum = 1;
        else if (stagenum == 8 && RayAlive == true)
            indexNum = 2;
        else if (stagenum == 11 && main1==true)
            indexNum = 3;
        else if (stagenum == 14 &&main2_1==true)
            indexNum = 4;
        else if (stagenum == 16 && main3==true)
            indexNum = 5;
        else if (stagenum == 17)
            indexNum = 6;

        if (indexNum >= 0)
        {
            isExit = true;
            peek(storySSM, dailySSM, indexNum);
        }

    }

   
    public static void special() //����� ��ҹ� �̴� �Լ� 
    {


        if ((100 < UI.���ķ�)&&(UI.���ķ�<200))
        {
            if (find(specialSSM, 200))
            {
                ���ǻ�ҹ�.Add(200);
            }
        }
        else if ((0 < UI.���ķ�) && (UI.���ķ� <= 100))
        {
            if (find(specialSSM, 201))
            {
                ���ǻ�ҹ�.Add(201);
            }
        }
        else if ((80 <=  UI.��ħ�ĵ�) && (UI.��ħ�ĵ� < 90))
        {
            if (find(specialSSM, 202))
            {
                ���ǻ�ҹ�.Add(202);
            }
        }
        else if ((90 <= UI.��ħ�ĵ�) && (UI.��ħ�ĵ� < 100))
        {
            if (find(specialSSM, 203))
            {
                ���ǻ�ҹ�.Add(203);
            }
        }
        else if ((10000 < UI.���α�) && (UI.���α� < 15000))
        {
            if (find(specialSSM,204))
            {
                ���ǻ�ҹ�.Add(204);
            }
            
        }
        else if (UI.���α�<=10000)
        {
            if (find(specialSSM, 205))
            {
                ���ǻ�ҹ�.Add(205);
            }
        }
        else if (RayAlive==false)
        {
            if (find(specialSSM, 206))
            {
                ���ǻ�ҹ�.Add(206);
            }
        }
        else if (EugeneAlive==false)
        {
            if (find(specialSSM, 207))
            {
                ���ǻ�ҹ�.Add(207);
            }
        }

        if (���ǻ�ҹ�.Count>0)
        {
           
            int rannum = Random.Range(0, (���ǻ�ҹ�.Count) - 1);
            int putin = ���ǻ�ҹ�[rannum];
            pop(specialSSM, dailySSM, putin-200);
            ���ǻ�ҹ�.Clear();
        }

        else
        {
            
            int rannum = Random.Range(8, (specialSSM.Count) - 1);
            pop(specialSSM, dailySSM, rannum);
        }
        
        


        
    }


    public static bool find( List<int> list1,int number)
    {
        for (int i=0;i<list1.Count; i++)
        {
            if (list1[i]==number)
            {
                return true;
            }
        }
        return false;
    }



    public static void go_ScriptScene()
    {

        SceneManager.LoadScene("Script Scene");

    }


   
    private void pickup�⺻��ҹ�(int i)
    {
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("�⺻��ҹ�");
        ��ҹ����� = data_Dialog[i]["contents"].ToString(); //string����
        string lv = data_Dialog[i]["level"].ToString();
        ��ҹ����� = int.Parse(lv);
        string appsucfood = data_Dialog[i]["AppFood"].ToString();
        �����ýķ� = float.Parse(appsucfood);
        string appsuchuman = data_Dialog[i]["AppHuman"].ToString();
        �������α� = float.Parse(appsuchuman);//float ���·� �ٲٱ�
        string appsucdark = data_Dialog[i]["AppDark"].ToString();
       
        ������ħ�ĵ� = float.Parse(appsucdark);//float ���·� �ٲٱ�
        string appsuchope = data_Dialog[i]["AppHope"].ToString();
        ��������� = float.Parse(appsuchope);//float ���·� �ٲٱ�

        string rejectfood = data_Dialog[i]["RejectFood"].ToString();
        �����ýķ� = float.Parse(rejectfood);
        string rejecthuman = data_Dialog[i]["RejectHuman"].ToString();
        �������α� = float.Parse(rejecthuman);//float ���·� �ٲٱ�
        string rejectdark = data_Dialog[i]["RejectDark"].ToString();
        ������ħ�ĵ� = float.Parse(rejectdark);//float ���·� �ٲٱ�
        string rejecthope = data_Dialog[i]["RejectHope"].ToString();
        ��������� = float.Parse(rejecthope);//float ���·� �ٲٱ�

        B = 1; // �Ϲݻ�ҹ��̶�� ��
    }


   
   

    private void pickup���丮��ҹ� (int i)
    {
        B = 3;
        num = i + 150;
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read("���丮��ҹ�");
        ���丮Ÿ��Ʋ= data_Dialog[i]["story"].ToString();
        ���丮���� = data_Dialog[i]["content"].ToString();
        �������ڸ�Ʈ = data_Dialog[i]["SucCom"].ToString();
        ���н��ڸ�Ʈ = data_Dialog[i]["FailCom"].ToString();
        �������ڸ�Ʈ = data_Dialog[i]["RejectCom"].ToString();
        

    }

    
   
    private void pickupƯ����ҹ�(int i) //Ư����ҹ���
                                         //������ ������ �ҷ����� ������ ���ǿ� ������ true�� ��ȯ, �ƴϸ� false
                                         //��ҹ� ������ ������ false ������ �ٽ� ������, true�� ���� �� ���� ������ �� ��!



    {
            B = 2; // Ư����ҹ��̶�� ��
            List<Dictionary<string, object>> data_Dialog = CSVReader.Read("Ư����ҹ�");
            ��ҹ����� = data_Dialog[i]["contents"].ToString();
            string appsucfood = data_Dialog[i]["AppSucFood"].ToString();
            �����ýķ� = float.Parse(appsucfood);
            string appsuchuman = data_Dialog[i]["AppSucHuman"].ToString();
            �������α� = float.Parse(appsuchuman);//float ���·� �ٲٱ�
            string appsucdark = data_Dialog[i]["AppSucDark"].ToString();
            ������ħ�ĵ� = float.Parse(appsucdark);//float ���·� �ٲٱ�
            string appsuchope = data_Dialog[i]["AppSucHope"].ToString();
            ��������� = float.Parse(appsuchope);//float ���·� �ٲٱ�

            string appfailfood = data_Dialog[i]["AppFailFood"].ToString();
            ���нýķ� = float.Parse(appfailfood);
            string appfailhuman = data_Dialog[i]["AppFailHuman"].ToString();
            ���н��α� = float.Parse(appfailhuman);//float ���·� �ٲٱ�
            string appfaildark = data_Dialog[i]["AppFailDark"].ToString();
            ���н�ħ�ĵ� = float.Parse(appfaildark);//float ���·� �ٲٱ�
            string appfailhope = data_Dialog[i]["AppFailHope"].ToString();
            ���н���� = float.Parse(appfailhope);//float ���·� �ٲٱ�


            string rejectfood = data_Dialog[i]["RejectFood"].ToString();
            �����ýķ� = float.Parse(rejectfood);
            string rejecthuman = data_Dialog[i]["RejectHuman"].ToString();
            �������α� = float.Parse(rejecthuman);//float ���·� �ٲٱ�
            string rejectdark = data_Dialog[i]["RejectDark"].ToString();
            ������ħ�ĵ� = float.Parse(rejectdark);//float ���·� �ٲٱ�
            string rejecthope = data_Dialog[i]["RejectHope"].ToString();
            ��������� = float.Parse(rejecthope);//float ���·� �ٲٱ�
       
           

    }




    



    public static void ����() //��ҹ� �����ÿ� ������ �Լ� 
    {
        if (B==3)
        {
            A = UnityEngine.Random.Range(0, 100);
            if ((0 <= A) && (A <= ����Ȯ��)) //�����ϸ�
            {
                if (num == 150)
                {
                    Sub1 = false;
                    fail150 = true;
                }

                else if (num == 151)
                {
                    RayAlive = false;
                    fail151 = true;
                }
                else if (num == 152)
                {
                    main1 = false;
                    fail152 = true;
                }
                else if (num == 153)
                {
                    main2 = false;
                    fail153 = true;
                }
                else if (num == 154)
                {
                    main3 = false;
                    fail154 = true;
                }
                else if (num == 155)
                {
                    main4_1 = false;
                    fail155 = true;
                }
                else if (num == 156)
                {
                    EugeneAlive = false;
                    fail156 = true;
                }

               
                
            }

            else //�����ϸ�
            {
               
                

                if (num == 150)
                {
                    Sub1 = true;
                    suc150 = true;
                    
                }

                else if (num == 151)
                {
                    RayAlive = true;
                    suc151 = true;
                }
                else if (num == 152)
                {
                    main1 = true;
                    �ð���1 = true;
                    suc152 = true;
                }
                else if (num == 153)
                {
                    main2 = true;
                    �ð���1 = false;
                    ���ð���1 = true;
                    suc153 = true;
                }
                else if (num == 154)
                {
                    main3 = true;
                    �ð���2 = true;
                    suc154 = true;
                }
                else if (num == 155)
                {
                    main4_1 = true;
                    �ð���3 = true;
                    suc155 = true;
                }
                else if (num == 156)
                {
                    EugeneAlive = true;
                    suc156 = true;
                }
            }

        }



        else
        {
            if (B == 1) // �Ϲݻ�ҹ��� ��� 
            {
                UI.Handlegage(1, ���������);
                UI.Handlegage(2, �����ýķ�);
                UI.Handlegage(3, �������α�);
                UI.Handlegage(4, ������ħ�ĵ�);
            }
            else //Ư����ҹ��� ���  ����/ ���и� ��� 
            {

                A = UnityEngine.Random.Range(0, 100);
                if ((0 <= A) && (A <= ����Ȯ��))
                {

                    UI.Handlegage(1, ���н����);
                    UI.Handlegage(2, ���нýķ�);
                    UI.Handlegage(3, ���н��α�);
                    UI.Handlegage(4, ���н�ħ�ĵ�);
                    Debug.Log("����");
                    common2 = true;

                }
                else
                {

                    UI.Handlegage(1, ���������);
                    UI.Handlegage(2, �����ýķ�);
                    UI.Handlegage(3, �������α�);
                    UI.Handlegage(4, ������ħ�ĵ�);
                    Debug.Log("����");
                    common1 = true;


                }
                
            }
        }
        
        ��ҹ�count++;
        print(��ҹ�count);
        Debug.Log(��ҹ�count);



     


    }


    public static void ��ũ��Ʈ�����Լ�()
    {
        if (stagenum == 1)

        {
            go_ScriptScene();
        }

        else if (stagenum == 3)
        {
            go_ScriptScene();
        }

        else if (stagenum == 6)
        {
            go_ScriptScene();
        }
        else if ((stagenum == 8) && (main1 == true))
        {
            go_ScriptScene();
        }
        else if ((stagenum == 11) && (main2 == true))
        {
            go_ScriptScene();
            �ð���2 = false;
            ���ð���2 = true;
        }
        else if ((stagenum == 14) && (main3 == true))
        {
            go_ScriptScene();
            �ð���3 = false;
            ���ð���3 = true;
        }
       
        else if (stagenum == 18)
        {
            if ((���ð���1==true)&& (���ð���2 == true)&& (���ð���3 == true)&&(EugeneAlive ==true))
            {
                go_ScriptScene();
            }
            else
            {
                gogoodending();
            }
        }
    }


    public static void ����() // ������ �巡�� �� ��� �ϸ� ������ �Լ� 
    {

        if (B == 3)
        {
            if (num == 150)
            {
                Sub1 = false;
                rej150 = true;
                
            }

            else if (num == 151)
            {
                RayAlive = false;
                rej151 = true;
            }
            else if (num == 152)
            {
                main1 = false;
                rej152 = true;
            }
            else if (num == 153)
            {
                main2 = false;
                rej153 = true;
            }
            else if (num == 154)
            {
                main3 = false;
                rej154 = true;
            }
            else if (num == 155)
            {
                main4_1 = false;
                rej155 = true;
            }
            else if (num == 156)
            {
                EugeneAlive = false;
                rej156 = true;
            }

        }
        else
        {
            UI.Handlegage(1, ���������);
            UI.Handlegage(2, �����ýķ�);
            UI.Handlegage(3, �������α�);
            UI.Handlegage(4, ������ħ�ĵ�);
            
            if (B==2)
            {   
                common3 = true;
            }
        
        }
        ��ҹ�count++;
        Debug.Log(��ҹ�count);
    }

    public void ������ġ��() // ������ġ�⸦ ������ �� ���������� �Ѿ�鼭 ������������ �ο��Ǵ� ������ ��°����� �ο���. // ��ҹ� count ���� 0���� �ʱ�ȭ�� �� 
    {

        ��ũ��Ʈ�����Լ�();
        stagenum++;
        timecontroller.�ð�����();
        UI.gagemechanism();
        ��ҹ�count = 0;
        ���ϸ�����Ʈ();
        for (int i = 0; i < dailySSM.Count; i++)
        {
            print(dailySSM[i]);
        }

        suc150 = false;
        fail150 = false;
        rej150 = false;
        suc151 = false;
        fail151 = false;
        rej151 = false;
        suc152 = false;
        fail152 = false;
        rej152 = false;
        suc153 = false;
        fail153 = false;
        rej153 = false;
        suc154 = false;
        fail154 = false;
        rej154 = false;
        suc155 = false;
        fail155 = false;
        rej155 = false;
        suc156 = false;
        fail156 = false;
        rej156 = false;
        common1 = false;
        common2 = false;
        common3 = false;
}

    void Update()
    {
        Invoke("��ưȰ��ȭ", 3f);
        ��������();

    }

    public void ��ưȰ��ȭ()
    {

        if (��ҹ�count >= 8)
        {
            ������ġ���ư.SetActive(true);
        }
        else
        {
            ������ġ���ư.SetActive(true);//���� false����
        }
    }
}
