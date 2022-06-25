using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    public EventSystem evs;
    public static GameObject first;
    // Use this for initialization
    //[System.Obsolete]
    void Awake()
    {
        first = GameObject.Find("First Selected");

        first = EventSystem.current.firstSelectedGameObject;
        
        // evs = GameObject.Find("EventSystem").GetComponent<EventSystem>();
        DontDestroyOnLoad(first);
    }
}