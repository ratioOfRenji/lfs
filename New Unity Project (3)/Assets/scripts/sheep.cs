using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheep : MonoBehaviour
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
    public static bool woolAnimationTrigger;
    private void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if ((GMScript1.currentTool == "кормить") && (GMScript1.sunFlowerSeeds > 0) && (growTimeSheep < timerSheep))
        {
            GMScript1.ovtsuPokormili1 = true;
            GMScript1.sunFlowerSeeds--;
            head.GetComponent<SpriteRenderer>().sprite = head2;

        }
        if ((GMScript1.currentTool == "кормить") && (growTimeSheep > timerSheep))
        {
            GMScript1.ovtsuPokormili1 = false;
            GMScript1.ovtsuPokormili2 = false;
            head.GetComponent<SpriteRenderer>().sprite = head1;
            body.GetComponent<SpriteRenderer>().sprite = body1;
            GMScript1.wool++;
            woolAnimationTrigger = true;

            growTimeSheep = 0;
        }
    }
    private void Update()
    {
        if ((head.GetComponent<SpriteRenderer>().sprite == head2) && (growTimeSheep <= timerSheep))
        {
            growTimeSheep += Time.deltaTime;
        }
        if (growTimeSheep > timerSheep)
        {
           


                GMScript1.ovtsuPokormili2 = true;
                head.GetComponent<SpriteRenderer>().sprite = head3;
                body.GetComponent<SpriteRenderer>().sprite = body3;

            
        }

    }
}
