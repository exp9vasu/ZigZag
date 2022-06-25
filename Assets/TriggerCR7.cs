using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCR7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Ball")
		{
			Invoke("FallDown1", 1f);
		}

	}

	void FallDown1()
	{
		Destroy(transform.parent.gameObject, 3f);
	}
}
