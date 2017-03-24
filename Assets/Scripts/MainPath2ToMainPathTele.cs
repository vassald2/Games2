using UnityEngine;
using System.Collections;

public class MainPathToMainPath2Tele : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
            AutoFade.LoadLevel("MainPath", 1, 1, Color.black);
		}
	}
}
