using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragMoveForAppleTree1 : MonoBehaviour
{
    public GameObject cameraDisable;

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


        if (clickStageCheckerAppleTree1.ClickState == clickStageCheckerAppleTree1.clickState.noClick)
        {
            coliderToClickOnBuilding.radius = 1.44f;
            if (GMScript1.pecarniaUiIsActive == false)
            {
                cameraDisable.SetActive(true);
            }

            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }

        if (clickStageCheckerAppleTree1.ClickState == clickStageCheckerAppleTree1.clickState.click)
        {



        }
        if (clickStageCheckerAppleTree1.ClickState == clickStageCheckerAppleTree1.clickState.doubleClick)
        {

            cameraDisable.SetActive(false);
            GMScript1.pecarniaUiIsActive = true;
        }
        if (clickStageCheckerAppleTree1.ClickState == clickStageCheckerAppleTree1.clickState.longClick)
        {
            coliderToClickOnBuilding.radius = 0;
            cameraDisable.SetActive(false);
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 1f);

        }
        if ((colision) && (clickStageCheckerAppleTree1.ClickState == clickStageCheckerAppleTree1.clickState.longClick))
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
        }

    }
    private void OnMouseUp()
    {

        if (colision)
        {
            coliderToClickOnBuilding.radius = 1.44f;
            this.gameObject.transform.localPosition = new Vector3(returnPositionX, returnPositionY, this.gameObject.transform.localPosition.z);
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            colision = false;
        }
        if (colision == false)
        {
            coliderToClickOnBuilding.radius = 1.44f;
            returnPositionX = this.transform.localPosition.x;
            returnPositionY = this.transform.localPosition.y;
        }
    }
}
