using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ambarTextScript : MonoBehaviour
{
    public Text [] UiObjects;
    public int[] species ;
    private void Update()
    {
        //    species = new int[] { GMScript1.sunFlowerSeeds, GMScript1.carrotSeeds, GMScript1.potatoSeeds, GMScript1.yaytsa, GMScript1.cowMilk, GMScript1.wheatBread, GMScript1.whiteBreat, GMScript1.sugarPlantSeeds, GMScript1.sugar, GMScript1.apple, GMScript1.goatMilk, GMScript1.goatCheese, GMScript1.butter, GMScript1.yogurt, GMScript1.coffeeSeeds, GMScript1.coffee,GMScript1.orange, GMScript1.tomatoSandwich,GMScript1.orangeCake, GMScript1.cheeseSandwich,  
        //GMScript1.wool,GMScript1.fabric,GMScript1.grape,GMScript1.whiteGrape,GMScript1.wine,GMScript1.whiteWine,GMScript1.soySeeds,GMScript1.raspberries,GMScript1.cherry, GMScript1.appleJuice, GMScript1.grapeJuice,  GMScript1.pinkWine,GMScript1.cherryJuice, GMScript1.milkIceCream, GMScript1.chocholateIceCream, GMScript1.raspberryIceCream, GMScript1.darkSpagetti, GMScript1.spagetti, GMScript1.coloredSpagetti};
        species = new int[] { GMScript1.sunFlowerSeeds, GMScript1.carrotSeeds, GMScript1.potatoSeeds, GMScript1.yaytsa,   GMScript1.cowMilk, GMScript1.wheatBread, GMScript1.whiteBreat, GMScript1.sugarPlantSeeds, GMScript1.sugar, GMScript1.apple, GMScript1.goatMilk,
         GMScript1.goatCheese, GMScript1.butter, GMScript1.yogurt, GMScript1.coffeeSeeds, GMScript1.coffee, GMScript1.cheeseSandwich, GMScript1.tomatoSandwich, GMScript1.orangeCake, GMScript1.orange, GMScript1.wool, GMScript1.fabric, GMScript1.grape,
        GMScript1.whiteGrape, GMScript1.wine, GMScript1.whiteWine, GMScript1.soySeeds, GMScript1.raspberries, GMScript1.cherry, GMScript1.appleJuice, GMScript1.grapeJuice, GMScript1.pinkWine, GMScript1.cherryJuice, GMScript1.milkIceCream, GMScript1.chocholateIceCream, GMScript1.raspberryIceCream,
        GMScript1.darkSpagetti, GMScript1.spagetti, GMScript1.coloredSpagetti};
        int i;
        for (i = 0; i < UiObjects.Length; i++)
        {
            UiObjects[i].text = species[i].ToString();
           
        }
        // Debug.Log(GMScript1.appleJuice + " " + GMScript1.grapeJuice + "  " + GMScript1.cherryJuice + "  " + GMScript1.pinkWine + "  сюда");
       
    }
    
}
