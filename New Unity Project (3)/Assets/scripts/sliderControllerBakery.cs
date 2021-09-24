using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerBakery : MonoBehaviour
{
    public Slider slider;
    public Text timerText;
    public float timer;
    float startValue;
    float slValue = 0;
    float maxValue;
    private bool stopTimer;
    void Start()
    {
        stopTimer = false;
        //slider.maxValue = timer;
        slider.value = startValue;


    }

    // Update is called once per frame
    void Update()
    {
        if (cookBakery.slotArray[0] == 1)
        {
            maxValue = cookBakery.sugarTimeToCook;
        }
        if (cookBakery.slotArray[0] == 2)
        {
            maxValue = cookBakery.coffeTimeToCook;
        }
        
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookBakery.oneTimer);




        float time = maxValue -= cookBakery.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookBakery.oneTimer;
        timerText.text = textTime;
    }
}
