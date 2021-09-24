using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerWineFactory : MonoBehaviour
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
        if (cookWineFactory.slotArray[0] == 1)
        {
            maxValue = cookWineFactory.firstTimeToCook;
        }
        if (cookWineFactory.slotArray[0] == 2)
        {
            maxValue = cookWineFactory.secondTimeToCook;
        }
        if (cookWineFactory.slotArray[0] == 3)
        {
            maxValue = cookWineFactory.thirdTimeToCook;
        }
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookWineFactory.oneTimer);




        float time = maxValue -= cookWineFactory.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookWineFactory.oneTimer;
        timerText.text = textTime;
    }
}
