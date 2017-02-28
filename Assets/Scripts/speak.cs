using UnityEngine;
using System.Collections;

public class speak : MonoBehaviour {





	public GameObject text; 
	private bool isShowing;

	bool inCircle = false;

	public GameObject eButton;

	private Renderer rendE;
	public GameObject plane;
	private MeshRenderer rendPlane;

	void Start(){
		rendE = eButton.GetComponent<Renderer>();
		rendE.enabled = false;
	
		text.SetActive (false);
	

		rendPlane = plane.GetComponent<MeshRenderer>();
		rendPlane.enabled = false;
	}



	void Update (){
		if (inCircle == true) {

			if (Input.GetKeyDown(KeyCode.E)) {
				Debug.Log("e was pressed");

				text.SetActive(true);
				rendPlane.enabled = true;
						
			}
		}

	}

	void OnTriggerEnter(Collider other)
	{
		
		inCircle = true;
		if(other.gameObject.tag == "Player")
		{
			rendE.enabled = true;

			print ("inside radius");

		}

	}

	void OnTriggerExit(Collider other){
		rendE.enabled = false;
		inCircle = false;
		if (other.gameObject.tag == "Player") {
			print ("outside radius");
			rendPlane.enabled = false;
			text.SetActive(false);


		}
	}
}
