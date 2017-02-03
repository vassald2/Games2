using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {
	
	public bool animation_bool;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		 if (Input.GetKey (KeyCode.W)) {
			//Animation anim = GetComponent<Animation>();

			//animation.Play("walk");
			transform.Translate (Vector3.up);

		}
	
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left);

		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.down);
			Debug.Log ("Pressing S");
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right);
			Debug.Log ("Pressing D");
		}
	}
}
