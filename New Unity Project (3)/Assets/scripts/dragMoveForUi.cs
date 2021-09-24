using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragMoveForUi : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;
    [SerializeField]
    private GameObject cameraDisable;
    private float startPosX;
    private float startPosY;
    private float returnPositionX;
    private float returnPositionY;
    private bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        returnPositionX = ui.transform.localPosition.x;
        returnPositionY = ui.transform.localPosition.y;
    }
    private void OnMouseDown()
    {

        clicked = true;
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        startPosX = mousePos.x - ui.transform.localPosition.x;
        startPosY = mousePos.y - ui.transform.localPosition.y;
       


    }
    private void OnMouseUp()
    {
        clicked = false;
        cameraDisable.SetActive(true);
        ui.gameObject.transform.localPosition = new Vector3(returnPositionX, returnPositionY, ui.gameObject.transform.localPosition.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (clicked)
        {
       

            cameraDisable.SetActive(false);
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            ui.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
           

        }
    }
}
