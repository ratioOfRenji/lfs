using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerJuiceMachine : MonoBehaviour
{
    public Slider slider;
    public Text timerText;
    public float timer;
    float startValue;

    float maxValue;

    void Start()
    {

        //slider.maxValue = timer;
        slider.value = startValue;


    }

    // Update is called once per frame
    void Update()
    {
        if (cookJuice.slotArray[0] == 1)
        {
            maxValue = cookJuice.firstItemTimeToCook;
        }
        if (cookJuice.slotArray[0] == 2)
        {
            maxValue = cookJuice.secondItemTimeToCook;
        }
        if (cookJuice.slotArray[0] == 3)
        {
            maxValue = cookJuice.thirdItemTimeToCook;
        }
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookJuice.oneTimer);




        float time = maxValue -= cookJuice.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookJuice.oneTimer;
        timerText.text = textTime;
    }
}
