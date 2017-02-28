using UnityEngine;
using System.Collections;

public class spawnWaves : MonoBehaviour {

    public static bool okayToSpawn;
    public GameObject wave;
    private Rigidbody2D body2d;

    void Awake() {
        body2d = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start() {
        var newTransform = transform;
        //used to create inital tree
        Instantiate(wave, newTransform.position, Quaternion.identity);
        okayToSpawn = true;
    }

    //used to generate the trees
    public void waveGenerator() {
        var newTransform = transform;

        Instantiate(wave, newTransform.position, Quaternion.identity);

    }

}
