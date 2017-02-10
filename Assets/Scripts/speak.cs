using UnityEngine;
using System.Collections;

public class speak : MonoBehaviour {

	bool inCircle = false;


	void Update (){
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		inCircle = true;
		if(other.gameObject.tag == "Player")
		{
			print ("inside radius");
			if (Input.GetKeyDown ("space")) {
				Debug.Log ("space key was pressed");
			}
		}

	}

	void OnTriggerExit2D(Collider2D other){
		inCircle = false;
		if (other.gameObject.tag == "Player") {
		
		}
	}
}
