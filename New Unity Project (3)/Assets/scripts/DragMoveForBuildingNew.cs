using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMoveForBuildingNew : MonoBehaviour
{
    [SerializeField]
    private GameObject building;
    public GameObject cameraDisable;
    public static int disableColiders;
    private float startPosX;
    private float startPosY;
    public float returnPositionX;
    public float returnPositionY;
    colidersDisabler ColidersDisabler;
    PolygonCollider2D childColider;
    private bool colision;

    private float time = 0;
    private const float longClick = 1.5f;
    private bool clicked;
   

    void Start()
    {
        returnPositionX = building.transform.localPosition.x;
        returnPositionY = building.transform.localPosition.y;
        ColidersDisabler = GameObject.FindGameObjectWithTag("colidersDisabler").GetComponent<colidersDisabler>();
        childColider = GetComponentInChildren<PolygonCollider2D>();
        

    }
    private void OnMouseDown()
    {

        clicked = true;
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        startPosX = mousePos.x - building.transform.localPosition.x;
        startPosY = mousePos.y - building.transform.localPosition.y;
        ColidersDisabler.ColiderDisaibler();
       

    }
    private void OnMouseUp()
    {
        clicked = false;
        time = 0;
        cameraDisable.SetActive(true);
        building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        ColidersDisabler.ColiderEnaibler();
        if (colision)
        {

            building.gameObject.transform.localPosition = new Vector3(returnPositionX, returnPositionY, building.gameObject.transform.localPosition.z);
            building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
            colision = false;
        }
        if (colision == false)
        {
            
            returnPositionX = building.transform.localPosition.x;
            returnPositionY = building.transform.localPosition.y;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
       // Debug.Log("COLLISION");
        colision = true;
        //building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        colision = false;
    }
    private void Update()
    {
        if(clicked)
        {
            time += Time.deltaTime;
        }
        if(time >= longClick)
        {
            
            cameraDisable.SetActive(false);
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            building.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            building.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 1f);

        }
        if((colision == true) && (time >= longClick))
        {
          // Debug.Log("COLLISION");
            building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
        }
        if ((colision == true) && (time < longClick))
        {
            building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
    }
}
