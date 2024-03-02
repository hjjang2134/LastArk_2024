using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gageindecrease : MonoBehaviour
{
    public static float 희망게이지증감 = 0;
    public static float 인구게이지증감 = 0;
    public static float 식량게이지증감 = 0;
    public static float 침식도게이지증감 = 0;

   



    public TextMeshProUGUI 희망게이지증감량;
    public TextMeshProUGUI 인구게이지증감량;
    public TextMeshProUGUI 식량게이지증감량;
    public TextMeshProUGUI 침식도게이지증감량;



    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        updategagenum();
       
    }
    // Update is called once per frame
    /*void Update()
    {
        Invoke("updategagenum",2f);
        Invoke("resetgage")
        
        
        
        
    }*/
    /*IEnumerator gageinde()
    {
        Debug.Log("코루틴실행시작");
       
           
        yield return new WaitForSeconds(2f);
        resetgage();
        Debug.Log("코루틴실행중");

        
    }
    

    public void resetgage()
    {
        희망게이지증감 = 0;
        인구게이지증감 = 0;
        식량게이지증감 = 0;
        침식도게이지증감 = 0; 
    }
    */
    public void updategagenum()
    {
        if (희망게이지증감 == 0)
        {
            희망게이지증감량.text = " ";
        }
        else
        {
            if (희망게이지증감 > 0)
            {
                희망게이지증감량.text = " +" + 희망게이지증감.ToString();
            }
            else
            {
                희망게이지증감량.text = 희망게이지증감.ToString();
            }

           
        }
        if (인구게이지증감 == 0)
        {
            인구게이지증감량.text = " ";
        }
        else
        {
            if (인구게이지증감 > 0)
            {
                인구게이지증감량.text = " +" + 인구게이지증감.ToString();
            }
            else
            {
                인구게이지증감량.text = 인구게이지증감.ToString();
            }

        }
        if (식량게이지증감 == 0)
        {
            식량게이지증감량.text = " ";
        }
        else
        {
            if (식량게이지증감 > 0)
            {
                식량게이지증감량.text = " +" + 식량게이지증감.ToString();
            }
            else
            {
                식량게이지증감량.text = 식량게이지증감.ToString();
            }

        }
        if (침식도게이지증감 == 0)
        {
            침식도게이지증감량.text = " ";
        }
        else
        {
            if (침식도게이지증감 > 0)
            {
                침식도게이지증감량.text = " +" + 침식도게이지증감.ToString();
            }
            else
            {
                침식도게이지증감량.text = 침식도게이지증감.ToString();
            }

        }
       
       




    }
    public static void updategage(int which , float much )
    {
        

        if ( which == 1 )
        {
            희망게이지증감 = much;
            
            
        }
        else if ( which == 2)
        {
            인구게이지증감 = much;
            
        }
        else if (which ==3 )
        {
            식량게이지증감 = much;
           
        }
        else if (which == 4)
        {
            침식도게이지증감 = much;
          
        }
        
    }
}
