using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class authoCloser : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;
    private bool dragin = false;
    private float returnPositionX;
    private float returnPositionY;
    // Start is called before the first frame update
    void Start()
    {
        returnPositionX = ui.transform.localPosition.x;
        returnPositionY = ui.transform.localPosition.y;
    }
    private void OnMouseDown()
    {
        dragin = true;
    }
    private void OnMouseUp()
    {
        dragin = false;
    }
    // Update is called once per frame
    void Update()
    {
        if((ui.activeInHierarchy) && (dragin == false))
        {
            StartCoroutine(waitBeforeStop());
        }
    }
    IEnumerator waitBeforeStop()
    {
        yield return new WaitForSeconds(5);
        if ((ui.activeInHierarchy) && (dragin == false))
        {
            
            ui.gameObject.transform.localPosition = new Vector3(returnPositionX, returnPositionY, ui.gameObject.transform.localPosition.z);
            ui.SetActive(false);
        }
    }
}
