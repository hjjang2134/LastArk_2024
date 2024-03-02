using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class gagenumber : MonoBehaviour
{
    public TextMeshProUGUI 희망게이지숫자;
    public TextMeshProUGUI 침식도게이지숫자;
    public TextMeshProUGUI 식량게이지숫자;
    public TextMeshProUGUI 인구게이지숫자;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        희망게이지숫자.text = " " + UI.현희망.ToString() + " / 100 ";
        인구게이지숫자.text = " " + UI.현인구.ToString() + " / 100000 ";
        침식도게이지숫자.text = " " + UI.현침식도.ToString() + " / 100 ";
        식량게이지숫자.text = " " + UI.현식량.ToString() + " / 1000 ";

    }
}
