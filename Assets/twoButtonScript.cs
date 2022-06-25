using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class twoButtonScript : MonoBehaviour
{
	public GameObject buttonOff;
	public GameObject buttonOn;

	public static int b1;
	
	void Start()
	{
		//Button btn = buttonOff.GetComponent<Button>();
		//btn
		buttonOff.GetComponent<Button>().onClick.AddListener(TaskOnClick);
		if (b1 == 1)
		{
			//Destroy(this.gameObject);
			buttonOff.SetActive(false);
			buttonOn.SetActive(true);
			buttonOn.GetComponent<Button>().interactable = true;

		}
		else { 
			//buttonOn.SetActive(false);
			buttonOff.GetComponent<Button>().interactable=true;

		}
		//DontDestroyOnLoad(buttonOff);
	}

	void TaskOnClick()
	{
		b1 = 1;
		//		Debug.Log("You have clicked the button!");
		PlayerPrefs.SetInt("bmat", 4);
	}


}
