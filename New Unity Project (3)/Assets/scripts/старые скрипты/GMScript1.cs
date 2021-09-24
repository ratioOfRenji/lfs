using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript1 : MonoBehaviour
{
    public Transform grassObject;
    public static float exp = 100;
    public static string currentTool = "none";
    public static int sunFlowerSeeds = 0;
    public static int potatoSeeds =0;
    public static int carrotSeeds = 0;
    public static int soySeeds = 0;
    public static int sugarPlantSeeds = 0;
    public static int coffeeSeeds = 0;
    public static int beansSeeds = 3;
    public static int yaytsa = 0;
    public static int wheatBread = 0;
    public static int whiteBreat = 0;
    public static int cowMilk = 0;
    public static int wool = 0;
    public static int nitki = 0;
    public static int fabric = 0;
    public static int goatMilk = 0;
    public static int goatCheese = 0;  
    public static int apple = 0; 
    public static int orange = 0;  
    public static int butter = 0;  
    public static int yogurt = 0;  
    public static int sugar = 0;  
    public static int coffee = 0;  
    public static int tomatoes = 0;  
    public static int axe = 0;  
    public static int chocholate = 0;  
    public static int raspberries = 0;  
    public static int milkIceCream = 0;  
    public static int chocholateIceCream =0;  
    public static int raspberryIceCream = 0;  
    public static int grape = 0;   
    public static int whiteGrape = 0;  
    public static int pinkGrape = 0;  
    public static int wine = 0;  
    public static int whiteWine = 0;  
    public static int pinkWine = 0;  
    public static int cherry = 0;  
    public static int appleJuice = 0;  
    public static int grapeJuice = 0;   
    public static int cherryJuice = 0;  
    public static int darkSpagetti = 0;  
    public static int spagetti = 0;  
    public static int coloredSpagetti = 0;  
    public static int cheeseSandwich = 0;  
    public static int tomatoSandwich = 0;  
    public static int orangeCake = 0;  
    public static bool kuritsuKupili = false; 
    public static bool boolSunflower1 = false;
    public static bool boolSunflower2 = false;
    public static bool boolCarrot1 = false;
    public static bool boolCarrot2 = false;
    public static bool boolPotato1 = false;
    public static bool boolPotato2 = false;
    public static bool boolWatered = false;
    public static bool twoBoolSunflower1 = false;
    public static bool twoBoolSunflower2 = false;
    public static bool twoBoolCarrot1 = false;
    public static bool twoBoolCarrot2 = false;
    public static bool twoBoolPotato1 = false;
    public static bool twoBoolPotato2 = false;
    public static bool twoBoolWatered = false;
    public static bool threeBoolSunflower1 = false;
    public static bool threeBoolSunflower2 = false;
    public static bool threeBoolCarrot1 = false;
    public static bool threeBoolCarrot2 = false;
    public static bool threeBoolPotato1 = false;
    public static bool threeBoolPotato2 = false;
    public static bool threeBoolWatered = false;
    public static bool fourBoolSunflower1 = false;
    public static bool fourBoolSunflower2 = false;
    public static bool fourBoolCarrot1 = false;
    public static bool fourBoolCarrot2 = false;
    public static bool fourBoolPotato1 = false;
    public static bool fourBoolPotato2 = false;
    public static bool fourBoolWatered = false;
    public static bool kuriatnic = false;
    public static bool kuritsa = false;
    public static bool kuritsuPokormili1 = false;
    public static bool kuritsuPokormili2 = false;
    public static bool ovtsuPokormili1 = false;
    public static bool ovtsuPokormili2 = false;
    public static bool kozuPokormili1 = false;
    public static bool kozuPokormili2 = false;
    public static bool korovuPokormili1 = false;
    public static bool korovuPokormili2 = false;
    public static bool pecarniaUiIsActive = false;
    public static bool bakeryPopUpIsActive = false;
    
    public static int money; 
    public static int griadka1 = 0;
    public static int griadka2 = 0;
    public static int griadka3 = 0;
    public static int griadka4 = 0;
    public static bool pecarnyaSlot1 = false;
    public static bool pecarnyaSlot2 = false;
    public static bool sewSlot1 = false;
    public static bool sewSlot2 = false;
    public static bool PopUpWoolIsActive;

    // Start is called before the first frame updatev
    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
    }
    void Start()
    {
       
    }
    private void OnEnable()
    {
        loadData();

    }
    private void OnDisable()
    {
        SaveData();
    }
    public void loadData()
    {
        exp = PlayerPrefs.GetFloat("exp");
        sunFlowerSeeds = PlayerPrefs.GetInt("wheat");
        potatoSeeds = PlayerPrefs.GetInt("potato");
        carrotSeeds = PlayerPrefs.GetInt("carrotSeeds");
        soySeeds = PlayerPrefs.GetInt("soySeeds");
        sugarPlantSeeds = PlayerPrefs.GetInt("sugarPlantSeeds");
        coffeeSeeds = PlayerPrefs.GetInt(" coffeeSeeds");
        yaytsa = PlayerPrefs.GetInt("yaytsa");
        wheatBread = PlayerPrefs.GetInt("wheatBread");
        whiteBreat = PlayerPrefs.GetInt("whiteBreat");
        cowMilk = PlayerPrefs.GetInt("cowMilk");
        wool = PlayerPrefs.GetInt("wool");
        fabric = PlayerPrefs.GetInt("fabric");
        goatMilk = PlayerPrefs.GetInt("goatMilk");
        goatCheese = PlayerPrefs.GetInt("goatCheese");
        apple = PlayerPrefs.GetInt("apple");
        orange = PlayerPrefs.GetInt("orange");
        butter = PlayerPrefs.GetInt("butter");
        yogurt = PlayerPrefs.GetInt("yogurt");
        sugar = PlayerPrefs.GetInt("sugar");
        coffee = PlayerPrefs.GetInt("coffee");
        tomatoes = PlayerPrefs.GetInt("tomatoes");
        raspberries = PlayerPrefs.GetInt("raspberries");
        milkIceCream = PlayerPrefs.GetInt("milkIceCream");
        chocholateIceCream = PlayerPrefs.GetInt("chocholateIceCream");
        raspberryIceCream = PlayerPrefs.GetInt("raspberryIceCream ");
        grape = PlayerPrefs.GetInt("grape");
        whiteGrape = PlayerPrefs.GetInt("whiteGrape");
        wine = PlayerPrefs.GetInt("wine");
        whiteWine = PlayerPrefs.GetInt("whiteWine");
        pinkWine = PlayerPrefs.GetInt("pinkWine");
        cherry = PlayerPrefs.GetInt("cherry");
        appleJuice = PlayerPrefs.GetInt("appleJuice");
        grapeJuice = PlayerPrefs.GetInt("grapeJuice");
        cherryJuice = PlayerPrefs.GetInt("cherryJuice");
        darkSpagetti = PlayerPrefs.GetInt("darkSpagetti");
        spagetti = PlayerPrefs.GetInt("spagetti");
        coloredSpagetti = PlayerPrefs.GetInt("coloredSpagetti");
        cheeseSandwich = PlayerPrefs.GetInt("cheeseSandwich");
        tomatoSandwich = PlayerPrefs.GetInt("tomatoSandwich");
        orangeCake = PlayerPrefs.GetInt("orangeCake");
        money = PlayerPrefs.GetInt("money");
        if (money < 30)
        {
            money = 30;
        }
        if(exp < 100)
        {
            exp = 100;
        }
        
    }
   public void SaveData()
    {
        PlayerPrefs.SetFloat("exp", exp);
        PlayerPrefs.SetInt("wheat", sunFlowerSeeds);
        PlayerPrefs.SetInt("potato", potatoSeeds);
        PlayerPrefs.SetInt("carrotSeeds", carrotSeeds);
        PlayerPrefs.SetInt("soySeeds", soySeeds);
        PlayerPrefs.SetInt("sugarPlantSeeds", sugarPlantSeeds);
        PlayerPrefs.SetInt("coffeeSeeds", coffeeSeeds);
        PlayerPrefs.SetInt("yaytsa", yaytsa);
        PlayerPrefs.SetInt("wheatBread", wheatBread);
        PlayerPrefs.SetInt("whiteBreat", whiteBreat);
        PlayerPrefs.SetInt("cowMilk", cowMilk);
        PlayerPrefs.SetInt("wool", wool);
        PlayerPrefs.SetInt("fabric", fabric);
        PlayerPrefs.SetInt("goatMilk", goatMilk);
        PlayerPrefs.SetInt("goatCheese", goatCheese);
        PlayerPrefs.SetInt("apple", apple);
        PlayerPrefs.SetInt("orange", orange);
        PlayerPrefs.SetInt("butter", butter);
        PlayerPrefs.SetInt("yogurt", yogurt);
        PlayerPrefs.SetInt("sugar", sugar);
        PlayerPrefs.SetInt("coffee", coffee);
        PlayerPrefs.SetInt("raspberries", raspberries);
        PlayerPrefs.SetInt("milkIceCream", milkIceCream);
        PlayerPrefs.SetInt("chocholateIceCream", chocholateIceCream);
        PlayerPrefs.SetInt("raspberryIceCream", raspberryIceCream);
        PlayerPrefs.SetInt("grape", grape);
        PlayerPrefs.SetInt("whiteGrape", whiteGrape);
        PlayerPrefs.SetInt("wine", wine);
        PlayerPrefs.SetInt(" whiteWine", whiteWine);
        PlayerPrefs.SetInt("pinkWine", pinkWine);
        PlayerPrefs.SetInt("cherry", cherry);
        PlayerPrefs.SetInt("appleJuice", appleJuice);
        PlayerPrefs.SetInt("grapeJuice", grapeJuice);
        PlayerPrefs.SetInt("cherryJuice", cherryJuice);
        PlayerPrefs.SetInt("darkSpagetti", darkSpagetti);
        PlayerPrefs.SetInt("spagetti", spagetti);
        PlayerPrefs.SetInt("coloredSpagetti", coloredSpagetti);
        PlayerPrefs.SetInt("cheeseSandwich", cheeseSandwich);
        PlayerPrefs.SetInt("tomatoSandwich", tomatoSandwich);
        PlayerPrefs.SetInt("orangeCake", orangeCake);
        PlayerPrefs.SetInt("money", money);
        
    }

    //private void Update()
    //{
    //    Debug.Log(GMScript1.milkIceCream + " " + GMScript1.chocholateIceCream + "  " + GMScript1.raspberryIceCream+ "  " + GMScript1.darkSpagetti + "  сюда");
    //}
}
