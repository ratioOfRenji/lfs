using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veryNewTools : MonoBehaviour
{
    public Transform seedInventory;

         public void scythe()
         {
            GMScript1.currentTool = "scythe";
            Debug.Log(GMScript1.currentTool);
         }
         public void semena()
         {
           GMScript1.currentTool = "семена";
          seedInventory.transform.position = new Vector2(4.55f, -4);

         }
        public void vedro()
        {
         GMScript1.currentTool = "vedro1";

        }
        public void feed()
        {
         GMScript1.currentTool = "кормить";

        }
        public void takeSunflower()
        {
         GMScript1.currentTool = "sunflower";
        }
        public void takeCarrot()
        {
         GMScript1.currentTool = "carrot";
        }
        public void takePotato()
        {
         GMScript1.currentTool = "potato";
        }
         public void takeSoy()
        {
        GMScript1.currentTool = "soy";
        }
    public void takeSugarPlant()
    {
        GMScript1.currentTool = "sugarPlant";
    }
    public void takeBeans()
    {
        GMScript1.currentTool = "beans";
    }

}
