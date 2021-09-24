using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hen : MonoBehaviour
{
    public static float growTimeSheep = 0;
    public Sprite ovtsa1;
    public GameObject head;
    public GameObject body;
    public Sprite head1;
    public Sprite body1;
    public Sprite head2;
    public Sprite body2;
    public Sprite head3;
    public Sprite body3;
    public int timerSheep;
    public bool startTimer;
    public static bool animationTrigger;
    public GameObject particles;
    private void Start()
    {

    }
    private void OnMouseDown()
    {
        if ((GMScript1.currentTool == "кормить") && (GMScript1.sunFlowerSeeds > 0) && (growTimeSheep < timerSheep))
        {
            startTimer = true;
            GMScript1.sunFlowerSeeds--;
            head.GetComponent<SpriteRenderer>().sprite = head2;

        }
        if ((GMScript1.currentTool == "кормить") && (growTimeSheep > timerSheep))
        {

            head.GetComponent<SpriteRenderer>().sprite = head1;
            //body.GetComponent<SpriteRenderer>().sprite = body1;
            GMScript1.yaytsa++;
            animationTrigger = true;
            startTimer = false;
            growTimeSheep = 0;
        }
    }
    private void Update()
    {
        if (head.GetComponent<SpriteRenderer>().sprite == head2)
        {
            growTimeSheep += Time.deltaTime;
        }
        if (growTimeSheep > timerSheep)
        {


            head.GetComponent<SpriteRenderer>().sprite = head1;
            particles.SetActive(true);



        }
        if (growTimeSheep < timerSheep)
        {



            particles.SetActive(false);



        }
    }
}
