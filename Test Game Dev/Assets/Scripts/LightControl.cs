using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public static bool LightOn = false;
    public int timer = 5000;
    private Inventory inventory;
    public GameObject player;

    void Start()
    {
        inventory = player.GetComponent<Inventory>();
    }

    void Update ()
    {
        if(inventory.currentEquip.name.Contains("Torch"))
        {
            LightOn = true;
            timer--;
        }

        if(timer < 0)
        {
            LightOn = false;
            timer = 5000;
        }


    }
}
