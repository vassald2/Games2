using UnityEngine;
using System.Collections;

public class ChangeIntroPics : MonoBehaviour {
	public GameObject Scene1;
	public GameObject Scene2;
	public GameObject Scene3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Destroy(Scene1);
		}
	}
}
