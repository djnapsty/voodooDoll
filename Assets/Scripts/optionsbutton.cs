using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class optionsbutton : MonoBehaviour, IPointerClickHandler 
{
		public Vector3 startingPosition = new Vector3(1000f,0f,450f);
		public Button options;
		public void OnPointerClick(PointerEventData data)
		{
			gameObject.transform.position = startingPosition;
		}




}
