using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightfollow : MonoBehaviour
{
    private void Update()
    {
        // ���콺 Ŀ���� ���� ���� ��ġ�� ����
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // ������Ʈ�� ��ġ�� ���콺 Ŀ�� ��ġ�� ����
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
