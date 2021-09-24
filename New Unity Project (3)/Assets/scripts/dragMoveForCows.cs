using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragMoveForCows : MonoBehaviour
{
    public GameObject bakeryUi;
    public GameObject cameraDisable;
    public GameObject uiSbor;
    public CircleCollider2D coliderToClickOnBuilding;
    private float startPosX;
    private float startPosY;
    private float returnPositionX;
    private float returnPositionY;
    private bool colision;

    void Start()
    {
        returnPositionX = this.transform.localPosition.x;
        returnPositionY = this.transform.localPosition.y;
        coliderToClickOnBuilding = coliderToClickOnBuilding.GetComponent<CircleCollider2D>();
    }

    private void OnMouseDown()
    {


        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        startPosX = mousePos.x - this.transform.localPosition.x;
        startPosY = mousePos.y - this.transform.localPosition.y;

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


        if (clickStageCheckerWoolFactory.ClickState == clickStageCheckerWoolFactory.clickState.noClick)
        {
            coliderToClickOnBuilding.radius = 2.2f;
            if (GMScript1.pecarniaUiIsActive == false)
            {
                cameraDisable.SetActive(true);
            }

            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }

        if (clickStageCheckerWoolFactory.ClickState == clickStageCheckerWoolFactory.clickState.click)
        {



        }
        if (clickStageCheckerWoolFactory.ClickState == clickStageCheckerWoolFactory.clickState.doubleClick)
        {
            bakeryUi.SetActive(true);
            cameraDisable.SetActive(false);
            GMScript1.pecarniaUiIsActive = true;
        }
        if (clickStageCheckerWoolFactory.ClickState == clickStageCheckerWoolFactory.clickState.longClick)
        {
            coliderToClickOnBuilding.radius = 0;
            cameraDisable.SetActive(false);
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 1f);

        }
        if ((colision) && (clickStageCheckerWoolFactory.ClickState == clickStageCheckerWoolFactory.clickState.longClick))
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
        }

    }
    private void OnMouseUp()
    {

        if (colision)
        {
            coliderToClickOnBuilding.radius = 2.2f;
            this.gameObject.transform.localPosition = new Vector3(returnPositionX, returnPositionY, this.gameObject.transform.localPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            colision = false;
        }
        if (colision == false)
        {
            coliderToClickOnBuilding.radius = 2.2f;
            returnPositionX = this.transform.localPosition.x;
            returnPositionY = this.transform.localPosition.y;
        }
    }
}
