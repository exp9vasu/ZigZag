using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Shop2 : MonoBehaviour
{
    public GameObject buttonOn;
    public GameObject buttonOff;
    
    public int mcount;
    public static int num;

    // Start is called before the first frame update

    void Start()
    {
        mcount = PlayerPrefs.GetInt("count");
        
        if(num == 1)
        {
            buttonOff.SetActive(false);
            buttonOn.SetActive(true);

        }
        else if(num ==0)
        {
            buttonOff.GetComponent<Button>().interactable = false;
        }
        
    }

    /*    public void changeButton()
        {
            if (mcount >= 10 && num ==0 )
            {
                mcount = mcount - 10;
                PlayerPrefs.SetInt("count", mcount);

                buttonOff.SetActive(false);
                buttonOn.SetActive(true);
                num = 1;
            }
            else 
            {
                if(num==0 && mcount<10)
                {   

                    buttonOff.GetComponent<Button>().interactable = false;
                }
            }
        }

        public void changeColor()
        {
            PlayerPrefs.SetInt("bmat",3);
        }*/

    public void change1()
    {
        num = 1;
    }
}