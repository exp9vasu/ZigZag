using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public Material bm1;
    public Material bm2;
    public Material bm3;
    public Material bm4;
    public Material bm5;
    public Material bm6;
    public Material bm7;
    public Material bm8;
    public Material bm9;
    public Material bm10;
    public Material bm11;
    public Material bm12;
    public Material bm13;
    public Material bm14;
    public Material bm15;
    public Material bm16;
    public Material bm17;
    public Material bm18;
    public Material bm19;
    public Material bm20;
    public Material bm21;
    public Material bm22;
    public Material bm23;
    public Material bm24;
    public Material bm25;
    public Material bm26;
    public Material bm27;
    public Material bm28;
    public Material bm29;
    public Material bm30;


    public int bm;

    // Start is called before the first frame update
    void Start()
    {
        bm = PlayerPrefs.GetInt("bmat");
        changeColor();
    }

    public void changeColor()
    {
        if (bm == 0)
        {
            GetComponent<Renderer>().material = bm1;
        }

        if (bm == 1)
        {
            GetComponent<Renderer>().material = bm1;
        }

        if (bm == 2)
        {
            GetComponent<Renderer>().material = bm2;
        }

        if (bm == 3)
        {
            GetComponent<Renderer>().material = bm3;
        }

        if (bm == 4)
        {
            GetComponent<Renderer>().material = bm4;
        }

        if (bm == 5)
        {
            GetComponent<Renderer>().material = bm5;
        }

        if (bm == 6)
        {
            GetComponent<Renderer>().material = bm6;
        }
        if (bm == 7)
        {
            GetComponent<Renderer>().material = bm7;
        }
        if (bm == 8)
        {
            GetComponent<Renderer>().material = bm8;
        }
        if (bm == 9)
        {
            GetComponent<Renderer>().material = bm9;
        }
        if (bm == 10)
        {
            GetComponent<Renderer>().material = bm10;
        }
        if (bm == 11)
        {
            GetComponent<Renderer>().material = bm11;
        }
        if (bm == 12)
        {
            GetComponent<Renderer>().material = bm12;
        }
        if (bm == 13)
        {
            GetComponent<Renderer>().material = bm13;
        }
        if (bm == 14)
        {
            GetComponent<Renderer>().material = bm14;
        }
        if (bm == 15)
        {
            GetComponent<Renderer>().material = bm15;
        }
        if (bm == 16)
        {
            GetComponent<Renderer>().material = bm16;
        }
        if (bm == 17)
        {
            GetComponent<Renderer>().material = bm17;
        }
        if (bm == 18)
        {
            GetComponent<Renderer>().material = bm18;
        }
        if (bm == 19)
        {
            GetComponent<Renderer>().material = bm19;
        }
        if (bm == 20)
        {
            GetComponent<Renderer>().material = bm20;
        }
        if (bm == 21)
        {
            GetComponent<Renderer>().material = bm21;
        }
        if (bm == 22)
        {
            GetComponent<Renderer>().material = bm22;
        }
        if (bm == 23)
        {
            GetComponent<Renderer>().material = bm23;
        }
        if (bm == 24)
        {
            GetComponent<Renderer>().material = bm24;
        }
        if (bm == 25)
        {
            GetComponent<Renderer>().material = bm25;
        }
        if (bm == 26)
        {
            GetComponent<Renderer>().material = bm26;
        }
        if (bm == 27)
        {
            GetComponent<Renderer>().material = bm27;
        }
        if (bm == 28)
        {
            GetComponent<Renderer>().material = bm28;
        }
        if (bm == 29)
        {
            GetComponent<Renderer>().material = bm29;
        }
        if (bm == 30)
        {
            GetComponent<Renderer>().material = bm30;
        }
    }

    // Update is called once per frame
}
