using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tasksSystem2 : MonoBehaviour
{
    public static int[,] myArray = new int[5,4];
    public Text ammountOfGoods;
    public Text ammontRevwnue;
    public Text ammontExp;
    public Image[] slotsImageArray;
    public Text[] ammountOfGoodsArray;
    public Text[] ammountOfRevenueArray;
    public Text[] ammountOfexpArray;


    public Image image;
    public Sprite[] spties;
    int[] speciesLvlOne = new int[] { 3 };
    int[] speciesLvlTwo = new int[] { 3, 4 };
    int[] speciesLvlThree = new int[] { 3, 4, 5 };
    int[] speciesLvlFour= new int[] { 3, 4, 5,  6 }; 
    int[] speciesLvlFive= new int[] { 3, 4, 5,  6, 8 };
    int[] speciesLvlSix = new int[] { 3, 4, 5,6, 8, 10 };
    int[] speciesLvlSeven = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11 };
    int[] speciesLvlEight = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11,13, 14, 15, 16 };
    int[] speciesLvlNine = new int[] { 3, 4, 5,6,  8,10, 12, 7, 9, 11, 13, 14, 15, 16, 17 };
    int[] speciesLvlTen = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65 };
    int[] speciesLvleleven = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18 };
    int[] speciesLvlFourteen = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17,  40, 55, 65,18, 19 };
    int[] speciesLvlFifthteen = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17,  40, 55, 65,18, 19, 45 };
    int[] speciesLvlsixteen = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20 };
    int[] speciesLvlseventeen = new int[] { 3, 4, 5, 6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21 };
    int[] speciesLvlEightteen = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80 };
    int[] speciesLvlNineteen = new int[] { 3, 4, 5, 6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80,  23 };
    int[] speciesLvlTwenty = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80,  23, 24 };
    int[] speciesLvlTwentyone = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80,  23, 24, 30 };
    int[] speciesLvlTwentytwo = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80,  23, 24, 30, 60, 70, 74, 85 };
    int[] speciesLvlTwentythree = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80,  23, 24,30, 60, 70,  74, 85, 90, 100, 110 };
    int[] speciesLvlTwentyfive = new int[] { 3, 4, 5,6, 8, 10, 12, 7, 9, 11, 13, 14, 15, 16, 17, 40, 55, 65, 18, 19, 45, 20, 21, 75, 80, 23, 24,30, 60, 70,  74, 85, 90, 100, 110, 105, 120, 150 };
    int[] species;
    // Start is called before the first frame update
    void Start()
    {
        specieesDefine();
        refreshFirstSlot();
        refreshSecondSlot();
        refreshThirdSlot();
        refreshFourthSlot();
        refreshFifthSlot();
        refreshSixthSlot();
    }
    private void OnEnable()
    {
        specieesDefine();
    }
    private void specieesDefine()
    {
        if(lvlMaster.currentLvl == 1)
        {
            species = speciesLvlOne;
        }
        if (lvlMaster.currentLvl == 2)
        {
            species = speciesLvlTwo;
        }
        if (lvlMaster.currentLvl == 3)
        {
            species = speciesLvlThree;
        }
        if (lvlMaster.currentLvl == 4)
        {
            species = speciesLvlFour;
        }
        if (lvlMaster.currentLvl == 5)
        {
            species = speciesLvlFive;
        }
        if (lvlMaster.currentLvl == 6)
        {
            species = speciesLvlSix;
        }

        if (lvlMaster.currentLvl == 7)
        {
            species = speciesLvlSeven;
        }
        if ((lvlMaster.currentLvl >= 8) &&(lvlMaster.currentLvl < 10))
        {
            species = speciesLvlEight;
        }
        if (lvlMaster.currentLvl >= 9) 
        {
            species = speciesLvlNine;
        }
        if (lvlMaster.currentLvl >= 10) 
        {
            species = speciesLvlTen;
        }
        if (lvlMaster.currentLvl == 11)
        {
            species = speciesLvleleven;
        }
        if (lvlMaster.currentLvl == 14)
        {
            species = speciesLvlFourteen;
        }
        if (lvlMaster.currentLvl == 15)
        {
            species = speciesLvlFifthteen;
        }
        if (lvlMaster.currentLvl == 16)
        {
            species = speciesLvlsixteen;
        }
        if (lvlMaster.currentLvl == 17)
        {
            species = speciesLvlseventeen;
        }
        if (lvlMaster.currentLvl == 18) 
        {
            species = speciesLvlEightteen;
        }
        if (lvlMaster.currentLvl == 19)
        {
            species = speciesLvlNineteen;
        }
        if (lvlMaster.currentLvl == 20)
        {
            species = speciesLvlTwenty;
        }
        if (lvlMaster.currentLvl == 21)
        {
            species = speciesLvlTwentyone;
        }
        if (lvlMaster.currentLvl == 22)
        {
            species = speciesLvlTwentytwo;
        }
        if ((lvlMaster.currentLvl >= 23) && (lvlMaster.currentLvl < 25))
        {
            species = speciesLvlTwentythree;
        }
        if (lvlMaster.currentLvl >= 25)
        {
            species = speciesLvlTwentyfive;
        }
    }
    private void refreshFirstSlot()
    {
        myArray[0,2] = Random.Range(1, 6);
        
        myArray[0,1] = species[Random.Range(0, species.Length)];

    }
    private void refreshSecondSlot()
    {
        myArray[1, 2] = Random.Range(1, 6);
        
        myArray[1, 1] = species[Random.Range(0, species.Length)];

    }
    private void refreshThirdSlot()
    {
        myArray[2, 2] = Random.Range(2, 6);
       
        myArray[2, 1] = species[Random.Range(0, species.Length)];

    }
    private void refreshFourthSlot()
    {
        myArray[3, 2] = Random.Range(2, 6);
        
        myArray[3, 1] = species[Random.Range(0, species.Length)];

    }
    private void refreshFifthSlot()
    {
        myArray[4, 2] = Random.Range(2, 6);
        
        myArray[4, 1] = species[Random.Range(0, species.Length)];

    }
    private void refreshSixthSlot()
    {
        myArray[5, 2] = Random.Range(2, 6);
        
        myArray[5, 1] = species[Random.Range(0, species.Length)];

    }
    
    public void sellFirstSlot()
    {

        if ((myArray[0,1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[0, 2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[0,2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0,2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 4) && (GMScript1.potatoSeeds >= myArray[0, 2]))
        {
            GMScript1.potatoSeeds -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 5) && (GMScript1.carrotSeeds >= myArray[0, 2]))
        {
            GMScript1.carrotSeeds -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 6) && (GMScript1.yaytsa >= myArray[0, 2]))
        {
            GMScript1.yaytsa -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 8) && (GMScript1.cowMilk >= myArray[0, 2]))
        {
            GMScript1.cowMilk -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 10) && (GMScript1.wheatBread >= myArray[0, 2]))
        {
            GMScript1.wheatBread -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        
        if ((myArray[0, 1] == 12) && (GMScript1.whiteBreat >= myArray[0, 2]))
        {
            GMScript1.whiteBreat -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 7) && (GMScript1.sugarPlantSeeds >= myArray[0, 2])) 
        {
            GMScript1.sugarPlantSeeds -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 9) && (GMScript1.sugar >= myArray[0, 2]))
        {
            GMScript1.sugar -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 11) && (GMScript1.apple >= myArray[0, 2]))
        {
            GMScript1.apple -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 13) && (GMScript1.goatMilk >= myArray[0, 2]))
        {
            GMScript1.goatMilk -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 14) && (GMScript1.goatCheese >= myArray[0, 2]))
        {
            GMScript1.goatCheese -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 15) && (GMScript1.butter >= myArray[0, 2]))
        {
            GMScript1.butter -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 16) && (GMScript1.yogurt >= myArray[0, 2]))
        {
            GMScript1.yogurt -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 17) && (GMScript1.coffee >= myArray[0, 2]))
        {
            GMScript1.coffee -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 18) && (GMScript1.orange >= myArray[0, 2]))
        {
            GMScript1.orange -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 40) && (GMScript1.cheeseSandwich >= myArray[0, 2]))
        {
            GMScript1.cheeseSandwich -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 55) && (GMScript1.tomatoSandwich >= myArray[0, 2]))
        {
            GMScript1.tomatoSandwich -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 65) && (GMScript1.orangeCake >= myArray[0, 2]))
        {
            GMScript1.orangeCake -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 19) && (GMScript1.wool >= myArray[0, 2]))
        {
            GMScript1.wool -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 45) && (GMScript1.fabric >= myArray[0, 2]))
        {
            GMScript1.fabric -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 20) && (GMScript1.grape >= myArray[0, 2]))
        {
            GMScript1.grape -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 21) && (GMScript1.whiteGrape >= myArray[0, 2]))
        {
            GMScript1.whiteGrape -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        //if ((myArray[0, 1] == 22) && (GMScript1.pinkGrape >= myArray[0, 2]))
        //{
        //    GMScript1.pinkGrape -= myArray[0, 2];
        //    GMScript1.money += myArray[0, 1] * myArray[0, 2];
        //    GMScript1.exp += myArray[0, 1] * myArray[0, 2]* 2;
        //    refreshFirstSlot();
        //}
        if ((myArray[0, 1] == 75) && (GMScript1.wine >= myArray[0, 2]))
        {
            GMScript1.wine -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 80) && (GMScript1.whiteWine >= myArray[0, 2]))
        {
            GMScript1.whiteWine -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 85) && (GMScript1.pinkWine >= myArray[0, 2]))
        {
            GMScript1.pinkWine -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 23) && (GMScript1.soySeeds >= myArray[0, 2]))
        {
            GMScript1.soySeeds -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 24) && (GMScript1.raspberries >= myArray[0, 2]))
        {
            GMScript1.raspberries -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 60) && (GMScript1.appleJuice >= myArray[0, 2]))
        {
            GMScript1.appleJuice -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 70) && (GMScript1.grapeJuice >= myArray[0, 2]))
        {
            GMScript1.grapeJuice -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 74) && (GMScript1.cherryJuice >= myArray[0, 2]))
        {
            GMScript1.cherryJuice -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 30) && (GMScript1.cherry >= myArray[0, 2]))
        {
            GMScript1.cherry -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 90) && (GMScript1.milkIceCream >= myArray[0, 2]))
        {
            GMScript1.milkIceCream -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 100) && (GMScript1.chocholateIceCream >= myArray[0, 2]))
        {
            GMScript1.chocholateIceCream -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 110) && (GMScript1.raspberryIceCream >= myArray[0, 2]))
        {
            GMScript1.raspberryIceCream -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 105) && (GMScript1.darkSpagetti >= myArray[0, 2]))
        {
            GMScript1.darkSpagetti -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 120) && (GMScript1.spagetti >= myArray[0, 2]))
        {
            GMScript1.spagetti -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
        if ((myArray[0, 1] == 150) && (GMScript1.coloredSpagetti >= myArray[0, 2]))
        {
            GMScript1.coloredSpagetti -= myArray[0, 2];
            GMScript1.money += myArray[0, 1] * myArray[0, 2];
            GMScript1.exp += myArray[0, 1] * myArray[0, 2] * 2;
            refreshFirstSlot();
        }
    }
    public void sellSecondSlot()
    {

        if ((myArray[1, 1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[1, 2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 4) && (GMScript1.potatoSeeds >= myArray[1, 2]))
        {
            GMScript1.potatoSeeds -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 5) && (GMScript1.carrotSeeds >= myArray[1, 2]))
        {
            GMScript1.carrotSeeds -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 8) && (GMScript1.cowMilk >= myArray[1, 2]))
        {
            GMScript1.cowMilk -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 10) && (GMScript1.wheatBread >= myArray[1, 2]))
        {
            GMScript1.wheatBread -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 6) && (GMScript1.yaytsa >= myArray[1, 2]))
        {
            GMScript1.yaytsa -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 12) && (GMScript1.whiteBreat >= myArray[1, 2]))
        {
            GMScript1.whiteBreat -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 7) && (GMScript1.sugarPlantSeeds >= myArray[1, 2]))
        {
            GMScript1.sugarPlantSeeds -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 9) && (GMScript1.sugar >= myArray[1, 2]))
        {
            GMScript1.sugar -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 11) && (GMScript1.apple >= myArray[1, 2]))
        {
            GMScript1.apple -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 13) && (GMScript1.goatCheese >= myArray[1, 2]))
        {
            GMScript1.goatCheese -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 14) && (GMScript1.butter >= myArray[1, 2]))
        {
            GMScript1.butter -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 15) && (GMScript1.yogurt >= myArray[1, 2]))
        {
            GMScript1.yogurt -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 16) && (GMScript1.coffee >= myArray[1, 2]))
        {
            GMScript1.coffee -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 17) && (GMScript1.tomatoes >= myArray[1, 2]))
        {
            GMScript1.tomatoes -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 18) && (GMScript1.orange >= myArray[1, 2]))
        {
            GMScript1.orange -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 40) && (GMScript1.cheeseSandwich >= myArray[1, 2]))
        {
            GMScript1.cheeseSandwich -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 55) && (GMScript1.tomatoSandwich >= myArray[1, 2]))
        {
            GMScript1.tomatoSandwich -= myArray[1, 2];
            GMScript1.money += myArray[0, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 65) && (GMScript1.orangeCake >= myArray[1, 2]))
        {
            GMScript1.orangeCake -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 19) && (GMScript1.wool >= myArray[1, 2]))
        {
            GMScript1.wool -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 45) && (GMScript1.fabric >= myArray[1, 2]))
        {
            GMScript1.fabric -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 20) && (GMScript1.grape >= myArray[1, 2]))
        {
            GMScript1.grape -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 21) && (GMScript1.whiteGrape >= myArray[1, 2]))
        {
            GMScript1.whiteGrape -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        //if ((myArray[1, 1] == 22) && (GMScript1.pinkGrape >= myArray[1, 2]))
        //{
        //    GMScript1.pinkGrape -= myArray[1, 2];
        //    GMScript1.money += myArray[1, 1] * myArray[1, 2];
        //    GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
        //    refreshSecondSlot();
        //}
        if ((myArray[1, 1] == 75) && (GMScript1.wine >= myArray[1, 2]))
        {
            GMScript1.wine -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 80) && (GMScript1.whiteWine >= myArray[1, 2]))
        {
            GMScript1.whiteWine -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 85) && (GMScript1.pinkWine >= myArray[1, 2]))
        {
            GMScript1.pinkWine -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 23) && (GMScript1.soySeeds >= myArray[1, 2])) 
        {
            GMScript1.soySeeds -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 24) && (GMScript1.raspberries >= myArray[1, 2]))
        {
            GMScript1.raspberries -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 60) && (GMScript1.appleJuice >= myArray[1, 2]))
        {
            GMScript1.appleJuice -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 70) && (GMScript1.grapeJuice >= myArray[1, 2]))
        {
            GMScript1.grapeJuice -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 74) && (GMScript1.cherryJuice >= myArray[1, 2]))
        {
            GMScript1.cherryJuice -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 30) && (GMScript1.cherry >= myArray[1, 2]))
        {
            GMScript1.cherry -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 90) && (GMScript1.milkIceCream >= myArray[1, 2]))
        {
            GMScript1.milkIceCream -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 100) && (GMScript1.chocholateIceCream >= myArray[1, 2]))
        {
            GMScript1.chocholateIceCream -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 110) && (GMScript1.raspberryIceCream >= myArray[1, 2]))
        {
            GMScript1.raspberryIceCream -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 105) && (GMScript1.darkSpagetti >= myArray[1, 2]))
        {
            GMScript1.darkSpagetti -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 120) && (GMScript1.spagetti >= myArray[1, 2]))
        {
            GMScript1.spagetti -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
        if ((myArray[1, 1] == 150) && (GMScript1.coloredSpagetti >= myArray[1, 2]))
        {
            GMScript1.coloredSpagetti -= myArray[1, 2];
            GMScript1.money += myArray[1, 1] * myArray[1, 2];
            GMScript1.exp += myArray[1, 1] * myArray[1, 2] * 2;
            refreshSecondSlot();
        }
    }
    public void sellThirdSlot()
    {

        if ((myArray[2, 1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[2, 2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 4) && (GMScript1.potatoSeeds >= myArray[2, 2]))
        {
            GMScript1.potatoSeeds -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 5) && (GMScript1.carrotSeeds >= myArray[2, 2]))
        {
            GMScript1.carrotSeeds -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 8) && (GMScript1.cowMilk >= myArray[2, 2]))
        {
            GMScript1.cowMilk -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 10) && (GMScript1.wheatBread >= myArray[2, 2]))
        {
            GMScript1.wheatBread -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 6) && (GMScript1.yaytsa >= myArray[2, 2]))
        {
            GMScript1.yaytsa -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 12) && (GMScript1.whiteBreat >= myArray[2, 2]))
        {
            GMScript1.whiteBreat -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 7) && (GMScript1.sugarPlantSeeds >= myArray[2, 2]))
        {
            GMScript1.sugarPlantSeeds -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 9) && (GMScript1.sugar >= myArray[2, 2]))
        {
            GMScript1.sugar -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 11) && (GMScript1.apple >= myArray[2, 2]))
        {
            GMScript1.apple -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 13) && (GMScript1.goatCheese >= myArray[2, 2]))
        {
            GMScript1.goatCheese -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 14) && (GMScript1.butter >= myArray[2, 2]))
        {
            GMScript1.butter -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 15) && (GMScript1.yogurt >= myArray[2, 2]))
        {
            GMScript1.yogurt -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 16) && (GMScript1.coffee >= myArray[2, 2]))
        {
            GMScript1.coffee -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 17) && (GMScript1.tomatoes >= myArray[2, 2]))
        {
            GMScript1.tomatoes -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 18) && (GMScript1.orange >= myArray[2, 2]))
        {
            GMScript1.orange -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 40) && (GMScript1.cheeseSandwich >= myArray[2, 2]))
        {
            GMScript1.cheeseSandwich -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 55) && (GMScript1.tomatoSandwich >= myArray[2, 2]))
        {
            GMScript1.tomatoSandwich -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 65) && (GMScript1.orangeCake >= myArray[2, 2]))
        {
            GMScript1.orangeCake -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 19) && (GMScript1.wool >= myArray[2, 2]))
        {
            GMScript1.wool -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 45) && (GMScript1.fabric >= myArray[2, 2]))
        {
            GMScript1.fabric -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 20) && (GMScript1.grape >= myArray[2, 2]))
        {
            GMScript1.grape -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 21) && (GMScript1.whiteGrape >= myArray[2, 2]))
        {
            GMScript1.whiteGrape -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        //if ((myArray[2, 1] == 22) && (GMScript1.pinkGrape >= myArray[2, 2]))
        //{
        //    GMScript1.pinkGrape -= myArray[2, 2];
        //    GMScript1.money += myArray[2, 1] * myArray[2, 2];
        //    GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
        //    refreshThirdSlot();
        //}
        if ((myArray[2, 1] == 75) && (GMScript1.wine >= myArray[2, 2]))
        {
            GMScript1.wine -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 80) && (GMScript1.whiteWine >= myArray[2, 2]))
        {
            GMScript1.whiteWine -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 85) && (GMScript1.pinkWine >= myArray[2, 2]))
        {
            GMScript1.pinkWine -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 23) && (GMScript1.soySeeds >= myArray[2, 2]))
        {
            GMScript1.soySeeds -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 24) && (GMScript1.raspberries >= myArray[2, 2]))
        {
            GMScript1.raspberries -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 60) && (GMScript1.appleJuice >= myArray[2, 2]))
        {
            GMScript1.appleJuice -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 70) && (GMScript1.grapeJuice >= myArray[2, 2]))
        {
            GMScript1.grapeJuice -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 74) && (GMScript1.cherryJuice >= myArray[2, 2]))
        {
            GMScript1.cherryJuice -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 30) && (GMScript1.cherry >= myArray[2, 2]))
        {
            GMScript1.cherry -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 90) && (GMScript1.milkIceCream >= myArray[2, 2]))
        {
            GMScript1.milkIceCream -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 100) && (GMScript1.chocholateIceCream >= myArray[2, 2]))
        {
            GMScript1.chocholateIceCream -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 110) && (GMScript1.raspberryIceCream >= myArray[2, 2]))
        {
            GMScript1.raspberryIceCream -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 105) && (GMScript1.darkSpagetti >= myArray[2, 2]))
        {
            GMScript1.darkSpagetti -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 120) && (GMScript1.spagetti >= myArray[2, 2]))
        {
            GMScript1.spagetti -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
        if ((myArray[2, 1] == 150) && (GMScript1.coloredSpagetti >= myArray[2, 2]))
        {
            GMScript1.coloredSpagetti -= myArray[2, 2];
            GMScript1.money += myArray[2, 1] * myArray[2, 2];
            GMScript1.exp += myArray[2, 1] * myArray[2, 2] * 2;
            refreshThirdSlot();
        }
    }
    public void sellFourthSlot()
    {

        if ((myArray[3, 1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[3, 2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 4) && (GMScript1.potatoSeeds >= myArray[3, 2]))
        {
            GMScript1.potatoSeeds -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 5) && (GMScript1.carrotSeeds >= myArray[3, 2]))
        {
            GMScript1.carrotSeeds -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 8) && (GMScript1.cowMilk >= myArray[3, 2]))
        {
            GMScript1.cowMilk -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 10) && (GMScript1.wheatBread >= myArray[3, 2]))
        {
            GMScript1.wheatBread -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 6) && (GMScript1.yaytsa >= myArray[3, 2]))
        {
            GMScript1.yaytsa -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 12) && (GMScript1.whiteBreat >= myArray[3, 2]))
        {
            GMScript1.whiteBreat -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 7) && (GMScript1.sugarPlantSeeds >= myArray[3, 2]))
        {
            GMScript1.sugarPlantSeeds -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 9) && (GMScript1.sugar >= myArray[3, 2]))
        {
            GMScript1.sugar -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 11) && (GMScript1.apple >= myArray[3, 2]))
        {
            GMScript1.apple -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 13) && (GMScript1.goatCheese >= myArray[3, 2]))
        {
            GMScript1.goatCheese -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 14) && (GMScript1.butter >= myArray[3, 2]))
        {
            GMScript1.butter -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 15) && (GMScript1.yogurt >= myArray[3, 2]))
        {
            GMScript1.yogurt -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 16) && (GMScript1.coffee >= myArray[3, 2]))
        {
            GMScript1.coffee -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 17) && (GMScript1.tomatoes >= myArray[3, 2]))
        {
            GMScript1.tomatoes -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 18) && (GMScript1.orange >= myArray[3, 2]))
        {
            GMScript1.orange -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 40) && (GMScript1.cheeseSandwich >= myArray[3, 2]))
        {
            GMScript1.cheeseSandwich -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 55) && (GMScript1.tomatoSandwich >= myArray[3, 2]))
        {
            GMScript1.tomatoSandwich -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 65) && (GMScript1.orangeCake >= myArray[3, 2]))
        {
            GMScript1.orangeCake -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 19) && (GMScript1.wool >= myArray[3, 2]))
        {
            GMScript1.wool -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 45) && (GMScript1.fabric >= myArray[3, 2]))
        {
            GMScript1.fabric -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 20) && (GMScript1.grape >= myArray[3, 2]))
        {
            GMScript1.grape -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 21) && (GMScript1.whiteGrape >= myArray[3, 2]))
        {
            GMScript1.whiteGrape -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        //if ((myArray[3, 1] == 22) && (GMScript1.pinkGrape >= myArray[3, 2]))
        //{
        //    GMScript1.pinkGrape -= myArray[3, 2];
        //    GMScript1.money += myArray[3, 1] * myArray[3, 2];
        //    GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
        //    refreshFourthSlot();
        //}
        if ((myArray[3, 1] == 75) && (GMScript1.wine >= myArray[3, 2]))
        {
            GMScript1.wine -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 80) && (GMScript1.whiteWine >= myArray[3, 2]))
        {
            GMScript1.whiteWine -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 85) && (GMScript1.pinkWine >= myArray[3, 2]))
        {
            GMScript1.pinkWine -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 23) && (GMScript1.soySeeds >= myArray[3, 2]))
        {
            GMScript1.soySeeds -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 24) && (GMScript1.raspberries >= myArray[3, 2]))
        {
            GMScript1.raspberries -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 60) && (GMScript1.appleJuice >= myArray[3, 2]))
        {
            GMScript1.appleJuice -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 70) && (GMScript1.grapeJuice >= myArray[3, 2]))
        {
            GMScript1.grapeJuice -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 74) && (GMScript1.cherryJuice >= myArray[3, 2]))
        {
            GMScript1.cherryJuice -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 30) && (GMScript1.cherry >= myArray[3, 2]))
        {
            GMScript1.cherry -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 90) && (GMScript1.milkIceCream >= myArray[3, 2]))
        {
            GMScript1.milkIceCream -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] *2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 100) && (GMScript1.chocholateIceCream >= myArray[3, 2]))
        {
            GMScript1.chocholateIceCream -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 110) && (GMScript1.raspberryIceCream >= myArray[3, 2]))
        {
            GMScript1.raspberryIceCream -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 105) && (GMScript1.darkSpagetti >= myArray[3, 2]))
        {
            GMScript1.darkSpagetti -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 120) && (GMScript1.spagetti >= myArray[3, 2]))
        {
            GMScript1.spagetti -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
        if ((myArray[3, 1] == 150) && (GMScript1.coloredSpagetti >= myArray[3, 2]))
        {
            GMScript1.coloredSpagetti -= myArray[3, 2];
            GMScript1.money += myArray[3, 1] * myArray[3, 2];
            GMScript1.exp += myArray[3, 1] * myArray[3, 2] * 2;
            refreshFourthSlot();
        }
    }
    public void sellFifthSlot()
    {

        if ((myArray[4, 1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[4, 2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 4) && (GMScript1.potatoSeeds >= myArray[4, 2]))
        {
            GMScript1.potatoSeeds -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 5) && (GMScript1.carrotSeeds >= myArray[4, 2]))
        {
            GMScript1.carrotSeeds -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 8) && (GMScript1.cowMilk >= myArray[4, 2]))
        {
            GMScript1.cowMilk -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 10) && (GMScript1.wheatBread >= myArray[4, 2]))
        {
            GMScript1.wheatBread -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 6) && (GMScript1.yaytsa >= myArray[4, 2]))
        {
            GMScript1.yaytsa -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 12) && (GMScript1.whiteBreat >= myArray[4, 2]))
        {
            GMScript1.whiteBreat -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 7) && (GMScript1.sugarPlantSeeds >= myArray[4, 2]))
        {
            GMScript1.sugarPlantSeeds -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 9) && (GMScript1.sugar >= myArray[4, 2]))
        {
            GMScript1.sugar -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 11) && (GMScript1.apple >= myArray[4, 2]))
        {
            GMScript1.apple -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 13) && (GMScript1.goatCheese >= myArray[4, 2]))
        {
            GMScript1.goatCheese -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 14) && (GMScript1.butter >= myArray[4, 2]))
        {
            GMScript1.butter -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 15) && (GMScript1.yogurt >= myArray[4, 2]))
        {
            GMScript1.yogurt -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 16) && (GMScript1.coffee >= myArray[4, 2]))
        {
            GMScript1.coffee -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 17) && (GMScript1.tomatoes >= myArray[4, 2]))
        {
            GMScript1.tomatoes -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 18) && (GMScript1.orange >= myArray[4, 2]))
        {
            GMScript1.orange -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 40) && (GMScript1.cheeseSandwich >= myArray[4, 2]))
        {
            GMScript1.cheeseSandwich -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 55) && (GMScript1.tomatoSandwich >= myArray[4, 2]))
        {
            GMScript1.tomatoSandwich -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 65) && (GMScript1.orangeCake >= myArray[4, 2]))
        {
            GMScript1.orangeCake -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 19) && (GMScript1.wool >= myArray[4, 2]))
        {
            GMScript1.wool -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 45) && (GMScript1.fabric >= myArray[4, 2]))
        {
            GMScript1.fabric -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 20) && (GMScript1.grape >= myArray[4, 2]))
        {
            GMScript1.grape -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 21) && (GMScript1.whiteGrape >= myArray[4, 2]))
        {
            GMScript1.whiteGrape -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        //if ((myArray[4, 1] == 22) && (GMScript1.pinkGrape >= myArray[4, 2]))
        //{
        //    GMScript1.pinkGrape -= myArray[4, 2];
        //    GMScript1.money += myArray[4, 1] * myArray[4, 2];
        //    GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
        //    refreshFifthSlot();
        //}
        if ((myArray[4, 1] == 75) && (GMScript1.wine >= myArray[4, 2]))
        {
            GMScript1.wine -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 80) && (GMScript1.whiteWine >= myArray[4, 2]))
        {
            GMScript1.whiteWine -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 85) && (GMScript1.pinkWine >= myArray[4, 2]))
        {
            GMScript1.pinkWine -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 23) && (GMScript1.soySeeds >= myArray[4, 2]))
        {
            GMScript1.soySeeds -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 24) && (GMScript1.raspberries >= myArray[4, 2]))
        {
            GMScript1.raspberries -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 60) && (GMScript1.appleJuice >= myArray[4, 2]))
        {
            GMScript1.appleJuice -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 70) && (GMScript1.grapeJuice >= myArray[4, 2]))
        {
            GMScript1.grapeJuice -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 74) && (GMScript1.cherryJuice >= myArray[4, 2]))
        {
            GMScript1.cherryJuice -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 30) && (GMScript1.cherry >= myArray[4, 2]))
        {
            GMScript1.cherry -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 90) && (GMScript1.milkIceCream >= myArray[4, 2]))
        {
            GMScript1.milkIceCream -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 100) && (GMScript1.chocholateIceCream >= myArray[4, 2]))
        {
            GMScript1.chocholateIceCream -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 110) && (GMScript1.raspberryIceCream >= myArray[4, 2]))
        {
            GMScript1.raspberryIceCream -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 105) && (GMScript1.darkSpagetti >= myArray[4, 2]))
        {
            GMScript1.darkSpagetti -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 120) && (GMScript1.spagetti >= myArray[4, 2]))
        {
            GMScript1.spagetti -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
        if ((myArray[4, 1] == 150) && (GMScript1.coloredSpagetti >= myArray[4, 2]))
        {
            GMScript1.coloredSpagetti -= myArray[4, 2];
            GMScript1.money += myArray[4, 1] * myArray[4, 2];
            GMScript1.exp += myArray[4, 1] * myArray[4, 2] * 2;
            refreshFifthSlot();
        }
    }
    public void sellSixthSlot()
    {

        if ((myArray[5, 1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[5, 2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[5, 2];
            GMScript1.money += myArray[5, 1] * myArray[5, 2];
            GMScript1.exp += myArray[5, 1] * myArray[5, 2] / 2;
            refreshSixthSlot();
        }
        if ((myArray[5, 1] == 4) && (GMScript1.potatoSeeds >= myArray[5, 2]))
        {
            GMScript1.potatoSeeds -= myArray[5, 2];
            GMScript1.money += myArray[5, 1] * myArray[5, 2];
            GMScript1.exp += myArray[5, 1] * myArray[5, 2] / 2;
            refreshSixthSlot();
        }
        if ((myArray[5, 1] == 5) && (GMScript1.carrotSeeds >= myArray[5, 2]))
        {
            GMScript1.carrotSeeds -= myArray[5, 2];
            GMScript1.money += myArray[5, 1] * myArray[5, 2];
            GMScript1.exp += myArray[5, 1] * myArray[5, 2] / 2;
            refreshSixthSlot();
        }
        if ((myArray[5, 1] == 8) && (GMScript1.cowMilk >= myArray[5, 2]))
        {
            GMScript1.cowMilk -= myArray[5, 2];
            GMScript1.money += myArray[5, 1] * myArray[5, 2];
            GMScript1.exp += myArray[5, 1] * myArray[5, 2] / 2;
            refreshSixthSlot();
        }
        if ((myArray[5, 1] == 10) && (GMScript1.wheatBread >= myArray[5, 2]))
        {
            GMScript1.wheatBread -= myArray[5, 2];
            GMScript1.money += myArray[5, 1] * myArray[5, 2];
            GMScript1.exp += myArray[5, 1] * myArray[5, 2] / 2;
            refreshSixthSlot();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
        //1111111111
        //slott    1
        //1111111111
        //1111111111
        
        int i;
        for (i = 0; i <species.Length; i++)
        {
            if(myArray[0,1] == species[i])
            {
                slotsImageArray[0].sprite = spties[i];
            }
        }
            ammountOfGoodsArray[0].text = myArray[0, 2].ToString();
        ammountOfRevenueArray[0].text = (myArray[0, 2] * myArray[0, 1]).ToString();
        ammountOfexpArray[0].text = (myArray[0, 1] * myArray[0, 2] / 2).ToString();
        //2222222222
        //slott    2
        //2222222222
        //2222222222
        int b;
        for (b = 0; b < species.Length; b++)
        {
            if (myArray[1, 1] == species[b])
            {
                slotsImageArray[1].sprite = spties[b];
            }
        }
        ammountOfGoodsArray[1].text = myArray[1, 2].ToString();
        ammountOfRevenueArray[1].text = (myArray[1, 2] * myArray[1, 1]).ToString();
        ammountOfexpArray[1].text = (myArray[1, 1] * myArray[1, 2] / 2).ToString();
        //3333333333
        //slott    3
        //3333333333
        //3333333333
        int c;
        for (c = 0; c < species.Length; c++)
        {
            if (myArray[2, 1] == species[c])
            {
                slotsImageArray[2].sprite = spties[c];
            }
        }
        ammountOfGoodsArray[2].text = myArray[2, 2].ToString();
        ammountOfRevenueArray[2].text = (myArray[2, 2] * myArray[2, 1]).ToString();
        ammountOfexpArray[2].text = (myArray[2, 1] * myArray[2, 2] / 2).ToString();
        //4444444444
        //slott    4
        //4444444444
        //4444444444
        int d;
        for (d = 0; d < species.Length; d++)
        {
            if (myArray[3, 1] == species[d])
            {
                slotsImageArray[3].sprite = spties[d];
            }
        }
        ammountOfGoodsArray[3].text = myArray[3, 2].ToString();
        ammountOfRevenueArray[3].text = (myArray[3, 2] * myArray[3, 1]).ToString();
        ammountOfexpArray[3].text = (myArray[3, 1] * myArray[3, 2] / 2).ToString();
        //5555555555
        //slott    5
        //5555555555
        //5555555555
        int e;
        for (e = 0; e < species.Length; e++)
        {
            if (myArray[4, 1] == species[e])
            {
                slotsImageArray[4].sprite = spties[e];
            }
        }
        ammountOfGoodsArray[4].text = myArray[4, 2].ToString();
        ammountOfRevenueArray[4].text = (myArray[4, 2] * myArray[4, 1]).ToString();
        ammountOfexpArray[4].text = (myArray[4, 1] * myArray[4, 2] / 2).ToString();
        //6666666666
        //slott    6
        //6666666666
        //6666666666
        if (myArray[5, 1] == 3)
        {
            slotsImageArray[5].sprite = spties[0];
            // tipeOfGoods.text = "пшеница";
        }
        if (myArray[5, 1] == 4)
        {
            slotsImageArray[5].sprite = spties[1];
            //tipeOfGoods.text = "картошка";
        }
        if (myArray[5, 1] == 5)
        {
            slotsImageArray[5].sprite = spties[2];
            //tipeOfGoods.text = "морковка";
        }
        if (myArray[5, 1] == 8)
        {
            slotsImageArray[5].sprite = spties[3];
            // tipeOfGoods.text = "молоко";
        }
        if (myArray[5, 1] == 10)
        {
            slotsImageArray[5].sprite = spties[4];
            //tipeOfGoods.text = "хлеб";
        }
        ammountOfGoodsArray[5].text = myArray[5, 2].ToString();
        ammountOfRevenueArray[5].text = (myArray[5, 2] * myArray[5, 1]).ToString();
        ammountOfexpArray[5].text = (myArray[5, 1] * myArray[5, 2] / 2).ToString();

    }
}
