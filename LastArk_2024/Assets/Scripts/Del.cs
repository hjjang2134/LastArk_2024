using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Del : MonoBehaviour
{
    public GameObject ne;
    public static bool isNews = false;  // 뉴스가 생성되었나?

    void Start()
    {
        ne.SetActive(false);
    }

    void Update()
    {
        if(isNews){
            ne.SetActive(true);
            isNews = false;
        }   
    }

    public void Seen(){
        ne.SetActive(false);
    }
}
