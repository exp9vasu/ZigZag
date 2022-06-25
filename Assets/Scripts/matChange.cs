using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matChange : MonoBehaviour
{
    public Material a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,t,u,v,w,x,y,z;   

    int score;

    void Start()
    {
        //GetComponent<Renderer>().material = t;
    }

    void Update()
    {
        //ChangethePlatform(); 
            Materialchange();
        
    }

    /*public void ChangethePlatform()
    {
        InvokeRepeating("Materialchange",15f,10f);
    }*/
     
    public void Materialchange() {
        //score = PlayerPrefs.GetInt("score");

        score = ScoreManager.instance.score;

        if (score < 30)
        {
            GetComponent<Renderer>().material = t;
        }

        else if (score >=30  && score < 70)
        {
            GetComponent<Renderer>().material = u;
        }

        else if (score >= 70 && score < 110)
        {
            GetComponent<Renderer>().material = v;
        }

        else if (score >= 110 && score < 150)
        {
            GetComponent<Renderer>().material = w;
        }

        else if (score >= 150 && score < 190)
        {
            GetComponent<Renderer>().material = x;
        }

        else if (score >= 190 && score < 230)
        {
            GetComponent<Renderer>().material = y;
        }

        else if (score >= 230 && score < 270)
        {
            GetComponent<Renderer>().material = a;
        }

        else if (score >= 270 && score < 310)
        {
            GetComponent<Renderer>().material = b;
        }
        else if (score >= 310 && score < 350)
        {
            GetComponent<Renderer>().material = c;
        }
        else if (score >= 350 && score < 400)
        {
            GetComponent<Renderer>().material = d;
        }
        else if (score >= 400 && score < 450)
        {
            GetComponent<Renderer>().material = e;
        }
        else if (score >= 450 && score < 500)
        {
            GetComponent<Renderer>().material = f;
        }
        else if (score >= 500 && score < 550)
        {
            GetComponent<Renderer>().material = g;
        }
        else if (score >= 550 && score < 600)
        {
            GetComponent<Renderer>().material = h;
        }
        else if (score >= 600 && score < 650)
        {
            GetComponent<Renderer>().material = i;
        }
        else if (score >= 650 && score < 700)
        {
            GetComponent<Renderer>().material = j;
        }
        else if (score >= 700 && score < 770)
        {
            GetComponent<Renderer>().material = k;
        }
        else if (score >= 770 && score < 840)
        {
            GetComponent<Renderer>().material = l;
        }
        else if (score >= 840 && score < 910)
        {
            GetComponent<Renderer>().material = m;
        }
        else if (score >= 910 && score < 980)
        {
            GetComponent<Renderer>().material = n;
        }
        else if (score >= 980 && score < 1050)
        {
            GetComponent<Renderer>().material = o;
        }
        else if (score >= 1050 && score < 1120)
        {
            GetComponent<Renderer>().material = p;
        }
        else if (score >= 1120 && score < 1200)
        {
            GetComponent<Renderer>().material = q;
        }
        else if (score >= 1200 && score < 1300)
        {
            GetComponent<Renderer>().material = r;
        }
        else if (score >= 1300 && score < 1400)
        {
            GetComponent<Renderer>().material = t;
        }
        else if (score >= 1400 && score < 1500)
        {
            GetComponent<Renderer>().material = u;
        }

        else if (score >= 1500 && score < 1600)
        {
            GetComponent<Renderer>().material = v;
        }

        else if (score >= 1600 && score < 1750)
        {
            GetComponent<Renderer>().material = w;
        }

        else if (score >= 1750 && score < 1900)
        {
            GetComponent<Renderer>().material = x;
        }

        else if (score >= 1900 && score < 2100)
        {
            GetComponent<Renderer>().material = y;
        }

        else if (score >= 2100 && score < 2400)
        {
            GetComponent<Renderer>().material = a;
        }

        else if (score >= 2400 && score < 2700)
        {
            GetComponent<Renderer>().material = b;
        }
        else if (score >= 2700 && score < 3000)
        {
            GetComponent<Renderer>().material = c;
        }
        else if (score >= 3000 && score < 3300)
        {
            GetComponent<Renderer>().material = d;
        }
        else if (score >= 3300 && score < 3600)
        {
            GetComponent<Renderer>().material = e;
        }
        else if (score >= 3600 && score < 3900)
        {
            GetComponent<Renderer>().material = f;
        }
        else if (score >= 3900 && score < 4400)
        {
            GetComponent<Renderer>().material = g;
        }
        else if (score >= 4400 && score < 5500)
        {
            GetComponent<Renderer>().material = h;
        }
        else if (score >= 5500 && score < 6600)
        {
            GetComponent<Renderer>().material = i;
        }
        else if (score >= 7200 && score < 8000)
        {
            GetComponent<Renderer>().material = j;
        }
        else if (score >= 8000 && score < 9000)
        {
            GetComponent<Renderer>().material = k;
        }
        else if (score >= 9000 && score < 10000)
        {
            GetComponent<Renderer>().material = l;
        }
        else if (score >= 10000 && score < 11000)
        {
            GetComponent<Renderer>().material = m;
        }
        else if (score >= 11000 && score < 12000)
        {
            GetComponent<Renderer>().material = n;
        }
        else if (score >= 12000 && score < 13000)
        {
            GetComponent<Renderer>().material = o;
        }
        else if (score >= 13000 && score < 15000)
        {
            GetComponent<Renderer>().material = p;
        }
        else if (score >= 15000 && score < 18000)
        {
            GetComponent<Renderer>().material = q;
        }
        else if (score >= 18000 && score < 21000)
        {
            GetComponent<Renderer>().material = r;
        }
        else if (score >= 21000 && score < 24000)
        {
            GetComponent<Renderer>().material = t;
        }
        else if (score >= 24000 && score < 27000)
        {
            GetComponent<Renderer>().material = u;
        }
        else if (score >= 27000 && score < 30000)
        {
            GetComponent<Renderer>().material = v;
        }
        else if (score >= 30000 && score < 33000)
        {
            GetComponent<Renderer>().material = w;
        }
        else if (score >= 33000 && score < 36000)
        {
            GetComponent<Renderer>().material = x;
        }
        else if (score >= 36000 && score < 39000)
        {
            GetComponent<Renderer>().material = y;
        }
        else if (score >= 39000 && score < 42000)
        {
            GetComponent<Renderer>().material = z;
        }
        else if (score >= 42000 && score < 45000)
        {
            GetComponent<Renderer>().material = a;
        }
        else if (score >= 45000 && score < 48000)
        {
            GetComponent<Renderer>().material = b;
        }
        else if (score >= 48000 && score < 51000)
        {
            GetComponent<Renderer>().material = c;
        }
        else if (score >= 51000 && score < 54000)
        {
            GetComponent<Renderer>().material = d;
        }
        else if (score >= 54000 && score < 57000)
        {
            GetComponent<Renderer>().material = e;
        }
        else if (score >= 57000 && score < 60000)
        {
            GetComponent<Renderer>().material = f;
        }
        else if (score >= 60000 && score < 63000)
        {
            GetComponent<Renderer>().material = t;
        }
        else if (score >= 63000 && score < 66000)
        {
            GetComponent<Renderer>().material = u;
        }
        else if (score >= 66000 && score < 69000)
        {
            GetComponent<Renderer>().material = v;
        }
        else if (score >= 69000 && score < 72000)
        {
            GetComponent<Renderer>().material = w;
        }
        else if (score >= 72000 && score < 75000)
        {
            GetComponent<Renderer>().material = x;
        }
        else if (score >= 75000 && score < 78000)
        {
            GetComponent<Renderer>().material = y;
        }
        else if (score >= 78000 && score < 81000)
        {
            GetComponent<Renderer>().material = z;
        }
        else if (score >= 81000 && score < 84000)
        {
            GetComponent<Renderer>().material = a;
        }
        else if (score >= 84000 && score < 87000)
        {
            GetComponent<Renderer>().material = b;
        }
        else if (score >= 87000 && score < 90000)
        {
            GetComponent<Renderer>().material = c;
        }
        else if (score >= 90000 && score < 92000)
        {
            GetComponent<Renderer>().material = d;
        }
        else if (score >= 92000 && score < 94000)
        {
            GetComponent<Renderer>().material = e;
        }
        else if (score >= 94000 && score < 96000)
        {
            GetComponent<Renderer>().material = f;
        }
        else if (score >= 96000 && score <98000)
        { 
            GetComponent<Renderer>().material = g; 
        }
        else
        { 
            GetComponent<Renderer>().material = z; 
        }
    }

}
