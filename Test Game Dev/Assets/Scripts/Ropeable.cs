using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ropeable : MonoBehaviour
{
    public bool ropeallowed;
    public GameObject Rope;


    private void Start() {

        Rope.gameObject.SetActive(false);
    }
    private void Update() {
        if (ropeallowed && Input.GetKeyDown(KeyCode.E) ){
            Rope.gameObject.SetActive(true);
    }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        bool player = other.gameObject.name == "Player";
        if(player){

            ropeallowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        bool player = other.gameObject.name == "Player";
        if(player){

            ropeallowed = false;
        }

    }
}

