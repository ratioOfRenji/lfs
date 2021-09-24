using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupit : MonoBehaviour
{
    public GameObject kupitUI;
    public GameObject prodatUI;
    public GameObject semenaUI;
    public GameObject cameraDisable;
   
    bool semenaActive;
    

    // Update is called once per frame
    void Update()
    {
        if (kupitUI.gameObject.activeInHierarchy)
        {
            cameraDisable.SetActive(false);
        }
    }
    public void getKupitUI()
    {


        kupitUI.SetActive(true);
        
    }
    public void hideKupitUI()
    {
        kupitUI.SetActive(false);
        
    }
    public void getProdatUI()
    {


        prodatUI.SetActive(true);

    }
    public void hideProdatUI()
    {
        prodatUI.SetActive(false);
    }

    public void SemenaUI()
    {
     if (semenaActive == false)
        {
            semenaUI.SetActive(true);
            semenaActive = true;
        }
     else
        {
            semenaUI.SetActive(false);
            semenaActive = false;
        }
       
    }
 

}
