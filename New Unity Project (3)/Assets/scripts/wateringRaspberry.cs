using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wateringRaspberry : MonoBehaviour
{
    [SerializeField]
    private GameObject plant;
    [SerializeField]
    private Sprite regular;
    [SerializeField]
    private Sprite watered;
    [SerializeField]
    private Sprite ready;
    public  float timer;
    public bool startTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (plant.GetComponent<SpriteRenderer>().sprite == watered)
        {
            timer += Time.deltaTime;
          
            if(timer >= 1000f)
            {
                startTimer = false;
                timer = 0;
                plant.GetComponent<SpriteRenderer>().sprite = ready;
                
            }

        }
    }
  
    
    void OnTriggerStay2D(Collider2D other)
    {
      
        if((other.gameObject.CompareTag("bucket")) && (plant.GetComponent<SpriteRenderer>().sprite == regular))
        {
            plant.GetComponent<SpriteRenderer>().sprite = watered;
        }
        if ((other.gameObject.CompareTag("collect")) && (plant.GetComponent<SpriteRenderer>().sprite == ready))
        {
            if (plant.gameObject.CompareTag("raspberry"))
            {
                GMScript1.raspberries += 1;
                Debug.Log("малины:" + GMScript1.raspberries);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
            if (plant.gameObject.CompareTag("coffeeTree"))
            {
                GMScript1.coffeeSeeds += 1;
                Debug.Log("семян кофе:" + GMScript1.coffeeSeeds);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
            if (plant.gameObject.CompareTag("appleTree"))
            {
                GMScript1.apple += 1;
                Debug.Log("яблок:" + GMScript1.apple);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
            if (plant.gameObject.CompareTag("orangeTree"))
            {
                GMScript1.orange += 1;
                Debug.Log("апельсинов:" + GMScript1.orange);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
            if (plant.gameObject.CompareTag("cherryTree"))
            {
                GMScript1.cherry += 1;
                Debug.Log("вишни:" + GMScript1.cherry);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
            if (plant.gameObject.CompareTag("grapeBush"))
            {
                GMScript1.grape += 1;
                Debug.Log("винограда:" + GMScript1.grape);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
            if (plant.gameObject.CompareTag("whiteGrapeBush"))
            {
                GMScript1.whiteGrape += 1;
                Debug.Log("белого винограда:" + GMScript1.whiteGrape);
                plant.GetComponent<SpriteRenderer>().sprite = regular;
            }
        }
    }
    private void OnMouseDown()
    {
        if (plant.GetComponent<SpriteRenderer>().sprite == ready)
        {
            
           
        }
    }
}
