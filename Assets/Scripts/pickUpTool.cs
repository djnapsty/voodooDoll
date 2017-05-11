using UnityEngine;
using System.Collections;



public class pickUpTool : MonoBehaviour {


	public float yAxisY = 47.0f ;


	// Update is called once per frame
	void OnMouseDrag() 
	{
		
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, yAxisY);
		Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

		transform.position = objectPosition;
	}


}





