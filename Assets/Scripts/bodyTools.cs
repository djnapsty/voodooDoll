using UnityEngine;
using System.Collections;

public class bodyTools : MonoBehaviour 
{




	void onCollisionEnter(Collision a)
	{
		if (a.gameObject.tag == "TOOL") 
		{
			Destroy(a.gameObject);
		}
	}
			
}
