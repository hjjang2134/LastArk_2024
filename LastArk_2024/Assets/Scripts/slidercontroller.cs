using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class slidercontroller : MonoBehaviour
{
    [SerializeField]
    private Slider ���;
    [SerializeField]
    private Slider �ķ�;
    [SerializeField]
    private Slider �α�;
    [SerializeField]
    private Slider ħ�ĵ�;

    private float slider_��� = UI.�����;
    private float slider_�ķ� = UI.���ķ�;
    private float slider_�α� = UI.���α�;
    private float slider_ħ�ĵ� = UI.��ħ�ĵ�;

    public void buttononlcick()
    {
        UI.Handlegage(1, -20);
        
    }


    // Start is called before the first frame update
    void Start()
    {

       
        ���.value = (float)slider_��� /100;
        �ķ�.value = (float)slider_�ķ� /1000;
        �α�.value = (float)slider_�α� /100000;
        ħ�ĵ�.value = (float)slider_ħ�ĵ� /100;
    }

    // Update is called once per frame
    void Update()
    {
        slider_��� = UI.�����;
        slider_�ķ� = UI.���ķ�;
        slider_�α� = UI.���α�;
        slider_ħ�ĵ� = UI.��ħ�ĵ�;


        ���.value = (float)slider_��� / 100;
        �ķ�.value = (float)slider_�ķ� / 1000;
        �α�.value = (float)slider_�α� / 100000;
        ħ�ĵ�.value = (float)slider_ħ�ĵ� / 100;

    }
}
