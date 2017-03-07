using UnityEngine;
using System.Collections;

public class beastieCollision : MonoBehaviour {

	bool inCircle = false;
	private Renderer rendX;
	public GameObject xButton;
	// Use this for initialization
	void Start () {
		rendX = xButton.GetComponent<Renderer>();
		rendX.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (inCircle == true) {

			if (Input.GetKeyDown(KeyCode.X)) {
				Debug.Log("x was pressed");
				Destroy (gameObject);

			}
		}

	}



	void OnTriggerEnter(Collider other)
	{

		inCircle = true;
		if(other.gameObject.tag == "Player")
		{
			rendX.enabled = true;

			print ("inside radius");

		}

	}

	void OnTriggerExit(Collider other){
		rendX.enabled = false;
		inCircle = false;
		if (other.gameObject.tag == "Player") {
			print ("outside radius");
			//rendPlane.enabled = false;
			//text.SetActive(false);


		}
	}
}
