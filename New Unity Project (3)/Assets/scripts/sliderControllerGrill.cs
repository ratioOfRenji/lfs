using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerGrill : MonoBehaviour
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
        if (cookGrill.slotArray[0] == 1)
        {
            maxValue = cookGrill.firstItemTimeToCook;
        }
        if (cookGrill.slotArray[0] == 2)
        {
            maxValue = cookGrill.secondItemTimeToCook;
        }
        if (cookGrill.slotArray[0] == 3)
        {
            maxValue = cookGrill.thirdItemTimeToCook;
        }
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookGrill.oneTimer);




        float time = maxValue -= cookGrill.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookGrill.oneTimer;
        timerText.text = textTime;
    }
}
