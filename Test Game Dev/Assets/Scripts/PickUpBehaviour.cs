using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehaviour : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemslot;

    public bool pickupallowed;
    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void Update() {
        if (pickupallowed && Input.GetKeyDown(KeyCode.E)){
            if (inventory.isFull == true){

                inventory.currentEquip = itemslot;
            } else{
            inventory.isFull = true;
            inventory.currentEquip = itemslot;
            }
            inventory.createslot(itemslot);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Player player = other.GetComponent<Player>();
        if(player){
            
            pickupallowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        Player player = other.GetComponent<Player>();
        if(player){
            pickupallowed = false;
        }

    }
}
    
