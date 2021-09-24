using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPlanting3 : MonoBehaviour
{
    public GameObject bed;
   
    public GameObject ground;
    public Sprite[] sprites1Stage;
    public Sprite[] sprites2Stage;
    public float growTime = 0;
    // Start is called before the first frame update
    private Animator anim;
    //private bool animPlayed;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       
        //запускает таймер после посадки и уничтожает растерие если его не полили
        if (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[1] | bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[2] | bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[3] | bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[4] | bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[5])
        {
            growTime += Time.deltaTime;
        }

        // если время прошло, меняет росток на готовое растение
       
            if (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[1])
            {
                if (growTime > 150f) { 
                    bed.GetComponent<SpriteRenderer>().sprite = sprites2Stage[1];
                    
                }

            }

            if (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[2])
            {
                if (growTime > 150f)
                {
                    bed.GetComponent<SpriteRenderer>().sprite = sprites2Stage[2];
                }
            }

            if (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[3])
            {
                if (growTime > 150f)
                {
                    bed.GetComponent<SpriteRenderer>().sprite = sprites2Stage[3];
                }
            }
            if (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[4])
            {
                if (growTime > 150f) { 
                    bed.GetComponent<SpriteRenderer>().sprite = sprites2Stage[4];}
            }
            if (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[5])
            {
                if (growTime > 150f)
                { bed.GetComponent<SpriteRenderer>().sprite = sprites2Stage[5]; }
            }
           




       
    }
        
        private void OnMouseDown()
        {
            // он маус давн использует нажатие мышки 
            if (GMScript1.currentTool == "scythe")
            {
                bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[0];
            }
            if ((GMScript1.currentTool == "sunflower") && (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[0]) && (GMScript1.sunFlowerSeeds > 0))
            {

            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[1];
                GMScript1.sunFlowerSeeds--;
            }
            if ((GMScript1.currentTool == "carrot") && (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[0]) && (GMScript1.carrotSeeds > 0))
            {
            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[2];

            GMScript1.carrotSeeds--;

            }
            if ((GMScript1.currentTool == "potato") && (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[0]) && (GMScript1.potatoSeeds > 0))
            {

            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[3];

            GMScript1.potatoSeeds--;


            }
        if ((GMScript1.currentTool == "soy") && (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[0]) && (GMScript1.soySeeds > 0))
        {

            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[4];

            GMScript1.soySeeds--;


        }
        if ((GMScript1.currentTool == "sugarPlant") && (bed.GetComponent<SpriteRenderer>().sprite == sprites1Stage[0]) && (GMScript1.sugarPlantSeeds > 0))
        {

            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[5];

            GMScript1.sugarPlantSeeds--;


        }

        if (bed.GetComponent<SpriteRenderer>().sprite == sprites2Stage[1])
            {
                // GMScript1.boolSunflower2 = false;
                GMScript1.sunFlowerSeeds += 2;
                GMScript1.boolWatered = false;
            StartCoroutine(wheat());
            // grazObj.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[0];
            growTime = 0;

        }
            if (bed.GetComponent<SpriteRenderer>().sprite == sprites2Stage[2])
            {
            // GMScript1.boolCarrot2 = false;
            StartCoroutine(carrot());
            GMScript1.carrotSeeds += 2;
                bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[0];
            growTime = 0;

        }
            if (bed.GetComponent<SpriteRenderer>().sprite == sprites2Stage[3])
            {
            StartCoroutine(potato());
            //GMScript1.boolPotato2 = false;
            GMScript1.potatoSeeds += 2;
                bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[0];
             growTime = 0;

            }
        if (bed.GetComponent<SpriteRenderer>().sprite == sprites2Stage[4])
        {
            StartCoroutine(soy());
            GMScript1.soySeeds += 2;
            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[0];
            growTime = 0;

        }
        if (bed.GetComponent<SpriteRenderer>().sprite == sprites2Stage[5])
        {
            StartCoroutine(sugarPlant());
            GMScript1.sugarPlantSeeds += 2;
            bed.GetComponent<SpriteRenderer>().sprite = sprites1Stage[0];
            growTime = 0;
        }
    }
    IEnumerator wheat()
    {
        anim.Play("wheatAnim");
        yield return new WaitForSeconds(2);
        anim.Play("bedIdle");
       // cow.animationTrigger = false;
    }
    IEnumerator carrot()
    {
        anim.Play("carrotAnim");
        yield return new WaitForSeconds(2);
        anim.Play("bedIdle");
        // cow.animationTrigger = false;
    }
    IEnumerator potato()
    {
        anim.Play("potatoAnim");
        yield return new WaitForSeconds(2);
        anim.Play("bedIdle");
        // cow.animationTrigger = false;
    }
    IEnumerator sugarPlant()
    {
        anim.Play("sugarPlantAnim");
        yield return new WaitForSeconds(2);
        anim.Play("bedIdle");
        // cow.animationTrigger = false;
    }
    IEnumerator soy()
    {
        anim.Play("soyAnim");
        yield return new WaitForSeconds(2);
        anim.Play("bedIdle");
        // cow.animationTrigger = false;
    }
}
