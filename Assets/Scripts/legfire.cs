using UnityEngine;
using System.Collections;

public class legfire : MonoBehaviour 
{

	public GameObject fire;
	public GameObject leg;

	void OnMouseOver(Collision y)
	{
		//if (y.gameObject == leg) {
			
			GameObject fireCopy = (GameObject)Instantiate(fire, transform.position, transform.rotation);
		//}
	}



}
