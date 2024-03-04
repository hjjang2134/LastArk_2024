using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 뉴스 : MonoBehaviour
{
    public GameObject i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, i17, i18, i19, i20, ne;
    public static bool i1b, i2b, i3b, i4b, i5b, i6b, i7b, i8b, i9b, i10b, i11b, i12b, i13b, i14b, i15b, i16b, i17b, i18b, i19b, i20b = false;
    public bool checkEvent = false;
    public static bool isOpen = false;  // 뉴스를 열어봤으면 new 표시 사라짐
    private void Start()
    {
        Hide();
        show();
        ne.SetActive(false);
        i1b = false; i2b=false; i3b=false; i4b = false; i5b=false; i6b=false; i7b=false; i8b=false; i9b=false;
        i10b = false; i11b = false; i12b = false; i13b = false; i14b = false; i15b = false; i16b = false; i17b = false;
        i18b = false; i19b= false; i20b= false;
    }
    public void Update()
    {
        if (Clipboard.suc150 == true)
        {
            i1b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail150 == true)
        {
            i2b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej150 == true)
        {
            i3b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.suc151 == true)
        {
            i4b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail151 == true)
        {
            i5b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej151 == true)
        {
            i6b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.suc152 == true)
        {
            i7b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail152 == true)
        {
            i8b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej152 == true)
        {
            i9b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.suc153 == true)
        {
            i10b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail153 == true)
        {
            i11b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej153 == true)
        {
            i11b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.suc154 == true)
        {
            i12b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail154 == true)
        {
            i13b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej154 == true)
        {
            i13b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.suc155 == true)
        {
            i14b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail155 == true)
        {
            i15b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej155 == true)
        {
            i15b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.suc156 == true)
        {
            i16b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.fail156 == true)
        {
            i17b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.rej156 == true)
        {
            i18b = true;
            checkEvent = true;
            Check();
        }
        if (Clipboard.common1 == true)
        {
            i19b = true;
        
            Check();
        }
        if (Clipboard.common2 == true)
        {
            i20b = true;
            
            Check();
        }
        if (Clipboard.common3 == true)
        {
            i20b = true;

            Check();
        }
    }

    public void Check(){
        
        if(isOpen){ // 뉴스를 열어봤나?
            Debug.Log("들어왓나");
           // ne.SetActive(false);
            isOpen = false;
        }
    }
    public void show()
    {
        if (i1b == true)
            i1.SetActive(true);
        else if (i2b == true)
            i2.SetActive(true);
        else if (i3b == true) 
            i3.SetActive(true);
        else if (i4b == true)
            i4.SetActive(true);
        else if (i5b == true)
            i5.SetActive(true);
        else if (i6b == true)
            i6.SetActive(true);
        else if (i7b == true)
            i7.SetActive(true);
        else if (i8b == true)
            i8.SetActive(true);
        else if (i9b == true)
            i9.SetActive(true);
        else if (i10b == true)
            i10.SetActive(true);
        else if (i11b == true)
            i11.SetActive(true);
        else if (i12b == true)
            i12.SetActive(true);
        else if (i13b == true)
            i13.SetActive(true);
        else if (i14b == true)
            i14.SetActive(true);
        else if (i15b == true)
            i15.SetActive(true);
        else if (i16b == true)
            i16.SetActive(true);
        else if (i17b == true)
            i17.SetActive(true);
        else if (i18b == true)
            i18.SetActive(true);
        else if (i19b == true && checkEvent == true)
            i19.SetActive(true);
        else if (i20b == true && checkEvent == true)
            i20.SetActive(true);

    }

    public void Hide()
    {
       // ne.SetActive(true);
        i1.SetActive(false);
        i2.SetActive(false);
        i3.SetActive(false);
        i4.SetActive(false);
        i5.SetActive(false);
        i6.SetActive(false);
        i7.SetActive(false);
        i8.SetActive(false);
        i9.SetActive(false);
        i10.SetActive(false);
        i11.SetActive(false);
        i12.SetActive(false);
        i13.SetActive(false);
        i14.SetActive(false);
        i15.SetActive(false);
        i16.SetActive(false);
        i17.SetActive(false);
        i18.SetActive(false);
        i19.SetActive(false);
        i20.SetActive(false);
    }
}
