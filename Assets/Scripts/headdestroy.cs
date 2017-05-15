using UnityEngine;
using System.Collections;

public class headdestroy : MonoBehaviour {
	public bool trump = true;
	void Update () 
	{

		if (Input.GetMouseButtonDown (1)) //click to destroy debug button
		{
			Destroy (gameObject);
			trump = false;
		}
	}
}
