using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{

	[SerializeField] private Button MyButton = null;

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) //click to destroy debug button
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
		}
	}

}

