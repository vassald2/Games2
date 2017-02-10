using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

    Animator myAnimator;

    public bool animation_bool;
	// Use this for initialization
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
