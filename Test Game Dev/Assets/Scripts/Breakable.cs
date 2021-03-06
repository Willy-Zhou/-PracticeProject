using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    private Inventory inventory;


    public bool breakallowed;
    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void Update() {
        if (breakallowed && Input.GetKeyDown(KeyCode.E) && inventory.isFull){
            if (inventory.currentEquip.name.Contains("Hammer")){
                Destroy(gameObject);
        }
    }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        bool player = other.gameObject.name == "Player";
        if(player){

            breakallowed = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        bool player = other.gameObject.name == "Player";
        if(player){

            breakallowed = false;
        }

    }

    
}
