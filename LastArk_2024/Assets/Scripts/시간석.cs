using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class �ð��� : MonoBehaviour
{
    public GameObject �ð���1;
    public GameObject �ð���2;
    public GameObject �ð���3;
    public GameObject ���ð���1;
    public GameObject ���ð���2;
    public GameObject ���ð���3;

    void Start()
    {
        �ð���1.SetActive(false);
        �ð���2.SetActive(false);
        �ð���3.SetActive(false);

        ���ð���1.SetActive(false);
        ���ð���2.SetActive(false);
        ���ð���3.SetActive(false);
    }
    void Update()
    {
       
         if (Clipboard.�ð���1==true)
        {
           �ð���1.SetActive(true);
        }
        else
        {
            �ð���1.SetActive(false);
        }

        if (Clipboard.�ð���2 == true)
        {
            �ð���2.SetActive(true);
        }
        else
        {
            �ð���2.SetActive(false);
        }

       
        if (Clipboard.�ð���3 == true) 
        {
            �ð���3.SetActive(true);
        }
        else
        {
            �ð���3.SetActive(false);
        }

        if (Clipboard.���ð���1 == true)
        {
            ���ð���1.SetActive(true);
        }
        else
        {
            ���ð���1.SetActive(false);
        }
        if (Clipboard.���ð���2 == true)
        {
            ���ð���2.SetActive(true);
        }
        else
        {
            ���ð���2.SetActive(false);
        }
        if (Clipboard.���ð���3 == true)
        {
            ���ð���3.SetActive(true);
        }
        else
        {
            ���ð���3.SetActive(false);
        }
    }
    
       
}
