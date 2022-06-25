using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteScript : MonoBehaviour
{
    public static MuteScript instance;

    public GameObject Mute;
    public GameObject Unmute;


    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }       
    }

    void Start()
    {
        /*int vol = PlayerPrefs.GetInt("audio");

        if (vol == 2)
        {
            Unmute.SetActive(true);
        }
        else if (vol == 1)
        {
            Unmute.SetActive(false);
        }*/
    }

    public void MuteGame()
    {
        PlayerPrefs.SetInt("audio",1);
        Mute.SetActive(true);
        Unmute.SetActive(false);
        Mute.GetComponent<Button>().interactable = true;
    }

    public void UnmuteGame()
    {
        PlayerPrefs.SetInt("audio",2);
        Mute.SetActive(false);
        Unmute.SetActive(true);
        Unmute.GetComponent<Button>().interactable = true;

    }

    // Update is called once per frame
    void Update()
    {
        int vol = PlayerPrefs.GetInt("audio");
        if (vol ==2)
        {
            AudioListener.volume = 1;
            Unmute.SetActive(true);
        }
        else if(vol == 1)
        {
            AudioListener.volume = 0;
            Unmute.SetActive(false);
        }
    }
}
