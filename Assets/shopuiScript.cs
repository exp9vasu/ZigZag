using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shopuiScript : MonoBehaviour
{
    public TMP_Text coronaCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coronaCount.text = PlayerPrefs.GetInt("count").ToString();
    }
}
