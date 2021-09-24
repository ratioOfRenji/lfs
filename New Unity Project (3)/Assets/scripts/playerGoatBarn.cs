using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGoatBarn : MonoBehaviour
{
    public int valueForBool;
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataGoatBarn();



        transform.position = PlayerData.LocationGoat;


        if (PlayerData.valueForBoolGoat == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolGoat == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }

    }

    private void OnDisable()
    {
        playerPrefAnimals.SaveDataGoatBarn(this);
    }
    private void Update()
    {

        if (this.gameObject.GetComponent<dragAfterBought>().bought == true)
        {
            valueForBool = 1;
        }
        if (this.gameObject.GetComponent<dragAfterBought>().bought == false)
        {
            valueForBool = 0;
        }


    }
}
