using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{
    public RectTransform stampPanel, scriptPanel1;
    public GameObject acceptimg, ignoreimg;
    public AudioSource stampsound;
    public GameObject 특상표시;
    public static int num = 0; // 상소문 갯수
    public bool isStamp = true;
    public TextMeshProUGUI scriptnum;   // 상소문 갯수
    private void Start()
    {
        ignoreimg.SetActive(false);
        acceptimg.SetActive(false);
        stampsound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Accept"))
        {
            if (gameObject.tag.Equals("acceptstamp"))    // ����
            {
                isStamp = false;
                acceptimg.SetActive(true);
                Clipboard.수락();
                Clipboard.resetB();
            }

            if (gameObject.tag.Equals("ignorestamp"))    // ����
            {
                isStamp = false;
                ignoreimg.SetActive(true);
                Clipboard.거절();

                Clipboard.resetB();
            }
            stampsound.Play();

            if (other.gameObject.name.Equals("Script")) // 상소문 처리
            {
                scriptPanel1.DOLocalMoveY(600, 1f).SetEase(Ease.InBack);             
            }

            num++;
            scriptnum.text = num + "/8";
            if(num <= 7){
                Invoke("Back1", 3f);
            }
        }
    }


    void Back1()
    {
        isStamp = true;
        scriptPanel1.localPosition = new Vector2(70, -347);
        ignoreimg.SetActive(false);
        acceptimg.SetActive(false);
    }
   
}
