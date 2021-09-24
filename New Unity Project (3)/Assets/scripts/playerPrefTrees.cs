using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefTrees : MonoBehaviour
{
    private void Awake()
    {
       //PlayerPrefs.DeleteAll();
    }
    public static void SaveData(raspberryOneData raspberryOne)
    {
        PlayerPrefs.SetFloat("x.rasp1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.rasp1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.rasp1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.rasp1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.rasp1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.rasp1", raspberryOne.timer);


        
    }
   
    public static dataForTrees LoadData()
    {
        float x = PlayerPrefs.GetFloat("x.rasp1");
        float y = PlayerPrefs.GetFloat("y.rasp1");
        float z = PlayerPrefs.GetFloat("z.rasp1");
        int imageValue = PlayerPrefs.GetInt("imageValue.rasp1");
        float oneTimer = PlayerPrefs.GetFloat("timer.rasp1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.rasp1");

        dataForTrees playerData = new dataForTrees()
        {
            timerRaspberryOne = oneTimer,
            Location = new Vector3(x, y, z),
            boolRaspberryOne = valueForBool,
            spritesRaspberryOne = imageValue
        };
        return playerData;
    }

 public static void SaveDataRaspTwo(raspberryTwoData raspberryOne)
    { 

        PlayerPrefs.SetFloat("x.rasp2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.rasp2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.rasp2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.rasp2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.rasp2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.rasp2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataRaspTwo()
    {
        float x = PlayerPrefs.GetFloat("x.rasp2");
        float y = PlayerPrefs.GetFloat("y.rasp2");
        float z = PlayerPrefs.GetFloat("z.rasp2");
        int imageValue = PlayerPrefs.GetInt("imageValue.rasp2");
        float oneTimer = PlayerPrefs.GetFloat("timer.rasp2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.rasp2");

        dataForTrees playerData = new dataForTrees()
        {
            timerRaspberryTwo = oneTimer,
            LocationSecondRaspberry = new Vector3(x, y, z),
            boolRaspberryTwo = valueForBool,
            spritesRaspberryTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataRaspThree(raspberryThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.rasp3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.rasp3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.rasp3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.rasp3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.rasp3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.rasp3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataRaspThree()
    {
        float x = PlayerPrefs.GetFloat("x.rasp3");
        float y = PlayerPrefs.GetFloat("y.rasp3");
        float z = PlayerPrefs.GetFloat("z.rasp3");
        int imageValue = PlayerPrefs.GetInt("imageValue.rasp3");
        float oneTimer = PlayerPrefs.GetFloat("timer.rasp3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.rasp3");

        dataForTrees playerData = new dataForTrees()
        {
            timerRaspberryThree= oneTimer,
            LocationThirdRaspberry = new Vector3(x, y, z),
            boolRaspberryThree = valueForBool,
            spritesRaspberryThree = imageValue
        };
        return playerData;
    }

    public static void SaveDataAppleOne(appleOneData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.apple1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.apple1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.apple1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.apple1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.apple1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.apple1", raspberryOne._timer);
    }
    public static dataForTrees LoadDataAppleOne()
    {
        float x = PlayerPrefs.GetFloat("x.apple1");
        float y = PlayerPrefs.GetFloat("y.apple1");
        float z = PlayerPrefs.GetFloat("z.apple1");
        int imageValue = PlayerPrefs.GetInt("imageValue.apple1");
        float oneTimer = PlayerPrefs.GetFloat("timer.apple1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.apple1");

        dataForTrees playerData = new dataForTrees()
        {
            timerAppleOne = oneTimer,
            LocationFirstApple = new Vector3(x, y, z),
            boolAppleOne = valueForBool,
            spritesAppleOne = imageValue
        };
        return playerData;
    }

    
    

    public static void SaveDataAppleTwo(appleTwoData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.apple2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.apple2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.apple2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.apple2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.apple2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.apple2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataAppleTwo()
    {
        float x = PlayerPrefs.GetFloat("x.apple2");
        float y = PlayerPrefs.GetFloat("y.apple2");
        float z = PlayerPrefs.GetFloat("z.apple2");
        int imageValue = PlayerPrefs.GetInt("imageValue.apple2");
        float oneTimer = PlayerPrefs.GetFloat("timer.apple2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.apple2");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerAppleTwo = oneTimer,
            LocationSecondtApple = new Vector3(x, y, z),
            boolAppleTwo = valueForBool,
            spritesAppleTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataAppleThree(appleThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.apple3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.apple3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.apple3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.apple3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.apple3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.apple3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataAppleThree()
    {
        float x = PlayerPrefs.GetFloat("x.apple3");
        float y = PlayerPrefs.GetFloat("y.apple3");
        float z = PlayerPrefs.GetFloat("z.apple3");
        int imageValue = PlayerPrefs.GetInt("imageValue.apple3");
        float oneTimer = PlayerPrefs.GetFloat("timer.apple3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.apple3");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerAppleThree = oneTimer,
            LocationThirdApple = new Vector3(x, y, z),
            boolAppleThree = valueForBool,
            spritesAppleThree = imageValue
        };
        return playerData;
    }

    public static void SaveDataCoffeeOne(cofffeeOneData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.coffee1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.coffee1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.coffee1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.coffee1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.coffee1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.coffee1", raspberryOne.timer);
    }
    public static dataForTrees LoadDataCoffeeOne()
    {
        float x = PlayerPrefs.GetFloat("x.coffee1");
        float y = PlayerPrefs.GetFloat("y.coffee1");
        float z = PlayerPrefs.GetFloat("z.coffee1");
        int imageValue = PlayerPrefs.GetInt("imageValue.coffee1");
        float oneTimer = PlayerPrefs.GetFloat("timer.coffee1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.coffee1");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerCoffeeOne = oneTimer,
            LocationFirstCoffee = new Vector3(x, y, z),
            boolCoffeeOne = valueForBool,
            spritesCoffeeOne = imageValue
        };
        return playerData;
    }




    public static void SaveDataCoffeeTwo(coffeeTwoData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.coffee2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.coffee2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.coffee2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.coffee2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.coffee2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.coffee2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataCoffeeTwo()
    {
        float x = PlayerPrefs.GetFloat("x.coffee2");
        float y = PlayerPrefs.GetFloat("y.coffee2");
        float z = PlayerPrefs.GetFloat("z.coffee2");
        int imageValue = PlayerPrefs.GetInt("imageValue.coffee2");
        float oneTimer = PlayerPrefs.GetFloat("timer.coffee2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.coffee2");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerCoffeeTwo = oneTimer,
            LocationSecondCoffee = new Vector3(x, y, z),
            boolCoffeeTwo = valueForBool,
            spritesCoffeeTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataCoffeeThree(coffeeThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.coffee3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.coffee3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.coffee3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.coffee3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.coffee3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.coffee3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataCoffeeThree()
    {
        float x = PlayerPrefs.GetFloat("x.coffee3");
        float y = PlayerPrefs.GetFloat("y.coffee3");
        float z = PlayerPrefs.GetFloat("z.coffee3");
        int imageValue = PlayerPrefs.GetInt("imageValue.coffee3");
        float oneTimer = PlayerPrefs.GetFloat("timer.coffee3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.coffee3");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerCoffeeThree = oneTimer,
            LocationThirdCoffee = new Vector3(x, y, z),
            boolCoffeeThree = valueForBool,
            spritesCoffeeThree = imageValue
        };
        return playerData;
    }

    public static void SaveDataOrangeOne(orangeOneData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.orange1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.orange1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.orange1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.orange1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.orange1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.orange1", raspberryOne.timer);
    }
    public static dataForTrees LoadDataOrangeOne()
    {
        float x = PlayerPrefs.GetFloat("x.orange1");
        float y = PlayerPrefs.GetFloat("y.orange1");
        float z = PlayerPrefs.GetFloat("z.orange1");
        int imageValue = PlayerPrefs.GetInt("imageValue.orange1");
        float oneTimer = PlayerPrefs.GetFloat("timer.orange1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.orange1");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerOrangeOne = oneTimer,
            LocationFirstOrange = new Vector3(x, y, z),
            boolOrangeOne = valueForBool,
            spritesOrangeOne = imageValue
        };
        return playerData;
    }




    public static void SaveDataOrangeTwo(orangeTwoData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.orange2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.orange2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.orange2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.orange2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.orange2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.orange2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataOrangeTwo()
    {
        float x = PlayerPrefs.GetFloat("x.orange2");
        float y = PlayerPrefs.GetFloat("y.orange2");
        float z = PlayerPrefs.GetFloat("z.orange2");
        int imageValue = PlayerPrefs.GetInt("imageValue.orange2");
        float oneTimer = PlayerPrefs.GetFloat("timer.orange2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.orange2");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerOrangeTwo = oneTimer,
            LocationSecondOrange = new Vector3(x, y, z),
            boolOrangeTwo = valueForBool,
            spritesOrangeTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataOrangeThree(orangeThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.orange3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.orange3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.orange3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.orange3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.orange3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.orange3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataOrangeThree()
    {
        float x = PlayerPrefs.GetFloat("x.orange3");
        float y = PlayerPrefs.GetFloat("y.orange3");
        float z = PlayerPrefs.GetFloat("z.orange3");
        int imageValue = PlayerPrefs.GetInt("imageValue.orange3");
        float oneTimer = PlayerPrefs.GetFloat("timer.orange3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.orange3");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerOrangeThree = oneTimer,
            LocationThirdOrange = new Vector3(x, y, z),
            boolOrangeThree = valueForBool,
            spritesOrangeThree = imageValue
        };
        return playerData;
    }

    public static void SaveDataCherryOne(cherryOneData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.cherry1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.cherry1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.cherry1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.cherry1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.cherry1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.cherry1", raspberryOne.timer);
    }
    public static dataForTrees LoadDataCherryOne()
    {
        float x = PlayerPrefs.GetFloat("x.cherry1");
        float y = PlayerPrefs.GetFloat("y.cherry1");
        float z = PlayerPrefs.GetFloat("z.cherry1");
        int imageValue = PlayerPrefs.GetInt("imageValue.cherry1");
        float oneTimer = PlayerPrefs.GetFloat("timer.cherry1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.cherry1");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerCherryOne = oneTimer,
            LocationFirstCherry = new Vector3(x, y, z),
            boolCherryOne = valueForBool,
            spritesCherryOne = imageValue
        };
        return playerData;
    }




    public static void SaveDataCherryTwo(cherryTwoData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.cherry2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.cherry2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.cherry2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.cherry2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.cherry2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.cherry2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataCherryTwo()
    {
        float x = PlayerPrefs.GetFloat("x.cherry2");
        float y = PlayerPrefs.GetFloat("y.cherry2");
        float z = PlayerPrefs.GetFloat("z.cherry2");
        int imageValue = PlayerPrefs.GetInt("imageValue.cherry2");
        float oneTimer = PlayerPrefs.GetFloat("timer.cherry2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.cherry2");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerCherryTwo = oneTimer,
            LocationSecondCherry = new Vector3(x, y, z),
            boolCherryTwo = valueForBool,
            spritesCherryTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataCherryThree(cherryThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.cherry3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.cherry3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.cherry3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.cherry3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.cherry3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.cherry3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataCherryThree()
    {
        float x = PlayerPrefs.GetFloat("x.cherry3");
        float y = PlayerPrefs.GetFloat("y.cherry3");
        float z = PlayerPrefs.GetFloat("z.cherry3");
        int imageValue = PlayerPrefs.GetInt("imageValue.cherry3");
        float oneTimer = PlayerPrefs.GetFloat("timer.cherry3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.cherry3");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerCherryThree = oneTimer,
            LocationThirdCherry = new Vector3(x, y, z),
            boolCherryThree = valueForBool,
            spritesCherryThree = imageValue
        };
        return playerData;
    }

    public static void SaveDataGrapeOne(grapeOneData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.grape1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.grape1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.grape1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.grape1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.grape1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.grape1", raspberryOne.timer);
    }
    public static dataForTrees LoadDataGrapeOne()
    {
        float x = PlayerPrefs.GetFloat("x.grape1");
        float y = PlayerPrefs.GetFloat("y.grape1");
        float z = PlayerPrefs.GetFloat("z.grape1");
        int imageValue = PlayerPrefs.GetInt("imageValue.grape1");
        float oneTimer = PlayerPrefs.GetFloat("timer.grape1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.grape1");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerGrapeOne = oneTimer,
            LocationFirstGrape = new Vector3(x, y, z),
            boolGrapeOne = valueForBool,
            spritesGrapeOne = imageValue
        };
        return playerData;
    }




    public static void SaveDataGrapeTwo(grapeTwoData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.grape2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.grape2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.grape2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.grape2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.grape2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.grape2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataGrapeTwo()
    {
        float x = PlayerPrefs.GetFloat("x.grape2");
        float y = PlayerPrefs.GetFloat("y.grape2");
        float z = PlayerPrefs.GetFloat("z.grape2");
        int imageValue = PlayerPrefs.GetInt("imageValue.grape2");
        float oneTimer = PlayerPrefs.GetFloat("timer.grape2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.grape2");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerGrapeTwo = oneTimer,
            LocationSecondGrape = new Vector3(x, y, z),
            boolGrapeTwo = valueForBool,
            spritesGrapeTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataGrapeThree(grapeThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.grape3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.grape3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.grape3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.grape3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.grape3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.grape3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataGrapeThree()
    {
        float x = PlayerPrefs.GetFloat("x.grape3");
        float y = PlayerPrefs.GetFloat("y.grape3");
        float z = PlayerPrefs.GetFloat("z.grape3");
        int imageValue = PlayerPrefs.GetInt("imageValue.grape3");
        float oneTimer = PlayerPrefs.GetFloat("timer.grape3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.grape3");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerGrapeThree = oneTimer,
            LocationThirdGrape = new Vector3(x, y, z),
            boolGrapeThree = valueForBool,
            spritesGrapeThree = imageValue
        };
        return playerData;
    }

    public static void SaveDataDarkGrapeOne(darkGrapeOneData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.darkGrape1", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.darkGrape1", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.darkGrape1", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.darkGrape1", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.darkGrape1", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.darkGrape1", raspberryOne.timer);
    }
    public static dataForTrees LoadDataDarkGrapeOne()
    {
        float x = PlayerPrefs.GetFloat("x.darkGrape1");
        float y = PlayerPrefs.GetFloat("y.darkGrape1");
        float z = PlayerPrefs.GetFloat("z.darkGrape1");
        int imageValue = PlayerPrefs.GetInt("imageValue.darkGrape1");
        float oneTimer = PlayerPrefs.GetFloat("timer.darkGrape1");
        int valueForBool = PlayerPrefs.GetInt("boolValue.darkGrape1");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerDarkGrapeOne = oneTimer,
            LocationFirstDarkGrape = new Vector3(x, y, z),
            boolDarkGrapeOne = valueForBool,
            spritesDarkGrapeOne = imageValue
        };
        return playerData;
    }




    public static void SaveDataDarkGrapeTwo(darkGrapeTwoData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.darkGrape2", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.darkGrape2", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.darkGrape2", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.darkGrape2", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.darkGrape2", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.darkGrape2", raspberryOne.timer);
    }
    public static dataForTrees LoadDataDarkGrapeTwo()
    {
        float x = PlayerPrefs.GetFloat("x.darkGrape2");
        float y = PlayerPrefs.GetFloat("y.darkGrape2");
        float z = PlayerPrefs.GetFloat("z.darkGrape2");
        int imageValue = PlayerPrefs.GetInt("imageValue.darkGrape2");
        float oneTimer = PlayerPrefs.GetFloat("timer.darkGrape2");
        int valueForBool = PlayerPrefs.GetInt("boolValue.darkGrape2");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerDarkGrapeTwo = oneTimer,
            LocationSecondDarkGrape = new Vector3(x, y, z),
            boolDarkGrapeTwo = valueForBool,
            spritesDarkGrapeTwo = imageValue
        };
        return playerData;
    }

    public static void SaveDataDarkGrapeThree(darkGrapeThreeData raspberryOne)
    {

        PlayerPrefs.SetFloat("x.darkGrape3", raspberryOne.transform.position.x);
        PlayerPrefs.SetFloat("y.darkGrape3", raspberryOne.transform.position.y);
        PlayerPrefs.SetFloat("z.darkGrape3", raspberryOne.transform.position.z);
        PlayerPrefs.SetInt("imageValue.darkGrape3", raspberryOne.valueForImages);
        PlayerPrefs.SetInt("boolValue.darkGrape3", raspberryOne.valueForBool);
        PlayerPrefs.SetFloat("timer.darkGrape3", raspberryOne.timer);
    }
    public static dataForTrees LoadDataDarkGrapeThree()
    {
        float x = PlayerPrefs.GetFloat("x.darkGrape3");
        float y = PlayerPrefs.GetFloat("y.darkGrape3");
        float z = PlayerPrefs.GetFloat("z.darkGrape3");
        int imageValue = PlayerPrefs.GetInt("imageValue.darkGrape3");
        float oneTimer = PlayerPrefs.GetFloat("timer.darkGrape3");
        int valueForBool = PlayerPrefs.GetInt("boolValue.darkGrape3");

        dataForTrees playerData = new dataForTrees()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            timerDarkGrapeThree = oneTimer,
            LocationThirdDarkGrape = new Vector3(x, y, z),
            boolDarkGrapeThree = valueForBool,
            spritesDarkGrapeThree = imageValue
        };
        return playerData;
    }
}
