using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public RectTransform stampPanel, scriptPanel1;
    public GameObject acceptimg, ignoreimg;
    public AudioSource stampsound;
    public GameObject 특상표시;
    public static int num = 0; // 상소문 갯수
    public static bool nextday = false;  // 씬 reloading없이 다음날
    public TextMeshProUGUI scriptnum;   // 상소문 갯수
    public static Vector2 DefaultPos;   // 처음 위치
    public static bool crash = true;   // 충돌 감지  
    private void Start()
    {
        ignoreimg.SetActive(false);
        acceptimg.SetActive(false);
        stampsound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(nextday){
            Invoke("Back1", 2f);
            Invoke("Settext", 2f);
            nextday = false;
        }
    } 

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)  // 드래그 시작
    {
        DefaultPos = this.transform.position;
        crash = true;
    }
    void IDragHandler.OnDrag(PointerEventData eventData)    // 드래그 중
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)  // 드래그 끝나면!
    {
        Backto();
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        if(crash){
            if(other.gameObject.name.Equals("Script")){
                crash = false;
                Backto();
            }    
        }
    }*/

    void Backto()   // 원위치로
    {
        this.transform.position = DefaultPos;
    }

    void Settext(){ // 상소문 갯수 초기화
        scriptnum.text = "0/8";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (crash && other.gameObject.tag.Equals("Accept"))
        {
            if (gameObject.tag.Equals("acceptstamp"))    // 수락
            {
                acceptimg.SetActive(true);
                Clipboard.수락();
                Clipboard.resetB();
                crash = false;
            }

            if (gameObject.tag.Equals("ignorestamp"))    // 거절
            {
                ignoreimg.SetActive(true);
                Clipboard.거절();
                Clipboard.resetB();
                crash = false;
            }
            stampsound.Play();

            if (other.gameObject.name.Equals("Script")) // 상소문 처리
            {
                scriptPanel1.DOLocalMoveY(600, 1f).SetEase(Ease.InBack);             
            }

            num++;
            scriptnum.text = num + "/8";
            if(num <= 7){
                Invoke("Back1", 2f);
            }
        }
    }

    public void Back1()  // 상소문 밑으로
    {
        scriptPanel1.localPosition = new Vector2(70, -347);
        ignoreimg.SetActive(false);
        acceptimg.SetActive(false);
        특상표시.SetActive(false);
    }
   
}
