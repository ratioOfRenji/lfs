using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickStageCheckerOrangeTree1 : MonoBehaviour
{

    public float timerToLongClick;
    public float timerToDoubleClick;
    private bool clickCheker;
    private bool timerToDoubleClickIsActive;
    [SerializeField]
    public static clickState ClickState = clickState.noClick;
    void OnMouseDown()
    {
        clickCheker = true;

    }
    public void OnMouseUp()
    {

        timerToDoubleClickIsActive = true;
        timerToLongClick = 0f;
        clickCheker = false;
        ClickState = clickState.noClick;
    }

    private void Update()
    {
        switch (ClickState)
        {
            case clickState.noClick:

                if (clickCheker)
                {
                    ClickState = clickState.click;
                }

                break;
            case clickState.click:
                doClick();
                if (timerToLongClick >= 2f)
                {
                    ClickState = clickState.longClick;
                }
                else if ((timerToDoubleClick < 0.2f) && (timerToDoubleClick > 0.01))
                {
                    ClickState = clickState.doubleClick;
                }

                break;
            case clickState.doubleClick:
                doDoubleClick();
                break;
            case clickState.longClick:
                doLongClick();

                break;




        }
        if (timerToDoubleClickIsActive)
        {
            timerToDoubleClick += Time.deltaTime;
        }
        if (timerToDoubleClick > 0.2f)
        {
            timerToDoubleClickIsActive = false;
            timerToDoubleClick = 0;

        }
    }

    private void doClick()
    {
        timerToLongClick += Time.deltaTime;


    }
    private void doDoubleClick()
    {

        timerToDoubleClickIsActive = false;
        timerToDoubleClick = 0f;

    }
    private void doLongClick()
    {

    }
    public enum clickState
    {
        noClick,
        click,
        doubleClick,
        longClick

    }
}
