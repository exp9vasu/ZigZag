using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonScript1 : MonoBehaviour
{
	public GameObject buttonOff;
	public GameObject buttonOn;
	public static buttonScript1 instance;

	int mcount;

    private void Awake()
    {
        if(instance = null)
        {
			instance = this;
			DontDestroyOnLoad(EventSystem.current.firstSelectedGameObject);
        }
    }

    void Start()
	{
		
		buttonOff.GetComponent<Button>().onClick.AddListener(TaskOnClick);
		
		if (PlayerPrefs.GetInt("b") == 2)
		{
			buttonOff.SetActive(false);
			buttonOn.SetActive(true);
			buttonOn.GetComponent<Button>().interactable = true;
			buttonOn.GetComponent<Button>().onClick.AddListener(OnClickAgain);
		}
		else
		{
			buttonOff.GetComponent<Button>().interactable = true;
		}
	}

	void TaskOnClick()
	{
		mcount = PlayerPrefs.GetInt("count");
		if (mcount >= 100)
		{
			PlayerPrefs.SetInt("b",2);
			buttonOff.SetActive(false);
			buttonOn.SetActive(true);
			PlayerPrefs.SetInt("bmat", 2);

			mcount = mcount - 100;
			PlayerPrefs.SetInt("count", mcount);
			EventSystem.current.firstSelectedGameObject = buttonOn;
			PlayerPrefs.SetInt("shop",1);

			buttonOn.GetComponent<Button>().interactable = true;
			buttonOn.GetComponent<Button>().onClick.AddListener(OnClickAgain);
		}
		//Debug.Log("You have clicked the button!")
	}

	void OnClickAgain()
    {
		PlayerPrefs.SetInt("bmat", 2);
		EventSystem.current.firstSelectedGameObject = buttonOn;
		PlayerPrefs.SetInt("shop", 1);
	}

    void Update()
	{	
		// Compare selected gameObject with referenced Button gameObject
		if (PlayerPrefs.GetInt("shop") == 1)
		{
			ColorBlock colorVar = buttonOn.GetComponent<Button>().colors;
			colorVar.selectedColor = new Color(0, 0, 0, 0);
			buttonOn.GetComponent<Button>().colors = colorVar;

			EventSystem.current.SetSelectedGameObject(buttonOn.gameObject, new BaseEventData(EventSystem.current));
		}

        if (buttonOn )//&& PlayerPrefs.GetInt("shop") == 1) 
        {

			ColorBlock colorVar = buttonOn.GetComponent<Button>().colors;
			colorVar.selectedColor = new Color(0, 0, 0, 0);
			buttonOn.GetComponent<Button>().colors = colorVar;
		}
	}
}
