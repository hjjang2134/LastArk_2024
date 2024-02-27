using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Drop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler     // ����
{
    public static Vector2 DefaultPos;   // ���ƿ� ��ġ

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

    void Backto()
    {
        this.transform.position = DefaultPos;
    }

}
