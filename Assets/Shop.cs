using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static bool button1Select = false, button2Select = false;

    public static Shop instance;

    public GameObject buttonOn;
    public GameObject buttonOff;

    public int mcount;
    // int a;
    
    /*void Awake()
    {
        if (instance == null)
        {
            instance = this;
           
        }
    }*/

    void Start()
    {
        mcount = PlayerPrefs.GetInt("count");

        if (button1Select == true)
        {
            buttonOff.SetActive(false);
            buttonOn.SetActive(true);
        }
        else if (button1Select == false)
        {
            if (mcount < 10)
            {
                buttonOff.GetComponent<Button>().interactable = false;
            }
        }
        


            
    }

    public void changeButton200()
    {   
            if (mcount >= 10 && button1Select == false)
            {
                mcount = mcount - 10;
                PlayerPrefs.SetInt("count", mcount);

                button1Select = true;   

				

    			buttonOn.GetComponent<Button>().interactable = true;

            } 
        
    }

    public void master()
    {
        if (button1Select == false)
        {
            changeButton200();
            changeColor1();
            //buttonOff.SetActive(false);
            //buttonOn.SetActive(true);

        }

        else if (button1Select == true)
        {
            changeColor1();
           // buttonOff.SetActive(false);
            //buttonOn.SetActive(true);
            
        }
    }

    public void master2()
    {
        if (button2Select == false)
        {
            changeButton200();
            changeColor2();
          //  buttonOff.SetActive(false);
            //buttonOn.SetActive(true);
        }

        else if (button2Select == true)
        {
            changeColor2();
        }
    }

     
    public void changeColor1()
    {
        PlayerPrefs.SetInt("bmat",1);
    }

    public void changeColor2()
    {
        PlayerPrefs.SetInt("bmat", 2);
    }

    public void changeColor3()
    {
        PlayerPrefs.SetInt("bmat",3);   
    }
}
