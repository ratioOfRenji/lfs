using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefAnimals : MonoBehaviour
{
    public static void SaveDataHen(playerHen player)
    {
        PlayerPrefs.SetInt("valueForBool.Hen", player.valueForBool);


        PlayerPrefs.SetFloat("x.Hen", player.transform.position.x);
        PlayerPrefs.SetFloat("y.Hen", player.transform.position.y);
        PlayerPrefs.SetFloat("z.Hen", player.transform.position.z);

        
      
    }
    public static animalsData LoadDataHen()
    {
        int valueBol = PlayerPrefs.GetInt("valueForBool.Hen");


        float x = PlayerPrefs.GetFloat("x.Hen");
        float y = PlayerPrefs.GetFloat("y.Hen");
        float z = PlayerPrefs.GetFloat("z.Hen");


        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Hen");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Hen");

        animalsData animalsData = new animalsData()
        {
             valueForBoolHen = valueBol,

             LocationHen = new Vector3(x, y, z),

           

          


        };
        return animalsData;
    }

    public static void SaveDataHenOne(playerHenTwo player)
    {
        //PlayerPrefs.SetInt("valueForBool.HenOne", player.valueForBool);
        PlayerPrefs.SetInt("valueForSprite.HenOne", player.valueSprite);
        PlayerPrefs.SetFloat("OneTimer.HenOne", player.oneTimer);
    }
    public static animalsData LoadDataHenOne()
    {
        //int valueBol = PlayerPrefs.GetInt("valueForBool.HenOne");



        int valueSprite = PlayerPrefs.GetInt("valueForSprite.HenOne");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.HenOne");

        animalsData animalsData = new animalsData()
        {
            //valueForBoolHenOne = valueBol,

           

            spriteVaueHenOne = valueSprite,
            oneTimerHenOne = oneTimer





        };
        return animalsData;
    }

    public static void SaveDataCowBarn(playerCowBarn player)
    {
        PlayerPrefs.SetInt("valueForBool.Cow", player.valueForBool);


        PlayerPrefs.SetFloat("x.Cow", player.transform.position.x);
        PlayerPrefs.SetFloat("y.Cow", player.transform.position.y);
        PlayerPrefs.SetFloat("z.Cow", player.transform.position.z);



    }
    public static animalsData LoadDataCowBarn()
    {
        int valueBol = PlayerPrefs.GetInt("valueForBool.Cow");


        float x = PlayerPrefs.GetFloat("x.Cow");
        float y = PlayerPrefs.GetFloat("y.Cow");
        float z = PlayerPrefs.GetFloat("z.Cow");


        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Cow");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Cow");

        animalsData animalsData = new animalsData()
        {
            valueForBoolCow = valueBol,

            LocationCow = new Vector3(x, y, z),






        };
        return animalsData;
    }
    public static void SaveDataCow(playerCow player)
    {
        //PlayerPrefs.SetInt("valueForBool.HenOne", player.valueForBool);
        PlayerPrefs.SetInt("valueForSprite.Cow ", player.valueSprite);
        PlayerPrefs.SetFloat("OneTimer.Cow ", player.oneTimer);
    }
    public static animalsData LoadDataCow()
    {
        //int valueBol = PlayerPrefs.GetInt("valueForBool.HenOne");



        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Cow ");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Cow ");

        animalsData animalsData = new animalsData()
        {
            //valueForBoolHenOne = valueBol,



            spriteVaueCow = valueSprite,
            oneTimerCow = oneTimer





        };
        return animalsData;
    }

    public static void SaveDataGoatBarn(playerGoatBarn player)
    {
        PlayerPrefs.SetInt("valueForBool.Goat", player.valueForBool);


        PlayerPrefs.SetFloat("x.Goat", player.transform.position.x);
        PlayerPrefs.SetFloat("y.Goat", player.transform.position.y);
        PlayerPrefs.SetFloat("z.Goat", player.transform.position.z);



    }
    public static animalsData LoadDataGoatBarn()
    {
        int valueBol = PlayerPrefs.GetInt("valueForBool.Goat");


        float x = PlayerPrefs.GetFloat("x.Goat");
        float y = PlayerPrefs.GetFloat("y.Goat");
        float z = PlayerPrefs.GetFloat("z.Goat");


        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Goat");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Goat");

        animalsData animalsData = new animalsData()
        {
            valueForBoolGoat = valueBol,

            LocationGoat = new Vector3(x, y, z),






        };
        return animalsData;
    }
    public static void SaveDataGoat(playerGoat player)
    {
        //PlayerPrefs.SetInt("valueForBool.HenOne", player.valueForBool);
        PlayerPrefs.SetInt("valueForSprite.Goat ", player.valueSprite);
        PlayerPrefs.SetFloat("OneTimer.Goat ", player.oneTimer);
    }
    public static animalsData LoadDataGoat()
    {
        //int valueBol = PlayerPrefs.GetInt("valueForBool.HenOne");



        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Goat ");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Goat ");

        animalsData animalsData = new animalsData()
        {
            //valueForBoolHenOne = valueBol,



            spriteVaueGoat = valueSprite,
            oneTimerGoat = oneTimer





        };
        return animalsData;
    }
    public static void SaveDataCock(playerCock player)
    {
        //PlayerPrefs.SetInt("valueForBool.HenOne", player.valueForBool);
        PlayerPrefs.SetInt("valueForSprite.Cock ", player.valueSprite);
        PlayerPrefs.SetFloat("OneTimer.Cock ", player.oneTimer);
    }
    public static animalsData LoadDataCock()
    {
        //int valueBol = PlayerPrefs.GetInt("valueForBool.HenOne");



        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Cock ");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Cock ");

        animalsData animalsData = new animalsData()
        {
            //valueForBoolHenOne = valueBol,



            spriteVaueCock = valueSprite,
            oneTimerCock = oneTimer





        };
        return animalsData;
    }

    public static void SaveDataSheepBarn(playerSheepBarn player)
    {
        PlayerPrefs.SetInt("valueForBool.Sheep", player.valueForBool);


        PlayerPrefs.SetFloat("x.Sheep", player.transform.position.x);
        PlayerPrefs.SetFloat("y.Sheep", player.transform.position.y);
        PlayerPrefs.SetFloat("z.Sheep", player.transform.position.z);



    }
    public static animalsData LoadDataSheepBarn()
    {
        int valueBol = PlayerPrefs.GetInt("valueForBool.Sheep");


        float x = PlayerPrefs.GetFloat("x.Sheep");
        float y = PlayerPrefs.GetFloat("y.Sheep");
        float z = PlayerPrefs.GetFloat("z.Sheep");


        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Sheep");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Sheep");

        animalsData animalsData = new animalsData()
        {
            valueForBoolSheep = valueBol,

            LocationSheep = new Vector3(x, y, z),






        };
        return animalsData;
    }
    public static void SaveDataSheep(playerSheep player)
    {
        //PlayerPrefs.SetInt("valueForBool.HenOne", player.valueForBool);
        PlayerPrefs.SetInt("valueForSprite.Sheep ", player.valueSprite);
        PlayerPrefs.SetInt("valueForBodySprite.Sheep ", player.valueBodySprite);
        PlayerPrefs.SetFloat("OneTimer.Sheep ", player.oneTimer);
    }
    public static animalsData LoadDataSheep()
    {
        //int valueBol = PlayerPrefs.GetInt("valueForBool.HenOne");



        int valueSprite = PlayerPrefs.GetInt("valueForSprite.Sheep ");
        int valueBodySprite = PlayerPrefs.GetInt("valueForBodySprite.Sheep ");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Sheep ");

        animalsData animalsData = new animalsData()
        {
            //valueForBoolHenOne = valueBol,



            spriteVaueSheep = valueSprite,
            oneTimerSheep = oneTimer,
            spriteBodyVaueSheep = valueBodySprite





        };
        return animalsData;
    }
}

public class animalsData
{
    public int valueForBoolHen;
    public Vector3 LocationHen { get; set; }

    public int valueForBoolHenOne;
    public int spriteVaueHenOne;
    public float oneTimerHenOne;



    public int valueForBoolCow;
    public Vector3 LocationCow { get; set; }
    public int spriteVaueCow;
    public float oneTimerCow;

    public int valueForBoolGoat;
    public Vector3 LocationGoat { get; set; }
    public int spriteVaueGoat;
    public float oneTimerGoat;

    public int valueForBoolSheep;
    public Vector3 LocationSheep { get; set; }
    public int spriteVaueSheep;
    public int spriteBodyVaueSheep;
    public float oneTimerSheep;

    public int valueForBoolCock;
    public Vector3 LocationCock { get; set; }
    public int spriteVaueCock;
    public int spriteBodyVaueCock;
    public float oneTimerCock;


}