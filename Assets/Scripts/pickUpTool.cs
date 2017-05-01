using UnityEngine;
using System.Collections;



public class pickUpTool : MonoBehaviour {

	public GameObject leg;



	// Update is called once per frame
	void OnMouseDrag() 
	{
		float yAxisY =47.0f ;
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, yAxisY);
		Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

		transform.position = objectPosition;
	}

	void OnCollisionEnter(Collision collision) 
	{

		if(collision.gameObject.tag == "TOOL")
			leg.gameObject.transform.position += new Vector3(0, 0, -10);
	}
}





