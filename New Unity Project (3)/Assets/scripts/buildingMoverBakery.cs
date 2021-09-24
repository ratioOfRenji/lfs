using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buildingMoverBakery : MonoBehaviour
{
    RaycastHit hit;
    Vector3 movePoint;
    public GameObject bakery;

    private float startTime, endTime;

    void Start()
    {
       

        startTime = 0f;
        endTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            startTime = Time.time;
        }
        if (Input.GetMouseButtonUp(0))
        {
            endTime = Time.time;
        }
        if(endTime - startTime > 3f)
        {
            Debug.Log("long click");
            startTime = 0f;
            endTime = 0f;
        }

    }
}
