using UnityEngine;
using System.Collections;

public class ChangeIntroPics : MonoBehaviour {
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    int count = 0;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (count == 2) {
            if (Input.GetKeyDown(KeyCode.C)) {
                Debug.Log(count);
                AutoFade.LoadLevel("Beach", 1, 1, Color.black);
                //Destroy (Scene3);
            }
        }
        if (count == 1) {
            if (Input.GetKeyDown(KeyCode.C)) {
                Debug.Log(count);
                Destroy(Scene2);
                count++;
            }
        }

        if (Input.GetKeyDown(KeyCode.C) && count == 0) {
            Destroy(Scene1);
            count++;

        }


    }


}


