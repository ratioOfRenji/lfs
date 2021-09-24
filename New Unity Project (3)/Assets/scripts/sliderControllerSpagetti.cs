using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerSpagetti : MonoBehaviour
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
        if (cookSpagettiMachine.slotArray[0] == 1)
        {
            maxValue = cookSpagettiMachine.firstItemTimeToCook;
        }
        if (cookSpagettiMachine.slotArray[0] == 2)
        {
            maxValue = cookSpagettiMachine.secondItemTimeToCook;
        }
        if (cookSpagettiMachine.slotArray[0] == 3)
        {
            maxValue = cookSpagettiMachine.thirdItemTimeToCook;
        }
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookSpagettiMachine.oneTimer);




        float time = maxValue -= cookSpagettiMachine.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookSpagettiMachine.oneTimer;
        timerText.text = textTime;
    }
}
