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
    public static bool flag = false;

    Color darkGreen = new Color(0.0f, 0.196f, 0.0f);
    Color darkRed = new Color(0.647f, 0.0f, 0.149f);




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
        통합함수();
    }
   
    // Update is called once per frame
    /*void Update()
    {
        Invoke("updategagenum",2f);
        Invoke("resetgage")
        
        
        
        
    }*/
    public void 통합함수()
    {
        if (flag == true)
        {
            updategagenum();
            Invoke("resetgage", 2f);
           
            
        }
    }
   

    public void resetgage()
    {
        희망게이지증감량.text = " ";
        인구게이지증감량.text = " ";
        식량게이지증감량.text = " ";
        침식도게이지증감량.text = " ";
        flag = false;
      
    }
    
  
 
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
                희망게이지증감량.color = Color.green;
            }
            else
            {
                희망게이지증감량.text = 희망게이지증감.ToString();
                희망게이지증감량.color = Color.red;

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
                인구게이지증감량.color = Color.green;
            }
            else
            {
                인구게이지증감량.text = 인구게이지증감.ToString();
                인구게이지증감량 .color = Color.red;    
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
                식량게이지증감량.color = Color.green;
            }
            else
            {
                식량게이지증감량.text = 식량게이지증감.ToString();
                식량게이지증감량.color = Color.red ;
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
                침식도게이지증감량.color = Color.green;
            }
            else
            {
                침식도게이지증감량.text = 침식도게이지증감.ToString();
                침식도게이지증감량.color = Color.red;
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
        flag = true;
        
    }
}
