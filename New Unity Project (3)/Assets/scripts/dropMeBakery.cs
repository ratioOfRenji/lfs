using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropMeBakery : MonoBehaviour, IDropHandler
{
    cookBakery Cook;

    public GameObject item1;
    public GameObject item2;
   // public GameObject item3;
    public Transform teleportTarget1;
    public Transform teleportTarget2;
    //public Transform teleportTarget3;

    void Start()
    {
        Cook = GameObject.FindGameObjectWithTag("bakery").GetComponent<cookBakery>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("droponDrop");
        if (eventData.pointerDrag == item1)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            item1.transform.position = teleportTarget1.transform.position;
            // Debug.Log("готовим сыр!");
            Cook.CookWheatBread();


        }
        if (eventData.pointerDrag == item2)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            item2.transform.position = teleportTarget2.transform.position;
            Cook.CookWhiteBread();
            // Debug.Log("готовим масло!");

        }
        
    }
}
