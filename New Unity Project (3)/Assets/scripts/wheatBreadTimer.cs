using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wheatBreadTimer : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;
    public GameObject slider1;
    public GameObject galothka;
    public GameObject bread;
    public GameObject uiSbor;
    private bool stopTimer = true;
    public static bool startTiimer = false;

    public void startTimer()
    {
        startTiimer = true;
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        slider1.SetActive(true);
        galothka.SetActive(false);
        GMScript1.pecarnyaSlot1 = false;
        GMScript1.pecarnyaSlot2 = false;
        GMScript1.sunFlowerSeeds --;
        GMScript1.cowMilk--;
        Debug.Log(GMScript1.sunFlowerSeeds);
    }

    
    void Update()
    {
        if (startTiimer == true)
        {
            float time = gameTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60f);
            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            if (time <= 0)
            {
                uiSbor.SetActive(true);
                GMScript1.bakeryPopUpIsActive = true;

                slider1.SetActive(false);
                bread.SetActive(false);
                startTiimer = false;
                stopTimer = true;
                gameTime = 10;


            }
            if (stopTimer == false)
            {
                timerText.text = textTime;
                timerSlider.value = time;
                
            }
            if (stopTimer == true)
            {
               
            }
            
        }
    }
}
