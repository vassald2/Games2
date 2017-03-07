using UnityEngine;
using System.Collections;

public class spawnPlaceHolder : MonoBehaviour {

    public static bool spawned;
    public static bool fromVillage;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1) {
            Destroy(gameObject);
        }
        spawned = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
