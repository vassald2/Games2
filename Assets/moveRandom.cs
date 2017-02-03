using UnityEngine;
using System.Collections;

public class moveRandom : MonoBehaviour {

	public GameObject prefab;
	float timeLeft = 3.0f;
	float t;
	// Use this for initialization
	void Start () {
	
	}
	public Transform target;
	public Transform target1;
	public Transform target2;
	public Transform target3;
	public Transform target4;
	public float speed;
	void Update() {

		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			t = Random.Range (1, 5);
			timeLeft = 3.0f;
			Debug.Log (t);
		}


		if (t == 1) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		}
		if (t == 2) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target1.position, step);
		}
		if (t == 3) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
		}
		if (t == 4) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target3.position, step);
		}
		if (t == 5) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target4.position, step);
		}
	
	}
}
