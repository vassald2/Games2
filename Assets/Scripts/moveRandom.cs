using UnityEngine;
using System.Collections;

public class moveRandom : MonoBehaviour {

	public GameObject front;
	public Renderer rend;

	float timeLeft = 3.0f;
	float t;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	public Transform Loc1;
	public Transform Loc2;
	public Transform Loc3;
	public Transform Loc4;
	public Transform Loc5;
	public float speed;
	void Update() {






		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			t = Random.Range (1, 3);
			timeLeft = 2.0f;
			//Debug.Log (t);
		}


		if (t == 1) {
			if (rend.enabled == false) {
				rend.enabled = true;
				Debug.Log (t);
				if (front.transform.position.y > 0) {
					//Debug.Log ("Y is greater then 0");



				}
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards (transform.position, Loc1.position, step);

			}

			rend.enabled = false;
		}

		if (t == 2) {
			if (rend.enabled == true) {
				rend.enabled = false;
				rend = GetComponent<Renderer> ();
				rend.enabled = true;
				if (front.transform.position.y > 0) {
					//Debug.Log ("Y is greater then 0");

				}
				Debug.Log (t);
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards (transform.position, Loc2.position, step);

			}
			rend.enabled = true;
		}
		/*

		if (t == 3) {
			if(front.transform.position.y > 0){
				Debug.Log ("Y is greater then 0");
			}
			Debug.Log (t);
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, Loc3.position, step);
		}
		if (t == 4 ) {
			if(front.transform.position.y > 0){
				Debug.Log ("Y is greater then 0");
			}
			Debug.Log (t);
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, Loc4.position, step);
		}
		if (t == 5 ) {
			if(front.transform.position.y > 0){
				Debug.Log ("Y is greater then 0");
			}
			Debug.Log (t);
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, Loc5.position, step);
		}

	*/

	}

}
