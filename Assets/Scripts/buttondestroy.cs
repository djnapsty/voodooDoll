using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttondestroy : MonoBehaviour {

	[SerializeField] private Button MyButton = null;
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) //click to destroy debug button
		{
			Destroy (MyButton.gameObject);
		}
	}

}
