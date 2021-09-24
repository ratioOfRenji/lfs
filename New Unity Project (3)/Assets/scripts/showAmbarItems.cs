using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showAmbarItems : MonoBehaviour
{
    public GameObject[] UiObjects;
    public int[] ammountOfExp;
    //public Image[] coins;
   // public Button[] buttonArray;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int i;
        for (i = 0; i < UiObjects.Length; i++)
        {
            if (ammountOfExp[i] > lvlMaster.currentLvl)
            {
                UiObjects[i].SetActive(false);
                // coins[i].GetComponent<Image>().color = new Color(0.3f, 0.4f, 0.6f);
                // buttonArray[i].GetComponent<Image>().color = new Color(0.3f, 0.4f, 0.6f);
            }
            else
            {
                UiObjects[i].SetActive(true);
                // coins[i].GetComponent<Image>().color = new Color(1f, 1f, 1f);
                // buttonArray[i].GetComponent<Image>().color = new Color(1f, 1f, 1f);
            }

        }
        if (i >= UiObjects.Length)
        {
            i = 0;
        }
    }
}
