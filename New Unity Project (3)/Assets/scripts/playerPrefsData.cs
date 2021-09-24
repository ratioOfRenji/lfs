using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefsData : MonoBehaviour

{
    private void Awake()
    {
       // PlayerPrefs.DeleteAll();
    }
    public static void SaveData(playerScr player)
    {
        PlayerPrefs.SetFloat("x", player.transform.position.x);
        PlayerPrefs.SetFloat("y", player.transform.position.y);
        PlayerPrefs.SetFloat("z", player.transform.position.z);
        
        PlayerPrefs.SetInt("slArZero", player.slArZero);
        PlayerPrefs.SetInt("slArOne", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer", player.OneTimer);
    }
    public static PlayerData LoadData()
    {
        float x = PlayerPrefs.GetFloat("x");
        float y = PlayerPrefs.GetFloat("y");
        float z = PlayerPrefs.GetFloat("z");
        int slArZero = PlayerPrefs.GetInt("slArZero");
        int slArOne = PlayerPrefs.GetInt("slArOne");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer");
        int valueBol = PlayerPrefs.GetInt("valueForBool");
        PlayerData playerData = new PlayerData()
        { 
            oneTimer = oneTimer,
            Location = new Vector3(x, y, z),
            slotArray = new int[2] { slArZero, slArOne },
            imSlotArray = new int[2] {imSlArZero, imSlArOne},
            valueForBoolMilkFacory = valueBol


        };
        return playerData;
    }

    public static void SaveDataSpagetti(playerSpagetti player)
    {
        PlayerPrefs.SetFloat("x.Spagetti", player.transform.position.x);
        PlayerPrefs.SetFloat("y.Spagetti", player.transform.position.y);
        PlayerPrefs.SetFloat("z.Spagetti", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.Spagetti", player.slArZero);
        PlayerPrefs.SetInt("slArOne.Spagetti", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.Spagetti", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.Spagetti", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.Spagetti", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.Spagetti", player.OneTimer);
    }
    public static PlayerData LoadDataSpagetti()
    {
        float x = PlayerPrefs.GetFloat("x.Spagetti");
        float y = PlayerPrefs.GetFloat("y.Spagetti");
        float z = PlayerPrefs.GetFloat("z.Spagetti");
        int slArZero = PlayerPrefs.GetInt("slArZero.Spagetti");
        int slArOne = PlayerPrefs.GetInt("slArOne.Spagetti");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.Spagetti");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.Spagetti");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Spagetti");

        PlayerData playerData = new PlayerData()
        {
            oneTimerSpagetti = oneTimer,
            LocationSpagetti = new Vector3(x, y, z),
            slotArraySpagetti = new int[2] { slArZero, slArOne },
            imSlotArraySpagetti = new int[2] { imSlArZero, imSlArOne }


        };
        return playerData;
    }

    public static void SaveDataIceCream(playerIceCream player)
    {
        PlayerPrefs.SetFloat("x.IceCream", player.transform.position.x);
        PlayerPrefs.SetFloat("y.IceCream", player.transform.position.y);
        PlayerPrefs.SetFloat("z.IceCream", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.IceCream", player.slArZero);
        PlayerPrefs.SetInt("slArOne.IceCream", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.IceCream", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.IceCream", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.IceCream", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.IceCream", player.OneTimer);
    }
    public static PlayerData LoadDataIceCream()
    {
        float x = PlayerPrefs.GetFloat("x.IceCream");
        float y = PlayerPrefs.GetFloat("y.IceCream");
        float z = PlayerPrefs.GetFloat("z.IceCream");
        int slArZero = PlayerPrefs.GetInt("slArZero.IceCream");
        int slArOne = PlayerPrefs.GetInt("slArOne.IceCream");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.IceCream");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.IceCream");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.IceCream");
        int valueForBol = PlayerPrefs.GetInt("valueForBool.IceCream");
        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerIceCream = oneTimer,
            LocationIceCream = new Vector3(x, y, z),
            slotArrayIceCream = new int[2] { slArZero, slArOne },
            imSlotArrayIceCream = new int[2] { imSlArZero, imSlArOne },
            valueForBoolIceCream = valueForBol

        };
        return playerData;
    }

    public static void SaveDataWineFactory(playerWineFactory player)
    {
        PlayerPrefs.SetFloat("x.WineFactory", player.transform.position.x);
        PlayerPrefs.SetFloat("y.WineFactory", player.transform.position.y);
        PlayerPrefs.SetFloat("z.WineFactory", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.WineFactory", player.slArZero);
        PlayerPrefs.SetInt("slArOne.WineFactory", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.WineFactory", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.WineFactory", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.WineFactory", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.WineFactory", player.OneTimer);
    }
    public static PlayerData LoadDataWineFactory()
    {
        float x = PlayerPrefs.GetFloat("x.WineFactory");
        float y = PlayerPrefs.GetFloat("y.WineFactory");
        float z = PlayerPrefs.GetFloat("z.WineFactory");
        int slArZero = PlayerPrefs.GetInt("slArZero.WineFactory");
        int slArOne = PlayerPrefs.GetInt("slArOne.WineFactory");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.WineFactory");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.WineFactory");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.WineFactory");
        int valueForBol = PlayerPrefs.GetInt("valueForBool.WineFactory");
        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerWineFactory = oneTimer,
            LocationWineFactory = new Vector3(x, y, z),
            slotArrayWineFactory = new int[2] { slArZero, slArOne },
            imSlotArrayWineFactory = new int[2] { imSlArZero, imSlArOne },
            valueForBoolWineFactory = valueForBol


        };
        return playerData;
    }

    public static void SaveDataGrill(playerGrill player)
    {
        PlayerPrefs.SetFloat("x.grill", player.transform.position.x);
        PlayerPrefs.SetFloat("y.grill", player.transform.position.y);
        PlayerPrefs.SetFloat("z.grill", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.grill", player.slArZero);
        PlayerPrefs.SetInt("slArOne.grill", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.grill", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.grill", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.grill", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.grill", player.OneTimer);
    }
    public static PlayerData LoadDataGrill()
    {
        float x = PlayerPrefs.GetFloat("x.grill");
        float y = PlayerPrefs.GetFloat("y.grill");
        float z = PlayerPrefs.GetFloat("z.grill");
        int slArZero = PlayerPrefs.GetInt("slArZero.grill");
        int slArOne = PlayerPrefs.GetInt("slArOne.grill");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.grill");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.grill");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.grill");
        int valueBool = PlayerPrefs.GetInt("valueForBool.grill");

        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerGrill = oneTimer,
            LocationGrill = new Vector3(x, y, z),
            slotArrayGrill = new int[2] { slArZero, slArOne },
            imSlotArrayGrill = new int[2] { imSlArZero, imSlArOne },
            valueForBoolGrill = valueBool

        };
        return playerData;
    }

    public static void SaveDataShreder(playerShreder player)
    {
        PlayerPrefs.SetFloat("x.shreder", player.transform.position.x);
        PlayerPrefs.SetFloat("y.shreder", player.transform.position.y);
        PlayerPrefs.SetFloat("z.shreder", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.shreder", player.slArZero);
        PlayerPrefs.SetInt("slArOne.shreder", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.shreder", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.shreder", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.shreder", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.shreder", player.OneTimer);
    }
    public static PlayerData LoadDataShreder()
    {
        float x = PlayerPrefs.GetFloat("x.shreder");
        float y = PlayerPrefs.GetFloat("y.shreder");
        float z = PlayerPrefs.GetFloat("z.shreder");
        int slArZero = PlayerPrefs.GetInt("slArZero.shreder");
        int slArOne = PlayerPrefs.GetInt("slArOne.shreder");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.shreder");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.shreder");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.shreder");
        int valueBool = PlayerPrefs.GetInt("valueForBool.shreder");

        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerShreder = oneTimer,
            LocationShreder = new Vector3(x, y, z),
            slotArrayShreder = new int[2] { slArZero, slArOne },
            imSlotArrayShreder = new int[2] { imSlArZero, imSlArOne },
            valueForBoolShreder = valueBool

        };
        return playerData;
    }

    public static void SaveDataSquizzer(playerSquizzer player)
    {
        PlayerPrefs.SetFloat("x.squizzer", player.transform.position.x);
        PlayerPrefs.SetFloat("y.squizzer", player.transform.position.y);
        PlayerPrefs.SetFloat("z.squizzer", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.squizzer", player.slArZero);
        PlayerPrefs.SetInt("slArOne.squizzer", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.squizzer", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.squizzer", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.squizzer", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.squizzer", player.OneTimer);
    }
    public static PlayerData LoadDataSquizzer()
    {
        float x = PlayerPrefs.GetFloat("x.squizzer");
        float y = PlayerPrefs.GetFloat("y.squizzer");
        float z = PlayerPrefs.GetFloat("z.squizzer");
        int slArZero = PlayerPrefs.GetInt("slArZero.squizzer");
        int slArOne = PlayerPrefs.GetInt("slArOne.squizzer");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.squizzer");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.squizzer");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.squizzer");
        int valueBool = PlayerPrefs.GetInt("valueForBool.squizzer");

        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerSquizzer = oneTimer,
            LocationSquizzer = new Vector3(x, y, z),
            slotArraySquizzer = new int[2] { slArZero, slArOne },
            imSlotArraySquizzer = new int[2] { imSlArZero, imSlArOne },
            valueForBoolSquizzer = valueBool

        };
        return playerData;
    }

    public static void SaveDataBakery(playerBakery player)
    {
        PlayerPrefs.SetFloat("x.Bakery", player.transform.position.x);
        PlayerPrefs.SetFloat("y.Bakery", player.transform.position.y);
        PlayerPrefs.SetFloat("z.Bakery", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.Bakery", player.slArZero);
        PlayerPrefs.SetInt("slArOne.Bakery", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.Bakery", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.Bakery", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.Bakery", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.Bakery", player.OneTimer);
    }
    public static PlayerData LoadDataBakery()
    {
        float x = PlayerPrefs.GetFloat("x.Bakery");
        float y = PlayerPrefs.GetFloat("y.Bakery");
        float z = PlayerPrefs.GetFloat("z.Bakery");
        int slArZero = PlayerPrefs.GetInt("slArZero.Bakery");
        int slArOne = PlayerPrefs.GetInt("slArOne.Bakery");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.Bakery");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.Bakery");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.Bakery");
        int valueBool = PlayerPrefs.GetInt("valueForBool.Bakery");

        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerBakery = oneTimer,
            LocationBakery = new Vector3(x, y, z),
            slotArrayBakery = new int[2] { slArZero, slArOne },
            imSlotArrayBakery = new int[2] { imSlArZero, imSlArOne },
            valueForBoolBakery = valueBool

        };
        return playerData;
    }
    public static void SaveDataWoolFactory(playerWoolFactory player)
    {
        PlayerPrefs.SetFloat("x.WoolFactory", player.transform.position.x);
        PlayerPrefs.SetFloat("y.WoolFactory", player.transform.position.y);
        PlayerPrefs.SetFloat("z.WoolFactory", player.transform.position.z);

        PlayerPrefs.SetInt("slArZero.WoolFactory", player.slArZero);
        PlayerPrefs.SetInt("slArOne.WoolFactory", player.slArOne);
        PlayerPrefs.SetInt("imSlArZero.WoolFactory", player.imSlArZero);
        PlayerPrefs.SetInt("imSlArOne.WoolFactory", player.imSlArOne);
        PlayerPrefs.SetInt("valueForBool.WoolFactory", player.valueForBool);
        PlayerPrefs.SetFloat("OneTimer.WoolFactory", player.OneTimer);
    }
    public static PlayerData LoadDataWoolFactory()
    {
        float x = PlayerPrefs.GetFloat("x.WoolFactory");
        float y = PlayerPrefs.GetFloat("y.WoolFactory");
        float z = PlayerPrefs.GetFloat("z.WoolFactory");
        int slArZero = PlayerPrefs.GetInt("slArZero.WoolFactory");
        int slArOne = PlayerPrefs.GetInt("slArOne.WoolFactory");
        int imSlArZero = PlayerPrefs.GetInt("imSlArZero.WoolFactory");
        int imSlArOne = PlayerPrefs.GetInt("imSlArOne.WoolFactory");
        float oneTimer = PlayerPrefs.GetFloat("OneTimer.WoolFactory");
        int valueBool = PlayerPrefs.GetInt("valueForBool.WoolFactory");

        PlayerData playerData = new PlayerData()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //долбаеб
            oneTimerWoolFactory = oneTimer,
            LocationWoolFactory = new Vector3(x, y, z),
            slotArrayWoolFactory = new int[2] { slArZero, slArOne },
            imSlotArrayWoolFactory = new int[2] { imSlArZero, imSlArOne },
            valueForBoolWoolFactory = valueBool

        };
        return playerData;
    }
}

public class PlayerData
{
    public Vector3 Location { get; set; }
    public int [] slotArray { get; set; } 
    public int[] imSlotArray { get; set; }
    public float oneTimer;
    public int valueForBoolMilkFacory;

    public Vector3 LocationSpagetti { get; set; }
    public int[] slotArraySpagetti { get; set; }
    public int[] imSlotArraySpagetti { get; set; }
    public float oneTimerSpagetti;
    public int valueForBoolSpagetti;

    public Vector3 LocationIceCream { get; set; }
    public int[] slotArrayIceCream { get; set; }
    public int[] imSlotArrayIceCream { get; set; }
    public float oneTimerIceCream;
    public int valueForBoolIceCream;

    public Vector3 LocationWineFactory { get; set; }
    public int[] slotArrayWineFactory { get; set; }
    public int[] imSlotArrayWineFactory { get; set; }
    public float oneTimerWineFactory;
    public int valueForBoolWineFactory;

    public Vector3 LocationGrill { get; set; }
    public int[] slotArrayGrill { get; set; }
    public int[] imSlotArrayGrill { get; set; }
    public float oneTimerGrill;
    public int valueForBoolGrill;

    public Vector3 LocationShreder { get; set; }
    public int[] slotArrayShreder { get; set; }
    public int[] imSlotArrayShreder { get; set; }
    public float oneTimerShreder;
    public int valueForBoolShreder;

    public Vector3 LocationSquizzer { get; set; }
    public int[] slotArraySquizzer { get; set; }
    public int[] imSlotArraySquizzer { get; set; }
    public float oneTimerSquizzer;
    public int valueForBoolSquizzer;

    public Vector3 LocationBakery { get; set; }
    public int[] slotArrayBakery { get; set; }
    public int[] imSlotArrayBakery { get; set; }
    public float oneTimerBakery;
    public int valueForBoolBakery;

    public Vector3 LocationWoolFactory { get; set; }
    public int[] slotArrayWoolFactory { get; set; }
    public int[] imSlotArrayWoolFactory { get; set; }
    public float oneTimerWoolFactory;
    public int valueForBoolWoolFactory;
}