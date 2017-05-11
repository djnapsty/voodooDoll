using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class reseter :MonoBehaviour , IPointerClickHandler
{
	public void OnPointerClick(PointerEventData data)
	{
		// reload the scene
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
	}


}
