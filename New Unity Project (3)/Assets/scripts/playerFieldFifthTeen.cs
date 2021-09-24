using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFieldFifthTeen : MonoBehaviour
{
    public int number;
    public float timer;
    public GameObject field;
    public Sprite[] firstImages;
    public Sprite[] secondImages;
    public int valueForBool;
    public fieldsData PlayerData { get; private set; }
    private void OnEnable()
    {

        PlayerData = playerPrefField.LoadDataFieldFifthTeen();
        field.GetComponent<newPlanting3>().growTime = PlayerData.timerFieldFifthteen;
        if (field.GetComponent<newPlanting3>().growTime > 0)
        {
            field.GetComponent<newPlanting3>().growTime = PlayerData.timerFieldFifthteen += TimeMaster.CheckDate();
        }
        this.gameObject.transform.position = PlayerData.LocationFieldFifthteen;
field.GetComponent<SpriteRenderer>().sprite = firstImages[PlayerData.numberFieldFifthteen];
        //field.transform.position = PlayerData.LocationFieldOne;
        if (field.GetComponent<newPlanting3>().growTime < 5)
        {
            
        }
        if (field.GetComponent<newPlanting3>().growTime >= 5)
        {
           // field.GetComponent<SpriteRenderer>().sprite = secondImages[PlayerData.numberFieldFifthteen];
        }
        if (PlayerData.boolFieldFifthteen == 1)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = true;
            this.gameObject.GetComponent<dragAfterBought>().set = true;
        }
        if (PlayerData.boolFieldFifthteen == 0)
        {
            this.gameObject.GetComponent<dragAfterBought>().bought = false;
            this.gameObject.GetComponent<dragAfterBought>().set = false;
        }
    }

    private void OnDisable()
    {
        playerPrefField.SaveDataFieldFifthTeen(this);
    }
    private void Update()
    {
        timer = field.GetComponent<newPlanting3>().growTime;
        if (this.gameObject.GetComponent<dragAfterBought>().bought == true)
        {
            valueForBool = 1;
        }
        if (this.gameObject.GetComponent<dragAfterBought>().bought == false)
        {
            valueForBool = 0;
        }

        if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[0]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[0]))
        {
            number = 0;
        }
        if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[1]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[1]))
        {
            number = 1;
        }
        if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[2]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[2]))
        {
            number = 2;
        }

        if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[3]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[3]))
        {
            number = 3;
        }
        if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[4]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[4]))
        {
            number = 4;
        }
        if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[5]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[5]))
        {
            number = 5;
        }
        //if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[6]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[6]))
        //{
        //    number = 6;
        //}
        //if ((field.GetComponent<SpriteRenderer>().sprite == firstImages[7]) || (field.GetComponent<SpriteRenderer>().sprite == secondImages[7]))
        //{
        //    number = 7;
        //}

    }
}
