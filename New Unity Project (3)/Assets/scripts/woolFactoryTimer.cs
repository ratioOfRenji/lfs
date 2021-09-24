using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woolFactoryTimer : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;
    public GameObject slider1;
    public GameObject galothka;
    public GameObject wool;
    public GameObject uiSborWool;
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
        GMScript1.sewSlot1 = false;
        GMScript1.sewSlot2 = false;
        GMScript1.wool--;
        GMScript1.nitki--;
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
                uiSborWool.SetActive(true);
                GMScript1.PopUpWoolIsActive = true;

                slider1.SetActive(false);
                wool.SetActive(false);
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
