using UnityEngine;
using System.Collections;

public class speak : MonoBehaviour {

	bool inCircle = false;

	public GameObject eButton;
	public GameObject text;
	private Renderer rendText;
	private Renderer rendE;
	void Start(){
		rendE = eButton.GetComponent<Renderer>();
		rendE.enabled = false;
	
		rendText = text.GetComponent<Renderer>();
		rendText.enabled = false;
	}



	void Update (){
		if (inCircle == true) {

			if(Input.GetKeyDown("space")) {
				Debug.Log ("space key was pressed");

			}
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		
		inCircle = true;
		if(other.gameObject.tag == "Player")
		{
			rendE.enabled = true;
			print ("inside radius");
			if (Input.GetKeyDown ("e")) {
				Debug.Log("e was pressed");
				rendText.enabled = false;
				
				
			}
		}

	}

	void OnTriggerExit2D(Collider2D other){
		rendE.enabled = false;
		inCircle = false;
		if (other.gameObject.tag == "Player") {
			print ("outside radius");

		}
	}
}
