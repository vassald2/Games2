using UnityEngine;
using System.Collections;

public class beachLoad : MonoBehaviour {



    // Use this for initialization
    void awake() {
        spawnPlaceHolder.fromVillage = false;
    }

	void Start () {
        if (spawnPlaceHolder.spawned && spawnPlaceHolder.fromVillage) {
            onLevelLoaded();
        }
        spawnPlaceHolder.fromVillage = false;
        spawnPlaceHolder.spawned = true;
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void onLevelLoaded() {
        gameObject.transform.position = new Vector3(-30, 400, -20);
    }
}
