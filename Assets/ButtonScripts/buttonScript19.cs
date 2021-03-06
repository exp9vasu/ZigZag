using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonScript19 : MonoBehaviour
{
	public GameObject buttonOff;
	public GameObject buttonOn;

	int mcount;

	void Start()
	{


		buttonOff.GetComponent<Button>().onClick.AddListener(TaskOnClick);

		if (PlayerPrefs.GetInt("t") == 20)
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
		if (mcount >= 500)
		{
			PlayerPrefs.SetInt("t", 20);
			buttonOff.SetActive(false);
			buttonOn.SetActive(true);
			PlayerPrefs.SetInt("bmat", 20);

			mcount = mcount - 500;
			PlayerPrefs.SetInt("count", mcount);
			PlayerPrefs.SetInt("shop", 19);
			EventSystem.current.firstSelectedGameObject = buttonOn;

			buttonOn.GetComponent<Button>().interactable = true;
			buttonOn.GetComponent<Button>().onClick.AddListener(OnClickAgain);
		}
		//Debug.Log("You have clicked the button!");
	}

	void OnClickAgain()
	{
		PlayerPrefs.SetInt("shop", 19);
		PlayerPrefs.SetInt("bmat", 20);
		EventSystem.current.firstSelectedGameObject = buttonOn;
	}
	void Update()
	{

		if (PlayerPrefs.GetInt("shop") == 19)
		{
			ColorBlock colorVar = buttonOn.GetComponent<Button>().colors;
			colorVar.selectedColor = new Color(0, 0, 0, 0);
			buttonOn.GetComponent<Button>().colors = colorVar;

			EventSystem.current.SetSelectedGameObject(buttonOn.gameObject, new BaseEventData(EventSystem.current));
		}
	}

}
