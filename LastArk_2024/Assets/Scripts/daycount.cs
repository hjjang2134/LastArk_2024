using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class daycount : MonoBehaviour
{
    // Start is called before the first frame update
   
    public TextMeshProUGUI text1;
    void Start()
    {
        text1.text= Clipboard.stagenum.ToString();
        StartCoroutine(SceneMove());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator SceneMove()
    {
            yield return new WaitForSeconds(2.0f);
        
        SceneManager.LoadScene("Main Scene");
        
    }
}
