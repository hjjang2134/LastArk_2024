using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler     // ����
{
    public static Vector2 DefaultPos;   // ���ƿ� ��ġ
    public static bool crash = true;   // 충돌 감지   

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)  // �巡�� ����
    {
        DefaultPos = this.transform.position;
    }
    void IDragHandler.OnDrag(PointerEventData eventData)    // �巡�� ��
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)  // �巡�� ��
    {
        Invoke("Backto", .2f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(crash){
            if(other.gameObject.name.Equals("Script")){
                crash = false;
                Backto();
            }    
        }
    }

    void Backto()
    {
        this.transform.position = DefaultPos;
    }

}
