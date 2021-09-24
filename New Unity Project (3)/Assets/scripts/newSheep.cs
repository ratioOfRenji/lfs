using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSheep : MonoBehaviour
{
    public GameObject animal;
    [SerializeField]
    public static feedState FeedState = feedState.idle;
    public float animalTimer = 0;

    private void OnMouseDown()
    {
        if ((GMScript1.currentTool == "кормить") && (GMScript1.sunFlowerSeeds > 0) && (FeedState == feedState.idle))
        {
            GMScript1.sunFlowerSeeds--;
            FeedState = feedState.feeded;
        }
        if(FeedState == feedState.readyToCollect)
        {
            GMScript1.wool++;
            FeedState = feedState.idle;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(FeedState)
        {
            case feedState.idle:
                
               
                break;


            case feedState.feeded:
                if (animalTimer >= 5)
                {
                    FeedState = feedState.readyToCollect;
                    animalTimer = 0;


                }

                break;



            case feedState.readyToCollect:

                break;
        }
    }
    public enum feedState
    {
        idle,
        feeded,
        readyToCollect
    }
}
