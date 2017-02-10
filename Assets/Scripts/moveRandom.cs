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
		
		}


		if (t == 1) {
			if (rend.enabled == false) {
				rend.enabled = true;
				if (front.transform.position.y > 0) {



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


				}
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards (transform.position, Loc2.position, step);

			}
			rend.enabled = true;
		}

	}

}
