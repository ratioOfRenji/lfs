using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dargAfterBought : MonoBehaviour
{
    public GameObject cameraDisable;
    public GameObject building;
    colidersDisabler ColidersDisabler;
    PolygonCollider2D childColider;

    private float startPosX;
    private float startPosY;
    private bool colision;
    private bool letGo = false;
    private bool isActive = true;
    private void Start()
    {
        
        childColider = GetComponentInChildren<PolygonCollider2D>();
    }
    private void OnMouseDown()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        startPosX = mousePos.x - building.transform.localPosition.x;
        startPosY = mousePos.y - building.transform.localPosition.y;
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        colision = true;
       // building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        colision = false;
       // building.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 1f);
    }

    private void OnMouseUp()
    {
        if (colision == false)
        {
            letGo = true;
            
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            //building.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, building.gameObject.transform.localPosition.z);
            building.gameObject.GetComponent<dargAfterBought>().enabled = false;
            building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            // building = null;
        }
    }
    private void Update()
    {
        if (letGo == false)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            building.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, building.gameObject.transform.localPosition.z);
            building.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 1f);
        }
       
    }
}
