using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebitDestroy : MonoBehaviour
{
    public GameObject buttonOff;
    public int mcount;


    // Start is called before the first frame update
    void Start()
    {
        mcount = PlayerPrefs.GetInt("count");
        if (mcount < 10)
        {
            buttonOff.GetComponent<Button>().interactable = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void debit()
    {
        if (mcount >= 10)
        {
            mcount = mcount - 10;
            PlayerPrefs.SetInt("count", mcount);

            destroy();
        }
    }

    public void destroy()
    {
        Destroy(gameObject);
    } 
}
