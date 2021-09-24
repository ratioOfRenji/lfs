using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMiniUI : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;
    [SerializeField]
    private GameObject uiCollect;
    [SerializeField]
    private GameObject plant;
    [SerializeField]
    private Sprite regular;
    [SerializeField]
    private Sprite ready;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if ((plant.GetComponent<SpriteRenderer>().sprite == regular) &&( uiCollect.activeInHierarchy == false))
        {
            ui.SetActive(true);
        }
        if ((plant.GetComponent<SpriteRenderer>().sprite == ready) && (ui.activeInHierarchy == false))
        {
            uiCollect.SetActive(true);
        }
    }
}
