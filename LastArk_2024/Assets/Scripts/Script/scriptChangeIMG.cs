using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptChangeIMG : MonoBehaviour
{

    public GameObject ������, ����, ����, �ϻ�, ����, ���, �ڻ�,
        ���ȥ��, ��, ������, �ð���, ����ȭ��, å, �𷡽ð�, �ð�, ����1, ����2, ����,
        ���̵�1, ���̵�2, ���̵�3, ���̵�4;

    public void Start()
    {

        ������.SetActive(true);
        ����.SetActive(false);
        ����.SetActive(false);
        �ϻ�.SetActive(false);
        ����.SetActive(false);
        ���.SetActive(false);
        �ڻ�.SetActive(false);
        ���ȥ��.SetActive(false);
        ��.SetActive(false);
        ������.SetActive(false);
        �ð���.SetActive(false);
        ����ȭ��.SetActive(false);
        å.SetActive(false);
        �𷡽ð�.SetActive(false);
        �ð�.SetActive(false);
        ����1.SetActive(false);
        ����2.SetActive(false);
        ����.SetActive(false);
        ���̵�1.SetActive(false);
        ���̵�2.SetActive(false);
        ���̵�3.SetActive(false);
        ���̵�4.SetActive(false);

    }
    public void Update()
    {
        if (ScriptManager.count == 51)
        {
            ������.SetActive(false);
            ����.SetActive(true);
        }
        else if (ScriptManager.count == 54)
        {
            ����.SetActive(false);
            ����.SetActive(true);
        }
        else if (ScriptManager.count == 56)
        {
            ����.SetActive(false);
            �ϻ�.SetActive(true);
        }
        else if (ScriptManager.count == 59)
        {
            �ϻ�.SetActive(false);
            ����.SetActive(true);
        }
        else if (ScriptManager.count == 62)
        {
            ����.SetActive(false);
            ����.SetActive(true);
        }
        else if (ScriptManager.count == 69)
        {
            ����.SetActive(false);
            ������.SetActive(true);
        }
        else if (ScriptManager.count == 94)
        {
            ������.SetActive(false);
            ���.SetActive(true);
        }
        else if (ScriptManager.count == 103)
        {
            ���.SetActive(false);
            �ڻ�.SetActive(true);
        }
        else if (ScriptManager.count == 104)
        {
            �ڻ�.SetActive(false);
            ���.SetActive(true);
        }
        else if (ScriptManager.count == 111)
        {
            ���.SetActive(false);
            ���ȥ��.SetActive(true);
        }
        else if (ScriptManager.count == 116)
        {
            ���ȥ��.SetActive(false);
            ��.SetActive(true);
        }
        else if (ScriptManager.count == 118)
        {
            ��.SetActive(false);
            ������.SetActive(true);
        }
        else if (ScriptManager.count == 123)
        {
            ������.SetActive(false);
            ������.SetActive(true);
        }
        else if (ScriptManager.count == 126)
        {
            ������.SetActive(false);
            �ð���.SetActive(true);
        }
        else if (ScriptManager.count == 133)
        {
            �ð���.SetActive(false);
            ����ȭ��.SetActive(true);
        }
        else if (ScriptManager.count == 134)
        {
            ����ȭ��.SetActive(false);
            å.SetActive(true);
        }
        else if (ScriptManager.count == 143)
        {
            å.SetActive(false);
            ������.SetActive(true);
        }
        else if (ScriptManager.count == 151)
        {
            ������.SetActive(false);
            �𷡽ð�.SetActive(true);
        }
        else if (ScriptManager.count == 155)
        {
            �𷡽ð�.SetActive(false);
            �ð�.SetActive(true);
        }
        else if (ScriptManager.count == 161)
        {
            �ð�.SetActive(false);
            �ð���.SetActive(true);
        }
        else if (ScriptManager.count == 162)
        {
            �ð���.SetActive(false);
            ����1.SetActive(true);
        }
        else if (ScriptManager.count == 186)
        {
            ����1.SetActive(false);
            ����.SetActive(true);
        }
        else if (ScriptManager.count == 210)
        {
            ����.SetActive(false);
            ������.SetActive(true);
        }
        else if (ScriptManager.count == 236)
        {
            ������.SetActive(false);
            �ð�.SetActive(true);
        }
        else if (ScriptManager.count == 239)
        {
            �ð�.SetActive(false);
            �𷡽ð�.SetActive(true);
        }
        else if (ScriptManager.count == 240)
        {
            �𷡽ð�.SetActive(false);
            ����2.SetActive(true);
        }
        else if (ScriptManager.count == 277)
        {
            ����2.SetActive(false);
            �ð���.SetActive(true);
        }
        else if (ScriptManager.count == 283)
        {
            �ð���.SetActive(false);
            �𷡽ð�.SetActive(true);
        }
        else if (ScriptManager.count == 291)
        {
            �𷡽ð�.SetActive(false);
            �ð�.SetActive(true);
        }
        else if (ScriptManager.count == 296)
        {
            �ð�.SetActive(false);
            ���̵�1.SetActive(true);
        }
        else if (ScriptManager.count == 301)
        {
            ���̵�1.SetActive(false);
            ���.SetActive(true);
        }
        else if (ScriptManager.count == 314)
        {
            ���.SetActive(false);
            ���ȥ��.SetActive(true);
        }
        else if (ScriptManager.count == 315)
        {
            ���ȥ��.SetActive(false);
            ��.SetActive(true);
        }
        else if (ScriptManager.count == 321)
        {
            ��.SetActive(false);
            ���̵�2.SetActive(true);
        }
        else if (ScriptManager.count == 323)
        {
            ���̵�2.SetActive(false);
            ���̵�3.SetActive(true);
        }
        else if (ScriptManager.count == 325)
        {
            ���̵�3.SetActive(false);
            ���̵�4.SetActive(true);
        }

    }
}
