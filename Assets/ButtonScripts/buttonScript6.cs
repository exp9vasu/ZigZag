using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonScript6 : MonoBehaviour
{
	public GameObject buttonOff;
	public GameObject buttonOn;

	int mcount;

	void Start()
	{

		buttonOff.GetComponent<Button>().onClick.AddListener(TaskOnClick);
		
		if (PlayerPrefs.GetInt("g") == 7)
		{
			buttonOff.SetActive(false);
			buttonOn.SetActive(true);
			buttonOn.GetComponent<Button>().interactable = true;
			buttonOn.GetComponent<Button>().onClick.AddListener(OnClickAgain);
		}
		else
		{
			//buttonOn.SetActive(false);
			buttonOff.GetComponent<Button>().interactable = true;

		}
	
	}

	void TaskOnClick()
	{
		mcount = PlayerPrefs.GetInt("count");
		if (mcount >= 200)
		{
			PlayerPrefs.SetInt("g", 7);
			buttonOff.SetActive(false);
			buttonOn.SetActive(true);
			PlayerPrefs.SetInt("bmat", 7);

			mcount = mcount - 200;
			PlayerPrefs.SetInt("count", mcount);
			EventSystem.current.firstSelectedGameObject = buttonOn;
			PlayerPrefs.SetInt("shop", 6);

			buttonOn.GetComponent<Button>().interactable = true;
			buttonOn.GetComponent<Button>().onClick.AddListener(OnClickAgain);
		}
		//Debug.Log("You have clicked the button!");
	}

	void OnClickAgain()
    {
		PlayerPrefs.SetInt("bmat", 7);
		EventSystem.current.firstSelectedGameObject = buttonOn;
		PlayerPrefs.SetInt("shop", 6);
	}
	void Update()
	{

		if (PlayerPrefs.GetInt("shop")==6)
		{
			ColorBlock colorVar = buttonOn.GetComponent<Button>().colors;
			colorVar.selectedColor = new Color(0, 0, 0, 0);
			buttonOn.GetComponent<Button>().colors = colorVar;

			EventSystem.current.SetSelectedGameObject(buttonOn.gameObject, new BaseEventData(EventSystem.current));
		}
	}

}
