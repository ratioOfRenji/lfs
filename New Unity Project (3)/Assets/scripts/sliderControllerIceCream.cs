using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderControllerIceCream : MonoBehaviour
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
        if (cookIceCream.slotArray[0] == 1)
        {
            maxValue = cookIceCream.firstItemTimeToCook;
        }
        if (cookIceCream.slotArray[0] == 2)
        {
            maxValue = cookIceCream.secondItemTimeToCook;
        }
        if (cookIceCream.slotArray[0] == 3)
        {
            maxValue = cookIceCream.thirdItemTimeToCook;
        }
        slider.maxValue = maxValue;
        int textValue;
        textValue = Mathf.RoundToInt(cookIceCream.oneTimer);




        float time = maxValue -= cookIceCream.oneTimer;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);



        slider.value = cookIceCream.oneTimer;
        timerText.text = textTime;
    }
}
