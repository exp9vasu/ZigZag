using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{	 


	public static AudioClip colliderSound;
	static AudioSource audioSrc;
    // Start is called before the first frame update

    void Start()
    {
        colliderSound = Resources.Load<AudioClip> ("twinkle");
		
		audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
    }
	
	
	public static void PlaySound (string Clip){
	
		switch(Clip){

		case "twinkle":
	    audioSrc.PlayOneShot (colliderSound);
		break;
		}
	}
}
