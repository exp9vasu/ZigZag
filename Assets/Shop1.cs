using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop1 : MonoBehaviour
{
    public GameObject buttonOn;

    public int mcount;

    int num;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        mcount = PlayerPrefs.GetInt("count");
        num = PlayerPrefs.GetInt("num");

        change();

        buttonOn.GetComponent<Button>().interactable = true;

        if (mcount < 50)
        {
            buttonOn.GetComponent<Button>().interactable = false;
        }


    }

    public void changeButton200()
    {
       

        if (mcount >= 50)
        {
            mcount = mcount - 50;
            PlayerPrefs.SetInt("count", mcount);
        }

       
    
    }

    public void changeColor1()
    {
        PlayerPrefs.SetInt("bmat", 1);
        PlayerPrefs.SetInt("num", 1);
        
    }

    public void changeColor2()
    {
        PlayerPrefs.SetInt("bmat", 2);
        PlayerPrefs.SetInt("num", 2);

        
    }

    public void changeColor3()
    {
        PlayerPrefs.SetInt("bmat", 3);
        PlayerPrefs.SetInt("num", 3);
    }
    public void changeColor4()
    {
        PlayerPrefs.SetInt("bmat", 4);
        PlayerPrefs.SetInt("num", 4);
    }
    public void changeColor5()
    {
        PlayerPrefs.SetInt("bmat", 5);
        PlayerPrefs.SetInt("num", 5);
    }
    public void changeColor6()
    {
        PlayerPrefs.SetInt("bmat", 6);
        PlayerPrefs.SetInt("num", 6);
    }
    public void changeColor7()
    {
        PlayerPrefs.SetInt("bmat", 7);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor8()
    {
        PlayerPrefs.SetInt("bmat", 8);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor9()
    {
        PlayerPrefs.SetInt("bmat", 9);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor10()
    {
        PlayerPrefs.SetInt("bmat", 10);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor11()
    {
        PlayerPrefs.SetInt("bmat", 11);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor12()
    {
        PlayerPrefs.SetInt("bmat", 12);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor13()
    {
        PlayerPrefs.SetInt("bmat", 13);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor14()
    {
        PlayerPrefs.SetInt("bmat", 14);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor15()
    {
        PlayerPrefs.SetInt("bmat", 15);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor16()
    {
        PlayerPrefs.SetInt("bmat", 16);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor17()
    {
        PlayerPrefs.SetInt("bmat", 17);
        PlayerPrefs.SetInt("num", 1);
    }
    public void changeColor18()
    {
        PlayerPrefs.SetInt("bmat", 18);
        PlayerPrefs.SetInt("num", 1);
    }


    public void change()
    {
        if (num!=1)
        {
            changeButton200();
        }
    }
}
