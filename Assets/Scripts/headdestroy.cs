using UnityEngine;
using System.Collections;

public class headdestroy : MonoBehaviour {

	void Update () 
	{
		if (Input.GetMouseButtonDown (1)) //click to destroy debug button
		{
			Destroy (gameObject);
		}
	}
}
