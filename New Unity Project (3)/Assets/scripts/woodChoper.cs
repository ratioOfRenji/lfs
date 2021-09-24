using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodChoper : MonoBehaviour
{
    public GameObject gameObjectToDestroy;
    public GameObject uiToDestroy;
    private bool popUpIsActive;
    private void OnMouseDown()
    {
        if(GMScript1.money > 300)
        {
           // gameObjectToDestroy.gameObject.transform.position = new Vector3(-77.5f, 69.4f, 0f);
            Destroy(gameObjectToDestroy);
            GMScript1.money -= 300;
           

        }
    }
   
}
