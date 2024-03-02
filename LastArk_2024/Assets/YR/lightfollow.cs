using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightfollow : MonoBehaviour
{
    private void Update()
    {
        // 마우스 커서의 월드 공간 위치를 저장
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // 오브젝트의 위치를 마우스 커서 위치로 설정
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }
}
