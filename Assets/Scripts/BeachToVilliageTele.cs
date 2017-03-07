using UnityEngine;
using System.Collections;

public class BeachToVilliageTele : MonoBehaviour {


    void Awake() {
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
            AutoFade.LoadLevel("Village", 1, 1, Color.black);
        }
	}
}
