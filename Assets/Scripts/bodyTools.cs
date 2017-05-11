using UnityEngine;
using System.Collections;

public class bodyTools : MonoBehaviour 
{

	void onCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "body") 
		{
			Destroy(collision.gameObject);
		}
	}
			
}
