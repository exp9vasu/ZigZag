using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.LowLevel;

public class BallController : MonoBehaviour
{
	public static BallController instance;

	public GameObject particle;

    [SerializeField]
	public float speed;
	public bool started; 
	public bool gameOver;

	public TMP_Text tCoronaText;
	public TMP_Text xSpeed;

	public int score; 
	public int count;

	Rigidbody rb;

	public AudioSource soundsource;
	public AudioClip fallclip;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();

		if (instance == null)
		{
			instance = this;
        }

	}
	// Start is called before the first frame update
    void Start()
	{
		rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;

		tCoronaText.text = PlayerPrefs.GetInt("count").ToString();
		count = PlayerPrefs.GetInt("count");

		speed = 10.0f;

		started = false;
		gameOver = false;
    }

	// Update is called once per frame
	void Update()
	{
		//MonoBehaviour.print("time"+ Time.time);
		//MonoBehaviour.print("LoadTime"+ Time.timeSinceLevelLoad);

		if (!started)
		{
			if (Input.GetMouseButtonDown(0))
			{
				rb.velocity = new Vector3(speed, 0, 0);
				started = true;

				GameManager.instance.GameStart();

				FindObjectOfType<SoundManager>().Play("music");
				FindObjectOfType<AudioSource>().loop = true;
			}
		}

		if (!Physics.Raycast(transform.position, Vector3.down, 0.8f))
		{

			rb.constraints = RigidbodyConstraints.None;

			gameOver = true;

			rb.velocity = new Vector3(0, -25f, 0);

			Camera.main.GetComponent<CameraFollow>().gameOver = true;

			GameManager.instance.GameOver();

		}

		if (Input.GetMouseButtonDown(0) && !gameOver)
		{
			SwitchDirection();
		}

		ChangeSpeed();

	}

	public void PlayFall()
    {
		soundsource.PlayOneShot(fallclip);
    }

	public void MuteFall()
    {
		soundsource.mute = true;
    }

	void ChangeSpeed() {
		score = ScoreManager.instance.score;

		if (score < 30)
		{
			Time.timeScale = 1.0f;
			//FindObjectOfType<AudioSource>().pitch =Time.timeScale;
			//speed = 11f;
			FindObjectOfType<AudioSource>().pitch = 1.0f;
			xSpeed.text = "x"+ 1;

		}

		else if (score >= 30 && score < 70)
		{
			Time.timeScale = 1.1f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 12f;
			FindObjectOfType<AudioSource>().pitch = 1.1f;
			xSpeed.text = "x" + 2;
		}

		else if (score >= 70 && score < 110)
		{
			Time.timeScale = 1.2f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 12.5f;
			FindObjectOfType<AudioSource>().pitch = 1.2f;
			xSpeed.text = "x" + 3;
		}

		else if (score >= 110 && score < 150)
		{
			Time.timeScale = 1.25f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 13.0f;
			FindObjectOfType<AudioSource>().pitch = 1.25f;
			xSpeed.text = "x" + 4;
		}

		else if (score >= 150 && score < 190)
		{
			Time.timeScale = 1.3f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 13.25f;
			FindObjectOfType<AudioSource>().pitch = 1.3f;
			xSpeed.text = "x" + 5;
		}

		else if (score >= 190 && score < 230)
		{
			Time.timeScale = 1.325f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 13.5f;
			FindObjectOfType<AudioSource>().pitch = 1.325f;
			xSpeed.text = "x" + 6;
		}
		else if (score >= 230 && score < 270)
		{
			Time.timeScale = 1.35f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 13.75f;
			FindObjectOfType<AudioSource>().pitch = 1.35f;
			xSpeed.text = "x" + 7;
		}

		else if (score >= 270 && score < 310)
		{
			Time.timeScale = 1.375f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 14f;
			FindObjectOfType<AudioSource>().pitch = 1.375f;
			xSpeed.text = "x" + 8;
		}

		else if (score >= 310 && score < 350)
		{
			Time.timeScale = 1.4f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 14.25f;
			FindObjectOfType<AudioSource>().pitch = 1.4f;
			xSpeed.text = "x" + 9;
		}

		else if (score >= 350 && score < 400)
		{
			Time.timeScale = 1.425f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 11.25f;
			//speed = 14.5f;
			FindObjectOfType<AudioSource>().pitch = 1.425f;
			xSpeed.text = "x" + 10;
		}

		else if (score >= 400 && score < 450)
		{
			Time.timeScale = 1.45f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 14.75f;
			FindObjectOfType<AudioSource>().pitch = 1.45f;
			xSpeed.text = "x" + 11;
		}

		else if (score >= 450 && score < 500)
		{
			Time.timeScale = 1.475f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 15.0f;
			FindObjectOfType<AudioSource>().pitch = 1.475f;
			xSpeed.text = "x" + 12;
		}

		else if (score >= 500 && score < 550)
		{
			Time.timeScale = 1.5f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 15.25f;
			FindObjectOfType<AudioSource>().pitch = 1.5f;
			xSpeed.text = "x" + 13;
		}

		else if (score >= 550 && score < 600)
		{
			Time.timeScale = 1.525f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 15.5f;
			FindObjectOfType<AudioSource>().pitch = 1.525f;
			xSpeed.text = "x" + 14;
		}

		else if (score >= 600 && score < 650)
		{
			Time.timeScale = 1.55f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 15.75f;
			FindObjectOfType<AudioSource>().pitch = 1.55f;
			xSpeed.text = "x" + 15;
		}

		else if (score >= 650 && score < 700)
		{
			Time.timeScale = 1.575f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 16f;
			FindObjectOfType<AudioSource>().pitch = 1.575f;
			xSpeed.text = "x" + 16;
		}

		else if (score >= 700 && score < 770)
		{
			Time.timeScale = 1.600f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 16.2f;
			FindObjectOfType<AudioSource>().pitch = 1.6f;
			xSpeed.text = "x" + 17;
		}
		else if (score >= 770 && score < 840)
		{
			Time.timeScale = 1.625f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 16.4f;
			FindObjectOfType<AudioSource>().pitch = 1.625f;
			xSpeed.text = "x" + 18;
		}
		else if (score >= 840 && score < 910)
		{
			Time.timeScale = 1.65f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 16.6f;
			FindObjectOfType<AudioSource>().pitch = 1.65f;
			xSpeed.text = "x" + 19;
		}
		else if (score >= 910 && score < 980)
		{
			Time.timeScale = 1.675f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 16.8f;
			FindObjectOfType<AudioSource>().pitch = 1.675f;
			xSpeed.text = "x" + 20;
		}
		else if (score >= 980 && score < 1050)
		{
			Time.timeScale = 1.7f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17f;
			FindObjectOfType<AudioSource>().pitch = 1.7f;
			xSpeed.text = "x" + 21;
		}
		else if (score >= 1050 && score < 1120)
		{
			Time.timeScale = 1.71f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.1f;
			FindObjectOfType<AudioSource>().pitch = 1.71f;
			xSpeed.text = "x" + 22;
		}
		else if (score >= 1120 && score < 1200)
		{
			Time.timeScale = 1.72f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.2f;
			FindObjectOfType<AudioSource>().pitch = 1.72f;
			xSpeed.text = "x" + 23;
		}
		else if (score >= 1200 && score < 1300)
		{
			Time.timeScale = 1.73f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.3f;
			FindObjectOfType<AudioSource>().pitch = 1.73f;
			xSpeed.text = "x" + 24;
		}
		else if (score >= 1300 && score < 1400)
		{
			Time.timeScale = 1.74f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.4f;
			FindObjectOfType<AudioSource>().pitch = 1.74f;
			xSpeed.text = "x" + 25;
		}
		else if (score >= 1400 && score < 1500)
		{
			Time.timeScale = 1.75f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.5f;
			FindObjectOfType<AudioSource>().pitch = 1.75f;
			xSpeed.text = "x" + 26;
		}
		else if (score >= 1500 && score < 1600)
		{
			Time.timeScale = 1.76f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.6f;
			FindObjectOfType<AudioSource>().pitch = 1.76f;
			xSpeed.text = "x" + 27;
		}
		else if (score >= 1600 && score < 1750)
		{
			Time.timeScale = 1.77f;
			//FindObjectOfType<AudioSource>().pitch = Time.timeScale;
			//speed = 17.7f;
			FindObjectOfType<AudioSource>().pitch = 1.77f;
			xSpeed.text = "x" + 28;
		}
		else if (score >= 1750 && score < 1900)
		{
			Time.timeScale = 1.78f;
			//speed = 17.8f;
			FindObjectOfType<AudioSource>().pitch = 1.78f;
			xSpeed.text = "x" + 29;
		}
		else if (score >= 1900 && score < 2100)
		{
			Time.timeScale = 1.8f;
			//speed = 18f;
			FindObjectOfType<AudioSource>().pitch = 1.8f;
			xSpeed.text = "x" + 30;
		}
		else if (score >= 2100 && score < 2400)
		{
			FindObjectOfType<AudioSource>().pitch = 1.82f;
		}
		else if (score >= 2400 && score < 2700)
		{
			FindObjectOfType<AudioSource>().pitch = 1.83f;
		}
		else if (score >= 2700 && score < 3000)
		{
			FindObjectOfType<AudioSource>().pitch = 1.84f;
		}
		else if (score >= 3000 && score < 3300)
		{
			FindObjectOfType<AudioSource>().pitch = 1.85f;
		}
		else if (score >= 3300 && score < 3600)
		{
			FindObjectOfType<AudioSource>().pitch = 1.86f;
		}
		else if (score >= 3600 && score < 3900)
		{
			FindObjectOfType<AudioSource>().pitch = 1.87f;
		}
		else if (score >= 3900 && score < 4400)
		{
			FindObjectOfType<AudioSource>().pitch = 1.88f;
		}
		else if (score > 5000)
		{
			FindObjectOfType<AudioSource>().pitch = 1.9f;
		}
	}

	void SwitchDirection(){

	if (rb.velocity.z > 0)
		
	{rb.velocity = new Vector3 (speed, 0, 0);}
	
	else if(rb.velocity.x > 0)
		
	{rb.velocity = new Vector3 (0, 0, speed);}		
	}


	void OnTriggerEnter(Collider col){
	if (col.gameObject.tag == "Diamond"){
		
		FindObjectOfType<SoundManager>().Play("collide");
		
		GameObject part = Instantiate(particle,col.gameObject.transform.position,Quaternion.identity) as GameObject;
		
		Destroy (col.gameObject);
		
		Destroy (part, 2.5f);

			count ++;

		tCoronaText.text = count.ToString();
		PlayerPrefs.SetInt("count", count);

		}
	}

	

}




















