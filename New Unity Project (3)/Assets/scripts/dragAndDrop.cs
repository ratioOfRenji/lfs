using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectrnsform;
    private CanvasGroup canvaasGroup;
    private void Awake()
    {
        rectrnsform = GetComponent<RectTransform>();
        canvaasGroup = GetComponent<CanvasGroup>();
    }
    public void OnPointerDown(PointerEventData eventData) {
        //throw new System.NotImplementedException();
        Debug.Log("on click");
    }
    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("onDrag");
        rectrnsform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("on end  drag");
        canvaasGroup.alpha = 1f;
        canvaasGroup.blocksRaycasts = true;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("on begin drag");
        canvaasGroup.alpha = 0.6f;
        canvaasGroup.blocksRaycasts = false;
    }
  


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
