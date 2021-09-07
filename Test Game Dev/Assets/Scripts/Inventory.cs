using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject slots;
    public GameObject currentEquip;
    public bool isFull;
    public GameObject hammer, sword, hammerslot, swordslot;


    void Start()
    {
        sword.gameObject.SetActive(false);
        hammer.gameObject.SetActive(false);
        swordslot.gameObject.SetActive(false);
        hammerslot.gameObject.SetActive(false);
    }

    public void createslot(GameObject i){

        if (currentEquip.name.Contains("Hammer")){
            sword.gameObject.SetActive(false);
            hammer.gameObject.SetActive(true);
            swordslot.gameObject.SetActive(false);
            hammerslot.gameObject.SetActive(true);
        }
        if (currentEquip.name.Contains("Sword")){
            sword.gameObject.SetActive(true);
            hammer.gameObject.SetActive(false);
            swordslot.gameObject.SetActive(true);
            hammerslot.gameObject.SetActive(false);
        }
    }

}

