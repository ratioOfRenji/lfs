using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tasksSystem : MonoBehaviour
{
    public static int[] myArray = { 0, 0, 0 };
    public Text ammountOfGoods;
    public Text ammontRevwnue;
    public Text ammontExp;
    //public Text tipeOfGoods;
    public Image image; 
    public Sprite [] spties;
    // Start is called before the first frame update
    void Start()
    {
        refresh();
    }
    private void refresh()
    {
        myArray[2] = Random.Range(1, 6);
        int[] species = new int[] { 3, 4, 5, 8, 10 };
        myArray[1] = species[Random.Range(0, species.Length)];
        
    }
    public void sell()
    {

        if ((myArray[1] == 3) && (GMScript1.sunFlowerSeeds >= myArray[2]))
        {
            GMScript1.sunFlowerSeeds -= myArray[2];
            GMScript1.money += myArray[1] * myArray[2];
            GMScript1.exp += myArray[1] * myArray[2] /2;
            refresh();
        }
        if ((myArray[1] == 4) && (GMScript1.potatoSeeds >= myArray[2]))
        {
            GMScript1.potatoSeeds -= myArray[2];
            GMScript1.money += myArray[1] * myArray[2];
            GMScript1.exp += myArray[1] * myArray[2] / 2;
            refresh();
        }
        if ((myArray[1] == 5) && (GMScript1.carrotSeeds >= myArray[2]))
        {
            GMScript1.carrotSeeds -= myArray[2];
            GMScript1.money += myArray[1] * myArray[2];
            GMScript1.exp += myArray[1] * myArray[2] / 2;
            refresh();
        }
        if ((myArray[1] == 8) && (GMScript1.cowMilk >= myArray[2]))
        {
            GMScript1.cowMilk -= myArray[2];
            GMScript1.money += myArray[1] * myArray[2];
            GMScript1.exp += myArray[1] * myArray[2] / 2;
            refresh();
        }
        if ((myArray[1] == 10) && (GMScript1.wheatBread >= myArray[2]))
        {
            GMScript1.wheatBread -= myArray[2];
            GMScript1.money += myArray[1] * myArray[2];
            GMScript1.exp += myArray[1] * myArray[2] / 2;
            refresh();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if(myArray[1] == 3) 
        {
            image.sprite = spties[0];
           // tipeOfGoods.text = "пшеница";
        }
        if (myArray[1] == 4) 
        {
            image.sprite = spties[1];
            //tipeOfGoods.text = "картошка";
        }
        if (myArray[1] == 5) 
        {
            image.sprite = spties[2];
            //tipeOfGoods.text = "морковка";
        }
        if (myArray[1] == 8) 
        {
            image.sprite = spties[3];
           // tipeOfGoods.text = "молоко";
        }
        if (myArray[1] == 10) 
        {
            image.sprite = spties[4];
            //tipeOfGoods.text = "хлеб";
        }
        ammountOfGoods.text = myArray[2].ToString();
        ammontRevwnue.text = (myArray[2]* myArray[1]).ToString();
        ammontExp.text = (myArray[1] * myArray[2] / 2).ToString();
    }
   
}
