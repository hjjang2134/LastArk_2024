using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class gagenumber : MonoBehaviour
{
    public TextMeshProUGUI �������������;
    public TextMeshProUGUI ħ�ĵ�����������;
    public TextMeshProUGUI �ķ�����������;
    public TextMeshProUGUI �α�����������;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        �������������.text = " " + UI.�����.ToString() + " / 100 ";
        �α�����������.text = " " + UI.���α�.ToString() + " / 100000 ";
        ħ�ĵ�����������.text = " " + UI.��ħ�ĵ�.ToString() + " / 100 ";
        �ķ�����������.text = " " + UI.���ķ�.ToString() + " / 1000 ";

    }
}
