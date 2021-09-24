using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropMeShreder : MonoBehaviour, IDropHandler

{
    cookShreder Cook;

    public GameObject item1;
    public GameObject item2;
    
    public Transform teleportTarget1;
    public Transform teleportTarget2;
   

    void Start()
    {
        Cook = GameObject.FindGameObjectWithTag("shreder").GetComponent<cookShreder>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("onDrop");
        if (eventData.pointerDrag == item1)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            item1.transform.position = teleportTarget1.transform.position;
            // Debug.Log("готовим сыр!");
            Cook.CookSugar();


        }
        if (eventData.pointerDrag == item2)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            item2.transform.position = teleportTarget2.transform.position;
            Cook.CookCoffee();
            // Debug.Log("готовим масло!");

        }
        
    }
}
