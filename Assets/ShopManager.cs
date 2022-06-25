using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;
    public GameObject b;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("shop") == 1)
        {
            Shop(b);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Shop(GameObject x)
    {
        if (EventSystem.current.currentSelectedGameObject == x)
        {
            ColorBlock colorVar = x.GetComponent<Button>().colors;
            colorVar.selectedColor = new Color(0, 0, 0, 0);
            x.GetComponent<Button>().colors = colorVar;
        }
    }
}
