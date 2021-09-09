using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject slots;
    public GameObject currentEquip;
    public bool isFull;
    public GameObject hammer, sword, hammerslot, swordslot, torch, torchslot, emptyinventory;


    void Start()
    {
        sword.gameObject.SetActive(false);
        hammer.gameObject.SetActive(false);
        swordslot.gameObject.SetActive(false);
        hammerslot.gameObject.SetActive(false);
        torch.gameObject.SetActive(false);
        torchslot.gameObject.SetActive(false);
        emptyinventory.gameObject.SetActive(true);


    }

    public void createslot(GameObject i)
    {

        if (currentEquip.name.Contains("Hammer"))
        {
            sword.gameObject.SetActive(false);
            hammer.gameObject.SetActive(true);
            swordslot.gameObject.SetActive(false);
            hammerslot.gameObject.SetActive(true);
            torch.gameObject.SetActive(false);
            torchslot.gameObject.SetActive(false);
        }
        if (currentEquip.name.Contains("Sword"))
        {
            sword.gameObject.SetActive(true);
            hammer.gameObject.SetActive(false);
            swordslot.gameObject.SetActive(true);
            hammerslot.gameObject.SetActive(false);
            torch.gameObject.SetActive(false);
            torchslot.gameObject.SetActive(false);
        }
        if (currentEquip.name.Contains("Torch"))
        {
            sword.gameObject.SetActive(false);
            hammer.gameObject.SetActive(false);
            swordslot.gameObject.SetActive(false);
            hammerslot.gameObject.SetActive(false);
            torch.gameObject.SetActive(true);
            torchslot.gameObject.SetActive(true);
        }
    }
}

