using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

    Animator myAnimator;
	private AudioSource audio;
	public AudioClip au_leafCrunch;



   // public bool animation_bool;
	// Use this for initialization
	void Awake(){
		audio = GetComponent<AudioSource> ();
	}
	void Start () {
        myAnimator = this.GetComponent<Animator>();

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
            //Animation anim = GetComponent<Animation>();
            //animation.Play("walk");
            transform.Translate (Vector3.up * 3);
			//source.PlayOneShot (au_leafCrunch, 1f);
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}
		}
	
		if (Input.GetKey (KeyCode.A)) {
            transform.Translate (Vector3.left * 3);
			//source.PlayOneShot (au_leafCrunch, 1f);
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}

		}
		if (Input.GetKey (KeyCode.S)) {
            transform.Translate (Vector3.down * 3);
			//source.PlayOneShot (au_leafCrunch, 1f);
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}
		}

		if (Input.GetKey (KeyCode.D)) {
            transform.Translate (Vector3.right * 3);
			//source.PlayOneShot (au_leafCrunch, 1f);
			if (!audio.isPlaying) {
				walkOnLeaves ();
			}
		}
	}

	void walkOnLeaves(){
		audio.clip = au_leafCrunch;
		audio.PlayOneShot(au_leafCrunch);

		//audio.Play();

	}
}
