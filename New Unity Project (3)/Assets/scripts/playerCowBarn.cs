using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCowBarn : MonoBehaviour
{
    public int valueForBool;
    public animalsData PlayerData { get; private set; }
    private void OnEnable()
    {
        PlayerData = playerPrefAnimals.LoadDataCowBarn();



        transform.position = PlayerData.LocationCow;


        if (PlayerData.valueForBoolCow == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.valueForBoolCow== 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }

    }

    private void OnDisable()
    {
        playerPrefAnimals.SaveDataCowBarn(this);
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
