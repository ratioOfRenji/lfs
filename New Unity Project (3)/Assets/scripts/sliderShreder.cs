using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderShreder : MonoBehaviour
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
        if (cookShreder.slotArray[0] == 1)
        {
            maxValue = cookShreder.sugarTimeToCook;
        }
        if (cookShreder.slotArray[0] == 2)
        {
            maxValue = cookShreder.coffeTimeToCook;
        }
        
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookShreder.oneTimer);




        float time = maxValue -= cookShreder.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookShreder.oneTimer;
        timerText.text = textTime;
    }
}
