using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Del : MonoBehaviour
{
    public TextMeshProUGUI ne;
    public static bool isNews = false;  // 뉴스가 생성되었나?

    void Start()
    {
        ne.text = "";
    }

    void Update()
    {
        if(isNews){
            ne.text = "N";
            isNews = false;
        }   
    }

    public void Seen(){
        ne.text = "";
    }
}
