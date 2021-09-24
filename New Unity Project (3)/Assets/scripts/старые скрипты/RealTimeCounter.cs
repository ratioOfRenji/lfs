using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeCounter : MonoBehaviour
{
    //Test timer
    public static float timer;
    // Start is called before the first frame update
    void Start()
    {
        // initializing timer to our starting ammount
        timer = 0;
        // update timer with real time passed
        timer += TimeMaster.CheckDate();
    }

    // Update is called once per frame
    void Update()
    {
        // update our timer each frame
        if(this.enabled == false)
        { timer += Time.deltaTime; }
       
    }
    private void OnGUI()
    {
        //if (GUI.Button(new Rect (10,10,100,50),"Save Time"))
        //{
        //    ResetClock();
        //}
        if (GUI.Button(new Rect(10, 150, 100, 50), "Check Time"))
        {
            print(60 - TimeMaster.CheckDate() + "in real seconds has passed"); ;
        }
        GUI.Label(new Rect(10, 150, 100, 50), timer.ToString());
    }
    //
    void ResetClock()
    {
        TimeMaster.SaveDate();
        timer = 0;
        timer += TimeMaster.CheckDate();
    }
    private void OnDisable()
    {
        ResetClock();
    }
}
