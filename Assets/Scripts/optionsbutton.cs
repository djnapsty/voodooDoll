using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class optionsbutton : MonoBehaviour, IPointerClickHandler 
{
		public Button options;
		public void OnPointerClick(PointerEventData data)
		{
			gameObject.transform.position = new Vector3 (1000f, 0f, 0f);
		}




}
