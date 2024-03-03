using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;
//using static UnityEditorInternal.ReorderableList;

public class Click : MonoBehaviour
{
    public RectTransform stampPanel, scriptPanel1;
    public GameObject acceptimg, ignoreimg;
    public AudioSource stampsound;
    public GameObject 특상표시;
    public bool isStamp = true;
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
            if (isStamp && gameObject.tag.Equals("acceptstamp"))    // ����
            {
                isStamp = false;
                acceptimg.SetActive(true);
                Clipboard.수락();
                특상표시.SetActive(false);
            }

            if (isStamp && gameObject.tag.Equals("ignorestamp"))    // ����
            {
                isStamp = false;
                ignoreimg.SetActive(true);
                Clipboard.거절();
                특상표시.SetActive(false);
            }
            stampsound.Play();

            if (other.gameObject.name.Equals("Script"))
            {
                scriptPanel1.DOLocalMoveY(600, 1f).SetEase(Ease.InBack);
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
