﻿using UnityEngine;
using System.Collections;

public class VillageToBeachTele : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            AutoFade.LoadLevel("Beach", 1, 1, Color.black);
            spawnPlaceHolder.fromVillage = true;
        }
    }

}
