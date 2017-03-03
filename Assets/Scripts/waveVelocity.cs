using UnityEngine;
using System.Collections;

public class waveVelocity : MonoBehaviour {

    public Vector2 velocity = Vector2.zero;
    GameObject spawner;
    private bool offscreen;
    private float spawnY;
    private float offScreenY = 0;
    public float offset = 280f;
    public float spawnOffset = 40f;


    private Rigidbody2D body2d;

    void Awake() {
        body2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        body2d.velocity = velocity;
    }

    // Use this for initialization
    void Start () {
        spawner = GameObject.Find("WavesSpawn");
        offScreenY = -2600;
    }
	
	// Update is called once per frame
	void Update () {
        offScreenY = (Screen.height / PixelPerfectCamera.pixelsToUnits) / 2 + offset;
        spawnY = (Screen.height / PixelPerfectCamera.pixelsToUnits) / 2 + spawnOffset;
        var posy = transform.position.y;
        var diry = body2d.velocity.y;

        if (Mathf.Abs(posy) > offScreenY) {
            if (diry < 0 && posy < -offScreenY) {
                offscreen = true;
            }
        }
        else {
            offscreen = false;
        }
        if (offscreen) {
            OutOfBounds();
        }
        if (Mathf.Abs(posy) > spawnY) {
            if (diry < 0 && posy < -spawnY) {
                if (spawnWaves.okayToSpawn) {
                    spawnWaves.okayToSpawn = false;
                    spawner.GetComponent<spawnWaves>().waveGenerator();
                }

            }
        }
    }
    public void OutOfBounds() {
        offscreen = false;
        Destroy(gameObject);
        spawnWaves.okayToSpawn = true;
    }
}
