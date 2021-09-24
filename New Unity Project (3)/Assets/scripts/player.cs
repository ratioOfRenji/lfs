using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static player Instance { get; private set; }

    [SerializeField]
    private UiInventory uiInventory;

    private Inventory inventory;


    private void Awake()
    {
        Instance = this;
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
}
