using UnityEngine;
using UnityEngine.EventSystems;

public class dropMe : MonoBehaviour, IDropHandler
{
    cookMilkFactory Cook;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public Transform teleportTarget1;
    public Transform teleportTarget2;
    public Transform teleportTarget3;

    void Start()
    {
        Cook = GameObject.FindGameObjectWithTag("milk").GetComponent<cookMilkFactory>();
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
            Cook.CookCheese();
            

        }
        if (eventData.pointerDrag == item2)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            item2.transform.position = teleportTarget2.transform.position;
            Cook.CookButter();
           // Debug.Log("готовим масло!");

        }
        if (eventData.pointerDrag == item3)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            item3.transform.position = teleportTarget3.transform.position;
            Cook.CookYogurt();
          //  Debug.Log("готовим йогурт!");

        }
    }
}