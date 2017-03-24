using UnityEngine;
using System.Collections;

public class MainPath2ToMainPathTele : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
            AutoFade.LoadLevel("MainPath2", 1, 1, Color.black);
		}
	}
}
