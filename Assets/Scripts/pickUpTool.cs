﻿using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class pickUpTool : MonoBehaviour {

	public bool soundplayed;
	public float yAxisY = 47.0f ;

	void Start()
	{
		soundplayed = false;

	}


	void OnMouseDrag() 
	{
		
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, yAxisY);
		Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

		transform.position = objectPosition;


		AudioSource audio = GetComponent<AudioSource>();

		if (!soundplayed) 
		{
			audio.Play ();

			soundplayed = true;
		}
	}

	void OnMouseUp()
	{
		soundplayed = false;
	
	
	}


}





