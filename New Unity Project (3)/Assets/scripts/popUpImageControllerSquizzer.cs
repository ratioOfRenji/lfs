﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpImageControllerSquizzer : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public Sprite[] images;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        first.GetComponent<SpriteRenderer>().sprite = images[cookJuice.imageSlotArray[0]];
        second.GetComponent<SpriteRenderer>().sprite = images[cookJuice.imageSlotArray[1]];
    }
}
