using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerWoolFactory : MonoBehaviour
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
        if (cookWoolFactory.slotArray[0] == 1)
        {
            maxValue = cookWoolFactory.sugarTimeToCook;
        }
        if (cookWoolFactory.slotArray[0] == 2)
        {
            maxValue = cookWoolFactory.coffeTimeToCook;
        }

        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookWoolFactory.oneTimer);




        float time = maxValue -= cookWoolFactory.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookWoolFactory.oneTimer;
        timerText.text = textTime;
    }
}
