using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvlMaster : MonoBehaviour
{
    public static int currentLvl;
    public Slider slider;

    private void Update()
    {
        int curLvl = (int)(0.1f * Mathf.Sqrt(GMScript1.exp));
        if(curLvl != currentLvl)
        {
            currentLvl = curLvl;
        }
        float xpNextLvl = 100 * (currentLvl + 1) * (currentLvl + 1);
        float diferenceExp = xpNextLvl - GMScript1.exp;
        float totalDiference = xpNextLvl - (100 * currentLvl * currentLvl);
        float sliderValue =  diferenceExp/  totalDiference ;

        slider.maxValue = 1;
        slider.minValue = 0;
        slider.value = 1 -sliderValue;
        //Debug.Log(sliderValue  + "slider value  " + xpNextLvl + "xpNextLvl  " + diferenceExp + "diferenceExp  " + totalDiference + "totalDiference  " + currentLvl + "currentLvl");
    }
}
