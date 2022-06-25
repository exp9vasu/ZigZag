using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	public int rand;

	// Start is called before the first frame update

	public void Rotate() 
	{ 
		rand = Random.Range(0, 6);
		if (rand < 2)
		{
			transform.Rotate(0, 0, 3);
		}
		else if (rand > 4)
		{
			transform.Rotate(0, 3, 0);
		}
		else
		{
			transform.Rotate(3, 0, 0);
		}
	}

}
