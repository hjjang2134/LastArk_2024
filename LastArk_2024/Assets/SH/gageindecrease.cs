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
    public static bool flag = false;

    Color darkGreen = new Color(0.0f, 0.196f, 0.0f);
    Color darkRed = new Color(0.647f, 0.0f, 0.149f);




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
        �����Լ�();
    }
   
    // Update is called once per frame
    /*void Update()
    {
        Invoke("updategagenum",2f);
        Invoke("resetgage")
        
        
        
        
    }*/
    public void �����Լ�()
    {
        if (flag == true)
        {
            updategagenum();
            Invoke("resetgage", 2f);
           
            
        }
    }
   

    public void resetgage()
    {
        ���������������.text = " ";
        �α�������������.text = " ";
        �ķ�������������.text = " ";
        ħ�ĵ�������������.text = " ";
        flag = false;
      
    }
    
  
 
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
                ���������������.color = Color.green;
            }
            else
            {
                ���������������.text = �������������.ToString();
                ���������������.color = Color.red;

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
                �α�������������.color = Color.green;
            }
            else
            {
                �α�������������.text = �α�����������.ToString();
                �α������������� .color = Color.red;    
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
                �ķ�������������.color = Color.green;
            }
            else
            {
                �ķ�������������.text = �ķ�����������.ToString();
                �ķ�������������.color = Color.red ;
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
                ħ�ĵ�������������.color = Color.green;
            }
            else
            {
                ħ�ĵ�������������.text = ħ�ĵ�����������.ToString();
                ħ�ĵ�������������.color = Color.red;
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
        flag = true;
        
    }
}
