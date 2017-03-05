using UnityEngine;
using System.Collections;



public class pickUpTool : MonoBehaviour {

	// Update is called once per frame
	void OnMouseDrag() 
	{
		float yAxisY =10.0f ;
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, yAxisY);
		Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

		transform.position = objectPosition;
	}
}
