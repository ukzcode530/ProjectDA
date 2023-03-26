using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int i;
    private ItemInventoryManager inventory;

    void Awake()
    {
        inventory = GameObject.FindObjectOfType<ItemInventoryManager>();
    }


    void Update()
    {
        if (transform.childCount <= 0)
        {
            inventory.fullCheck[i] = false;
        }
    }

    public void RemoveItem()
    {
        for (int idx = 0; idx < transform.childCount; idx++)
        {
            Destroy(transform.GetChild(idx).gameObject);

        }

    }

}
