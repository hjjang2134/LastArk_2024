using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public TextMeshProUGUI pressAnyKey; //안중요함
    public float speed = 1.0f;
    
    

    void Update()
    {
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("tutorial");
            Clipboard.리스트생성();
        }

        float alpha = Mathf.PingPong(Time.time * speed, 1);
        Color currentColor = pressAnyKey.color;
        currentColor.a = alpha;
        pressAnyKey.color = currentColor;
    }
}
