using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class options : MonoBehaviour, IPointerClickHandler 
{
	public Vector3 startingPosition = new Vector3(0f,0f,450f);
	public Button optionsButton;
	public void OnPointerClick(PointerEventData data)
	{
		
		optionsButton.gameObject.transform.position = startingPosition;
	}

}
