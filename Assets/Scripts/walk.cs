using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

	Animator myAnimator;
	private AudioSource audio;
	public AudioClip au_leafCrunch;
	private Rigidbody rb;
	public int speed;
	Vector3 playerMove;




	// public bool animation_bool;
	// Use this for initialization
	void Awake(){
		audio = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody>();
		speed = 100;
 
	}
	void Start () {
		myAnimator = this.GetComponent<Animator>();
		playerMove = new Vector3(0, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		bool left = Input.GetKey(KeyCode.A);
		bool up = Input.GetKey(KeyCode.W);
		bool down = Input.GetKey(KeyCode.S);
		bool right = Input.GetKey(KeyCode.D);
		myAnimator.SetBool("GoUp", up);
		myAnimator.SetBool("GoLeft", left);
		myAnimator.SetBool("GoRight", right);
		myAnimator.SetBool("GoDown", down);

		if (Input.GetKey (KeyCode.W)) {
			playerMove.y = 3 * speed;
			rb.velocity = playerMove;
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}
		}
		else if (Input.GetKeyUp(KeyCode.W)) {
			playerMove.y = 0;
			rb.velocity = playerMove;
		}

		if (Input.GetKey (KeyCode.A)) {
			playerMove.x = -3 * speed;
			rb.velocity = playerMove;
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}

		}
		else if(Input.GetKeyUp(KeyCode.A)){
			playerMove.x = 0;
			rb.velocity = playerMove;
		}
		if (Input.GetKey (KeyCode.S)) {
			playerMove.y = -3 * speed;
			rb.velocity = playerMove;
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}
		}
		else if (Input.GetKeyUp(KeyCode.S)) {
			playerMove.y = 0;
			rb.velocity = playerMove;
		}

		if (Input.GetKey (KeyCode.D)) {
			playerMove.x = 3 * speed;
			rb.velocity = playerMove;
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}
		}
		else if (Input.GetKeyUp(KeyCode.D)) {
			playerMove.x = 0;
			rb.velocity = playerMove;
		}
	}

	void walkOnLeaves(){
		audio.clip = au_leafCrunch;
		audio.PlayOneShot(au_leafCrunch);

	}


}