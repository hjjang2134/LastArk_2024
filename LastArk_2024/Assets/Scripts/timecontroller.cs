using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class timecontroller : MonoBehaviour
{
    public TextMeshProUGUI timetext;
   
    public static int year = 1054;
    public static int month =1;


    void Start ()
    {    
        timetext.text = year.ToString()+"��"+month.ToString()+"��"+"1��";
        
    }
    


    
    public static void �ð�����()
    {
        if ((month%12)!=0)
        {
            month++;
        }
        else
        {
            year++;
            month = 1;
        }
        
        if((month==7)&&(year==2024))
        {
            SceneManager.LoadScene(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timetext.text = year.ToString() + "��" + month.ToString() + "��" + "1��";
    }
}
