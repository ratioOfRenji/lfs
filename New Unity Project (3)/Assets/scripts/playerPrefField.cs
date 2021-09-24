using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefField : MonoBehaviour
{
    public static void SaveDataFieldOne(playerFieldOne fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldOne", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldOne", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldOne", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldOne", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldOne", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldOne", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldOne()
    {
        float x = PlayerPrefs.GetFloat("x.FieldOne");
        float y = PlayerPrefs.GetFloat("y.FieldOne");
        float z = PlayerPrefs.GetFloat("z.FieldOne");
        int number = PlayerPrefs.GetInt("number.FieldOne");
        float timer = PlayerPrefs.GetFloat("timer.FieldOne");
        int valueBol = PlayerPrefs.GetInt("bool.FieldOne");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldOne = timer,
            LocationFieldOne = new Vector3(x, y, z),
            boolFieldOne = valueBol,
            numberFieldOne = number
        };
        return playerData;
    }

    public static void SaveDataFieldTwo(playerFieldTwo fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldTwo", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldTwo", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldTwo", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldTwo", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldTwo", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldTwo", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldTwo()
    {
        float x = PlayerPrefs.GetFloat("x.FieldTwo");
        float y = PlayerPrefs.GetFloat("y.FieldTwo");
        float z = PlayerPrefs.GetFloat("z.FieldTwo");
        int number = PlayerPrefs.GetInt("number.FieldTwo");
        float timer = PlayerPrefs.GetFloat("timer.FieldTwo");
        int valueBol = PlayerPrefs.GetInt("bool.FieldTwo");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldTwo = timer,
            LocationFieldTwo = new Vector3(x, y, z),
            boolFieldTwo = valueBol,
            numberFieldTwo = number
        };
        return playerData;
    }

    public static void SaveDataFieldThree(playerFieldThree fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldThree", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldThree", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldThree", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldThree", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldThree", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldThree", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldThree()
    {
        float x = PlayerPrefs.GetFloat("x.FieldThree");
        float y = PlayerPrefs.GetFloat("y.FieldThree");
        float z = PlayerPrefs.GetFloat("z.FieldThree");
        int number = PlayerPrefs.GetInt("number.FieldThree");
        float timer = PlayerPrefs.GetFloat("timer.FieldThree");
        int valueBol = PlayerPrefs.GetInt("bool.FieldThree");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldThree = timer,
            LocationFieldThree = new Vector3(x, y, z),
            boolFieldThree = valueBol,
            numberFieldThree = number
        };
        return playerData;
    }

    public static void SaveDataFieldFour(playerFieldFour fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldFour", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldFour", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldFour", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldFour", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldFour", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldFour", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldFour()
    {
        float x = PlayerPrefs.GetFloat("x.FieldFour");
        float y = PlayerPrefs.GetFloat("y.FieldFour");
        float z = PlayerPrefs.GetFloat("z.FieldFour");
        int number = PlayerPrefs.GetInt("number.FieldFour");
        float timer = PlayerPrefs.GetFloat("timer.FieldFour");
        int valueBol = PlayerPrefs.GetInt("bool.FieldFour");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldFour = timer,
            LocationFieldFour = new Vector3(x, y, z),
            boolFieldFour = valueBol,
            numberFieldFour = number
        };
        return playerData;
    }

    public static void SaveDataFieldFive(playerFieldFive fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldFive", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldFive", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldFive", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldFive", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldFive", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldFive", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldFive()
    {
        float x = PlayerPrefs.GetFloat("x.FieldFive");
        float y = PlayerPrefs.GetFloat("y.FieldFive");
        float z = PlayerPrefs.GetFloat("z.FieldFive");
        int number = PlayerPrefs.GetInt("number.FieldFive");
        float timer = PlayerPrefs.GetFloat("timer.FieldFive");
        int valueBol = PlayerPrefs.GetInt("bool.FieldFive");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldFive = timer,
            LocationFieldFive = new Vector3(x, y, z),
            boolFieldFive = valueBol,
            numberFieldFive = number
        };
        return playerData;
    }
    public static void SaveDataFieldSix(playerFieldSix fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldSix", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldSix", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldSix", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldSix", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldSix", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldSix", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldSix()
    {
        float x = PlayerPrefs.GetFloat("x.FieldSix");
        float y = PlayerPrefs.GetFloat("y.FieldSix");
        float z = PlayerPrefs.GetFloat("z.FieldSix");
        int number = PlayerPrefs.GetInt("number.FieldSix");
        float timer = PlayerPrefs.GetFloat("timer.FieldSix");
        int valueBol = PlayerPrefs.GetInt("bool.FieldSix");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldSix = timer,
            LocationFieldSix = new Vector3(x, y, z),
            boolFieldSix = valueBol,
            numberFieldSix = number
        };
        return playerData;
    }

    public static void SaveDataFieldSeven(playerFieldSeven fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldSeven", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldSeven", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldSeven", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldSeven", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldSeven", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldSeven", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldSeven()
    {
        float x = PlayerPrefs.GetFloat("x.FieldSeven");
        float y = PlayerPrefs.GetFloat("y.FieldSeven");
        float z = PlayerPrefs.GetFloat("z.FieldSeven");
        int number = PlayerPrefs.GetInt("number.FieldSeven");
        float timer = PlayerPrefs.GetFloat("timer.FieldSeven");
        int valueBol = PlayerPrefs.GetInt("bool.FieldSeven");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldSeven = timer,
            LocationFieldSeven = new Vector3(x, y, z),
            boolFieldSeven = valueBol,
            numberFieldSeven = number
        };
        return playerData;
    }

    public static void SaveDataFieldEight(playerFieldEight fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldEight", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldEight", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldEight", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldEight", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldEight", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldEight", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldEight()
    {
        float x = PlayerPrefs.GetFloat("x.FieldEight");
        float y = PlayerPrefs.GetFloat("y.FieldEight");
        float z = PlayerPrefs.GetFloat("z.FieldEight");
        int number = PlayerPrefs.GetInt("number.FieldEight");
        float timer = PlayerPrefs.GetFloat("timer.FieldEight");
        int valueBol = PlayerPrefs.GetInt("bool.FieldEight");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldEight = timer,
            LocationFieldEight = new Vector3(x, y, z),
            boolFieldEight = valueBol,
            numberFieldEight = number
        };
        return playerData;
    }

    public static void SaveDataFieldNine(playerFieldNine fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldNine", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldNine", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldNine", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldNine", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldNine", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldNine", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldNine()
    {
        float x = PlayerPrefs.GetFloat("x.FieldNine");
        float y = PlayerPrefs.GetFloat("y.FieldNine");
        float z = PlayerPrefs.GetFloat("z.FieldNine");
        int number = PlayerPrefs.GetInt("number.FieldNine");
        float timer = PlayerPrefs.GetFloat("timer.FieldNine");
        int valueBol = PlayerPrefs.GetInt("bool.FieldNine");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldNine = timer,
            LocationFieldNine = new Vector3(x, y, z),
            boolFieldNine = valueBol,
            numberFieldNine = number
        };
        return playerData;
    }
    public static void SaveDataFieldTen(playerFieldTen fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldTen", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldTen", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldTen", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldTen", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldTen", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldTen", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldTen()
    {
        float x = PlayerPrefs.GetFloat("x.FieldTen");
        float y = PlayerPrefs.GetFloat("y.FieldTen");
        float z = PlayerPrefs.GetFloat("z.FieldTen");
        int number = PlayerPrefs.GetInt("number.FieldTen");
        float timer = PlayerPrefs.GetFloat("timer.FieldTen");
        int valueBol = PlayerPrefs.GetInt("bool.FieldTen");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldTen = timer,
            LocationFieldTen = new Vector3(x, y, z),
            boolFieldTen = valueBol,
            numberFieldTen = number
        };
        return playerData;
    }

    public static void SaveDataFieldEleven(playerFieldEleven fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldEleven", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldEleven", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldEleven", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldEleven", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldEleven", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldEleven", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldEleven()
    {
        float x = PlayerPrefs.GetFloat("x.FieldEleven");
        float y = PlayerPrefs.GetFloat("y.FieldEleven");
        float z = PlayerPrefs.GetFloat("z.FieldEleven");
        int number = PlayerPrefs.GetInt("number.FieldEleven");
        float timer = PlayerPrefs.GetFloat("timer.FieldEleven");
        int valueBol = PlayerPrefs.GetInt("bool.FieldEleven");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldEleven = timer,
            LocationFieldEleven = new Vector3(x, y, z),
            boolFieldEleven = valueBol,
            numberFieldEleven = number
        };
        return playerData;
    }
    public static void SaveDataFieldTwelve(playerFieldTwelve fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldTwelve", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldTwelve", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldTwelve", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldTwelve", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldTwelve", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldTwelve", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldTwelve()
    {
        float x = PlayerPrefs.GetFloat("x.FieldTwelve");
        float y = PlayerPrefs.GetFloat("y.FieldTwelve");
        float z = PlayerPrefs.GetFloat("z.FieldTwelve");
        int number = PlayerPrefs.GetInt("number.FieldTwelve");
        float timer = PlayerPrefs.GetFloat("timer.FieldTwelve");
        int valueBol = PlayerPrefs.GetInt("bool.FieldTwelve");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldTwelve = timer,
            LocationFieldTwelve = new Vector3(x, y, z),
            boolFieldTwelve = valueBol,
            numberFieldTwelve = number
        };
        return playerData;
    }
    public static void SaveDataFieldThirteen(playerFieldThirteen fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldThirteen", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldThirteen", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldThirteen", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldThirteen", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldThirteen", fieldOne.timer);
        
        PlayerPrefs.SetInt("bool.FieldThirteen", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldThirteen()
    {
        float x = PlayerPrefs.GetFloat("x.FieldThirteen");
        float y = PlayerPrefs.GetFloat("y.FieldThirteen");
        float z = PlayerPrefs.GetFloat("z.FieldThirteen");
        int number = PlayerPrefs.GetInt("number.FieldThirteen");
        float timer = PlayerPrefs.GetFloat("timer.FieldThirteen");
        int valueBol = PlayerPrefs.GetInt("bool.FieldThirteen");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldThirteen = timer,
            LocationFieldThirteen = new Vector3(x, y, z),
            boolFieldThirteen = valueBol,
            numberFieldThirteen = number
        };
        return playerData;
    }

    public static void SaveDataFieldFourteen(playerFieldFourteen fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldFourteen", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldFourteen", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldFourteen", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldFourteen", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldFourteen", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldFourteen", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldFourteen()
    {
        float x = PlayerPrefs.GetFloat("x.FieldFourteen");
        float y = PlayerPrefs.GetFloat("y.FieldFourteen");
        float z = PlayerPrefs.GetFloat("z.FieldFourteen");
        int number = PlayerPrefs.GetInt("number.FieldFourteen");
        float timer = PlayerPrefs.GetFloat("timer.FieldFourteen");
        int valueBol = PlayerPrefs.GetInt("bool.FieldFourteen");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldFourteen = timer,
            LocationFieldFourteen = new Vector3(x, y, z),
            boolFieldFourteen = valueBol,
            numberFieldFourteen = number
        };
        return playerData;
    }
    public static void SaveDataFieldFifthTeen(playerFieldFifthTeen fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldFifthTeen", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldFifthTeen", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldFifthTeen", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldFifthTeen", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldFifthTeen", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldFifthTeen", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldFifthTeen()
    {
        float x = PlayerPrefs.GetFloat("x.FieldFifthTeen");
        float y = PlayerPrefs.GetFloat("y.FieldFifthTeen");
        float z = PlayerPrefs.GetFloat("z.FieldFifthTeen");
        int number = PlayerPrefs.GetInt("number.FieldFifthTeen");
        float timer = PlayerPrefs.GetFloat("timer.FieldFifthTeen");
        int valueBol = PlayerPrefs.GetInt("bool.FieldFifthTeen");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldFifthteen = timer,
            LocationFieldFifthteen = new Vector3(x, y, z),
            boolFieldFifthteen = valueBol,
            numberFieldFifthteen = number
        };
        return playerData;
    }

    public static void SaveDataFieldSixteen(playerFieldFifthTeen fieldOne)
    {

        PlayerPrefs.SetFloat("x.FieldSixteen", fieldOne.transform.position.x);
        PlayerPrefs.SetFloat("y.FieldSixteen", fieldOne.transform.position.y);
        PlayerPrefs.SetFloat("z.FieldSixteen", fieldOne.transform.position.z);
        PlayerPrefs.SetInt("number.FieldSixteen", fieldOne.number);
        PlayerPrefs.SetFloat("timer.FieldSixteen", fieldOne.timer);
        PlayerPrefs.SetInt("bool.FieldSixteen", fieldOne.valueForBool);
    }
    public static fieldsData LoadDataFieldSixteen()
    {
        float x = PlayerPrefs.GetFloat("x.FieldSixteen");
        float y = PlayerPrefs.GetFloat("y.FieldSixteen");
        float z = PlayerPrefs.GetFloat("z.FieldSixteen");
        int number = PlayerPrefs.GetInt("number.FieldSixteen");
        float timer = PlayerPrefs.GetFloat("timer.FieldSixteen");
        int valueBol = PlayerPrefs.GetInt("bool.FieldSixteen");

        fieldsData playerData = new fieldsData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerFieldFifthteen = timer,
            LocationFieldFifthteen = new Vector3(x, y, z),
            boolFieldFifthteen = valueBol,
            numberFieldFifthteen = number
        };
        return playerData;
    }
}
