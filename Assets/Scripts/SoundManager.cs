using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	
	public Sound [] sounds;
    // Start is called before the first frame update
    
	
	public static SoundManager instance;
	
	void Awake()
    {
		if(instance == null)
			instance = this;
		else 
		{
			Destroy(gameObject);
			return;
		}
		
		DontDestroyOnLoad(gameObject);
		
    foreach (Sound s in sounds)    
    { 	
	
		s.source = gameObject.AddComponent<AudioSource>();
		s.source.clip = s.clip;
		s.source.volume =s.volume;
	}
	}
    // Update is called once per frame
    public void Play (string name)
    {
		Sound s = Array.Find(sounds, sound => sound.name == name);
		s.source.Play();
	}

	public void Mute (string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		s.source.Stop();
	}

}
