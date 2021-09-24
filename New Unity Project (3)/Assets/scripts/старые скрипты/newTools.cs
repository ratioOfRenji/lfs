using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newTools : MonoBehaviour
{
    public Transform seedInventory;
    public Transform buy;
    public Transform sell;
    public Transform kuriatnic;
    public Transform kuritsa;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "scythe")
        {
            GMScript1.currentTool = "scythe";
            Debug.Log(GMScript1.currentTool);
        }
        if (gameObject.name == "семена")
        {
            GMScript1.currentTool = "семена";
            seedInventory.transform.position = new Vector2(4.55f, -4);

        }
        if (gameObject.name == "vedro1")
        {
            GMScript1.currentTool = "vedro1";

        }
        if (gameObject.name == "кормить")
        {
            GMScript1.currentTool = "кормить";

        }
        Debug.Log(GMScript1.currentTool);
        
    }
    
}
