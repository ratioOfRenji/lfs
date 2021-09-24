using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragableBuilding : MonoBehaviour
{
    public GameObject correctForm;
    public GameObject cameraDisable;
    public GameObject strelotchka;
    public GameObject uiSbor;
    private bool moving;
    private bool timer;
    private bool longClick;
    private float startPosX;
    private float startPosY;
    private float returnPositionX;
    private float returnPositionY;
    public float growTime = 0;
    private bool colision;
    public CircleCollider2D colider1;

    void Start()
    {
        returnPositionX = this.transform.localPosition.x;
        returnPositionY = this.transform.localPosition.y;
        colider1 = colider1.GetComponent<CircleCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        colision = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        colision = false;
    }

    void Update()
    {
        
        if (timer)
        {
            growTime += Time.deltaTime;
        }
        if (growTime > 2f)
        {
            longClick = true;
        }
        if ((growTime > 0.6f) && (growTime < 2f))
        {
            strelotchka.SetActive(true);
        }
        if ((growTime < 0.6f) || (growTime > 2f))
        {
            strelotchka.SetActive(false);
        }
        if ((moving) && (longClick))
        {
            colider1.radius = 0;
            cameraDisable.SetActive(false);
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 1f);
        }
        if((colision)&&(longClick))
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
        }

    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GMScript1.pecarniaUiIsActive == false)
            {
                if (GMScript1.bakeryPopUpIsActive == true)
                {
                    GMScript1.wheatBread++;
                    uiSbor.SetActive(false);
                    GMScript1.bakeryPopUpIsActive = false;
                }
                else
                {



                    Vector3 mousePos;
                    mousePos = Input.mousePosition;
                    mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                    startPosX = mousePos.x - this.transform.localPosition.x;
                    startPosY = mousePos.y - this.transform.localPosition.y;
                    timer = true;

                    moving = true;
                }
            }
        }

    }
    private void OnMouseUp()
    {
        if (GMScript1.pecarniaUiIsActive == false)
        {
            colider1.radius = 2.2f;
            moving = false;
            cameraDisable.SetActive(true);
            timer = false;
            longClick = false;
            growTime = 0;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        if(colision)
        {
            colider1.radius = 2.2f;
            this.gameObject.transform.localPosition = new Vector3(returnPositionX, returnPositionY, this.gameObject.transform.localPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            colision = false;
        }
        if(colision == false)
        {
            returnPositionX = this.transform.localPosition.x;
            returnPositionY = this.transform.localPosition.y;
        }
    }

}
