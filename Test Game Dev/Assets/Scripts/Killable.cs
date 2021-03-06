using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killable : MonoBehaviour
{
    private Inventory inventory;


    public bool killallowed;
    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void Update() {
        if (killallowed && Input.GetKeyDown(KeyCode.E) && inventory.isFull){
            if (inventory.currentEquip.name.Contains("Sword")){

                Destroy(gameObject);
        }
    }
    }

    private void OnCollisionEnter2D(Collision2D other){
        bool player = other.gameObject.name == "Player";
        if(player){

            killallowed = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other){
        bool player = other.gameObject.name == "Player";
        if(player){

            killallowed = false;
        }

    }
}

