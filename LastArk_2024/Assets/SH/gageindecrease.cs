using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gageindecrease : MonoBehaviour
{
    public static float ������������� = 0;
    public static float �α����������� = 0;
    public static float �ķ����������� = 0;
    public static float ħ�ĵ����������� = 0;

   



    public TextMeshProUGUI ���������������;
    public TextMeshProUGUI �α�������������;
    public TextMeshProUGUI �ķ�������������;
    public TextMeshProUGUI ħ�ĵ�������������;



    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        updategagenum();
       
    }
    // Update is called once per frame
    /*void Update()
    {
        Invoke("updategagenum",2f);
        Invoke("resetgage")
        
        
        
        
    }*/
    /*IEnumerator gageinde()
    {
        Debug.Log("�ڷ�ƾ�������");
       
           
        yield return new WaitForSeconds(2f);
        resetgage();
        Debug.Log("�ڷ�ƾ������");

        
    }
    

    public void resetgage()
    {
        ������������� = 0;
        �α����������� = 0;
        �ķ����������� = 0;
        ħ�ĵ����������� = 0; 
    }
    */
    public void updategagenum()
    {
        if (������������� == 0)
        {
            ���������������.text = " ";
        }
        else
        {
            if (������������� > 0)
            {
                ���������������.text = " +" + �������������.ToString();
            }
            else
            {
                ���������������.text = �������������.ToString();
            }

           
        }
        if (�α����������� == 0)
        {
            �α�������������.text = " ";
        }
        else
        {
            if (�α����������� > 0)
            {
                �α�������������.text = " +" + �α�����������.ToString();
            }
            else
            {
                �α�������������.text = �α�����������.ToString();
            }

        }
        if (�ķ����������� == 0)
        {
            �ķ�������������.text = " ";
        }
        else
        {
            if (�ķ����������� > 0)
            {
                �ķ�������������.text = " +" + �ķ�����������.ToString();
            }
            else
            {
                �ķ�������������.text = �ķ�����������.ToString();
            }

        }
        if (ħ�ĵ����������� == 0)
        {
            ħ�ĵ�������������.text = " ";
        }
        else
        {
            if (ħ�ĵ����������� > 0)
            {
                ħ�ĵ�������������.text = " +" + ħ�ĵ�����������.ToString();
            }
            else
            {
                ħ�ĵ�������������.text = ħ�ĵ�����������.ToString();
            }

        }
       
       




    }
    public static void updategage(int which , float much )
    {
        

        if ( which == 1 )
        {
            ������������� = much;
            
            
        }
        else if ( which == 2)
        {
            �α����������� = much;
            
        }
        else if (which ==3 )
        {
            �ķ����������� = much;
           
        }
        else if (which == 4)
        {
            ħ�ĵ����������� = much;
          
        }
        
    }
}
