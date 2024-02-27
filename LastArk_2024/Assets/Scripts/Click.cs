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
                print("����!");
                acceptimg.SetActive(true);
                Clipboard.����();

            }

            if (gameObject.tag.Equals("ignorestamp"))    // ����
            {
                print("����");
                ignoreimg.SetActive(true);
                Clipboard.����();
                
            }
            stampsound.Play();

            Invoke("Boxback", 1f);

            if (other.gameObject.name.Equals("Script"))
            {
                scriptPanel1.DOLocalMoveY(600, 1f).SetEase(Ease.InBack);
                Invoke("Back1", 3f);
            }

        }
        
    }

    void Boxback()
    {
        stampPanel.DOLocalMoveX(578, 1f).SetEase(Ease.InBack);
    }

    void Back1()
    {
        scriptPanel1.localPosition = new Vector2(70, -347);
        ignoreimg.SetActive(false);
        acceptimg.SetActive(false);
    }
   
}
