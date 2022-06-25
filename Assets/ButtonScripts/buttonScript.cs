using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonScript : MonoBehaviour
{
	public GameObject buttonOn;

	void Start()
	{
		//PlayerPrefs.SetInt("count", 5000);
        /*if (PlayerPrefs.GetInt("shop") == 0)
        {
			ShopManager.instance.Shop(buttonOn);
        }*/

			buttonOn.GetComponent<Button>().interactable = true;
			buttonOn.GetComponent<Button>().onClick.AddListener(OnClickAgain);
	}

	void OnClickAgain()
    {
		PlayerPrefs.SetInt("bmat", 1);
		//EventSystem.current.firstSelectedGameObject = buttonOn;
		PlayerPrefs.SetInt("shop", 0);
	}
	void Update()
	{
		// Compare selected gameObject with referenced Button gameObject
		if (PlayerPrefs.GetInt("shop")==0)
		{
			
			ColorBlock colorVar = buttonOn.GetComponent<Button>().colors;
			colorVar.selectedColor = new Color(0, 0, 0, 0);
			buttonOn.GetComponent<Button>().colors = colorVar;

			EventSystem.current.SetSelectedGameObject(buttonOn.gameObject, new BaseEventData(EventSystem.current));
		}
	}

}
