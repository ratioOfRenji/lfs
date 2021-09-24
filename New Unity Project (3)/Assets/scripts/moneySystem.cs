using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneySystem : MonoBehaviour
{
    public GameObject[] field;
    public GameObject kuriatnic;
    public GameObject cow;
    public GameObject bakery;
    public GameObject goat;
    public GameObject sheep;
    public GameObject shreder;
    public GameObject[] appleTree;
    public GameObject milkFactory;
    public GameObject[] coffeeTree;
    public GameObject[] orangeTree;
    public GameObject grill;
    public GameObject woolFactory;
    public GameObject[] grape;
    public GameObject[] grapeWhite;
    public GameObject[] grapePink;
    public GameObject wineFactory;
    public GameObject[] raspberry;
    public GameObject squizzer;
    public GameObject[] cherry;
    public GameObject iceCreamMachine;
    public GameObject spagettiMachine;
    public GameObject kupitUi;
    public GameObject ccow;
    public int a=0;
    public int b=0;
    public int c=0;
    public int d=0;
    public int e=0;
    public int f=0;
    public int g=0;
    public int h=0;
    public int i;
    public void prodatPodsolnux()
    {
        if (GMScript1.sunFlowerSeeds > 0)
        {
            GMScript1.sunFlowerSeeds--;
            GMScript1.money += 2;
        }
            
    }
    public void prodatMorkovku()
    {
        if (GMScript1.carrotSeeds > 0)
        {
            GMScript1.carrotSeeds--;
            GMScript1.money += 3;
        }
    }
    public void prodatKartoshku()
    {
        if (GMScript1.potatoSeeds > 0)
        {
            GMScript1.potatoSeeds--;
            GMScript1.money += 4;
        }
    }
    public void buyField()
    {
        for (int i = 0; i < field.Length; i++)
        {
            if ((GMScript1.money >= 20) && (field[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 1 + (i-2)))
            {
                kupitUi.SetActive(false);
                field[i].SetActive(true);
                field[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 20;

                break;
            }
        }

    }
    public void buyCoffeeTree()
    {
        for (int i = 0; i < coffeeTree.Length; i++)
        {
            if ((GMScript1.money >= 500) && (coffeeTree[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 9 + i))
            {
                kupitUi.SetActive(false);
                coffeeTree[i].SetActive(true);
                coffeeTree[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 500;

                break;
            }
        }

    }
    public void buyAppleTree()
    {
        for (int i = 0; i < appleTree.Length; i++)
        {
            if ((GMScript1.money >= 300) && (appleTree[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 7))
            {
                kupitUi.SetActive(false);
                appleTree[i].SetActive(true);
                appleTree[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 300;
                
                break;
            }
        }

    }
    public void buyOrangeTree()
    {
        for (int i = 0; i < orangeTree.Length; i++)
        {
            if ((GMScript1.money >= 300) && (orangeTree[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 11 + i))
            {
                kupitUi.SetActive(false);
                orangeTree[i].SetActive(true);
                orangeTree[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 300;

                break;
            }
        }

    }
    public void buygrape()
    {
        for (int i = 0; i < grape.Length; i++)
        {
            if ((GMScript1.money >= 2000) && (grape[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 16 + i))
            {
                kupitUi.SetActive(false);
                grape[i].SetActive(true);
                grape[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 2000;

                break;
            }
        }

    }
    public void buyWhiteGrape()
    {
        for (int i = 0; i < grapeWhite.Length; i++)
        {
            if ((GMScript1.money >= 2000) && (grapeWhite[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 17 + i))
            {
                kupitUi.SetActive(false);
                grapeWhite[i].SetActive(true);
                grapeWhite[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 2000;

                break;
            }
        }

    }
    public void buyRaspberry()
    {
        for (int i = 0; i < raspberry.Length; i++)
        {
            if ((GMScript1.money >= 1000) && (raspberry[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 20 + i))
            {
                kupitUi.SetActive(false);
                raspberry[i].SetActive(true);
                raspberry[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 1000;

                break;
            }
        }

    }
    public void buyCherry()
    {
        for (int i = 0; i < cherry.Length; i++)
        {
            if ((GMScript1.money >= 2500) && (cherry[i].GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 21 + i))
            {
                kupitUi.SetActive(false);
                cherry[i].SetActive(true);
                cherry[i].GetComponent<dragAfterBought>().bought = true;
                GMScript1.money -= 2500;
                cherry[i].GetComponent<dragAfterBought>().activateBool();
                break;
            }
        }

    }
   
    public void buyBakery()
    {
        if ((GMScript1.money >= 160) && (bakery.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 6))
        {
            kupitUi.SetActive(false);
            bakery.SetActive(true);
            bakery.GetComponent<dragAfterBought>().activateBool();
            GMScript1.money -= 80;
        }
    }
    public void buyGoat()
    {
        if ((GMScript1.money >= 500) && (goat.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 8))
        {
            kupitUi.SetActive(false);
            goat.SetActive(true);
            goat.GetComponent<dragAfterBought>().activateBool();
            GMScript1.money -= 500;
        }
    }
    public void buyMilkFactory()
    {
        if ((GMScript1.money >= 1000) && (milkFactory.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 8))
        {
            kupitUi.SetActive(false);
            milkFactory.SetActive(true);
            milkFactory.GetComponent<dragAfterBought>().activateBool();
            GMScript1.money -= 1000;
        }
    }
    public void buySheep()
    {
        if ((GMScript1.money >= 1700) && (sheep.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 14))
        {
            kupitUi.SetActive(false);
            sheep.SetActive(true);
            sheep.GetComponent<dragAfterBought>().activateBool();
            GMScript1.money -= 1700;
        }
    }
    public void buyWoolFactory()
    {
        if ((GMScript1.money >= 2500) && (woolFactory.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 15))
        {
            kupitUi.SetActive(false);
            woolFactory.SetActive(true);

            GMScript1.money -= 2500;
            woolFactory.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buyShreder()
    {
        if ((GMScript1.money >= 50) && (shreder.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >=7))
        {
            kupitUi.SetActive(false);
            shreder.SetActive(true);

            GMScript1.money -= 50;
            shreder.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buyGrill()
    {
        if ((GMScript1.money >= 100) &&(grill.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 10))
        {
            kupitUi.SetActive(false);
            grill.SetActive(true);
           
          GMScript1.money -= 100;
            grill.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buySquizzer()
    {
        if ((GMScript1.money >= 5000) && (squizzer.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 22))
        {
            kupitUi.SetActive(false);
            squizzer.SetActive(true);

            GMScript1.money -= 5000;
            squizzer.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buyWineFactory()
    {
        if ((GMScript1.money >= 4000) && (wineFactory.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 18))
        {
            kupitUi.SetActive(false);
            wineFactory.SetActive(true);

            GMScript1.money -= 4000;
            wineFactory.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buyIceCream()
    {
        if ((GMScript1.money >= 7000) && (iceCreamMachine.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 23))
        {
            kupitUi.SetActive(false);
            iceCreamMachine.SetActive(true);

            GMScript1.money -= 7000;
            iceCreamMachine.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buySpagettiMachine()
    {
        if ((GMScript1.money >= 10000) && (spagettiMachine.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 25))
        {
            kupitUi.SetActive(false);
            spagettiMachine.SetActive(true);

            GMScript1.money -= 10000;
            spagettiMachine.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void kupitKuritsu()
    {
        if ((GMScript1.money >= 40) && (kuriatnic.GetComponent<dragAfterBought>().bought == false) && (lvlMaster.currentLvl >= 4))
        {
            kupitUi.SetActive(false);
            kuriatnic.SetActive(true);

            GMScript1.money -= 40;
            kuriatnic.GetComponent<dragAfterBought>().activateBool();
        }
    }
    public void buyCCow()
    {
        if((lvlMaster.currentLvl >= 5))
        {
 if ((GMScript1.money >= 80) && (ccow.GetComponent<dragAfterBought>().bought == false)  )
        {
            GMScript1.money -= 40;
            kupitUi.SetActive(false);
            ccow.SetActive(true);
                ccow.GetComponent<dragAfterBought>().activateBool();
            
        }
        }
       
    }
    public void buyWheat()
    {
        if ((GMScript1.money >= 10)  && (lvlMaster.currentLvl >= 1))
        {
            GMScript1.sunFlowerSeeds++;
            GMScript1.money -= 10;
        }
    }
    public void buyCarrot()
    {
        if ((GMScript1.money >= 15) && (lvlMaster.currentLvl >= 3))
        {
            GMScript1.carrotSeeds++;
            GMScript1.money -= 15;
        }
    }
    public void buyPotato()
    {
        if ((GMScript1.money >= 30) && (lvlMaster.currentLvl >= 2))
        {
            GMScript1.potatoSeeds++;
            GMScript1.money -= 30;
        }
    }
    public void buySugarPlant()
    {
        if ((GMScript1.money >= 200) && (lvlMaster.currentLvl >= 7))
        {
            GMScript1.sugarPlantSeeds++;
            GMScript1.money -= 200;
        }
    }
    public void buyTomato()
    {
        if ((GMScript1.money >= 500) && (lvlMaster.currentLvl >= 11))
        {
            GMScript1.tomatoes++;
            GMScript1.money -= 500;
        }
    }
    public void buySoy()
    {
        if ((GMScript1.money >= 1000) && (lvlMaster.currentLvl >= 19))
        {
            GMScript1.soySeeds++;
            GMScript1.money -= 1000;
        }
    }
}
