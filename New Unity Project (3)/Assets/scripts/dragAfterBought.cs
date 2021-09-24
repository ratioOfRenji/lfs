using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragAfterBought : MonoBehaviour
{
    [SerializeField]
    private GameObject building;
    public GameObject cameraDisable;
    private float startPosX;
    private float startPosY;
    private float returnPositionX;
    private float returnPositionY;
    PolygonCollider2D childColider;
    [SerializeField]
    Camera mainCamera;
    private bool colision;
    
    public bool set;
    colidersDisabler ColidersDisabler;
    public bool bought;
    // Start is called before the first frame update
    void Start()
    {
        childColider = GetComponentInChildren<PolygonCollider2D>();
        ColidersDisabler = GameObject.FindGameObjectWithTag("colidersDisabler").GetComponent<colidersDisabler>();

    }
    void OnTriggerStay2D(Collider2D other)
    {
       // Debug.Log("COLLISION");
        colision = true;
       // building.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        colision = false;
        //Debug.Log("exitCollisuon");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if ((bought) && (set == false))
        {
            Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;
            building.transform.position = mouseWorldPosition;
            ColidersDisabler.ColiderDisaibler();

        }
        if ((Input.GetMouseButtonDown(0)) && (set ==false) && (bought))
        {
           // Debug.Log("Pressed primary button.");
            if (colision == false)
            {
                set = true;
                ColidersDisabler.ColiderEnaibler();
                this.gameObject.GetComponent<DragMoveForBuildingNew>().enabled = true;
            }
        }
        if ((set)&&(bought) )
        {
            this.gameObject.GetComponent<dragAfterBought>().enabled = false;
            this.gameObject.GetComponent<DragMoveForBuildingNew>().enabled = true;
        }
    }
    public void activateBool()
    {
        bought = true;
    }
}
