using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textForShreder : MonoBehaviour
{
    public Text text;

    public Text sugarText;
    public Text coffeeText;
    

    public Image sugar;
    public Image coffee;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sugarText.text = (GMScript1.sugarPlantSeeds + " / 2 ").ToString();
        coffeeText.text = (GMScript1.coffeeSeeds + " / 2 ").ToString();
        

        if (GMScript1.sugarPlantSeeds < 2)
        {
            sugarText.color = new Color(1, 0.6f, 0.6f);
            sugar.color = new Color(sugar.color.r, sugar.color.g, sugar.color.b, 0.6f);
        }
        else
        {
            sugarText.color = Color.white;
            sugar.color = new Color(sugar.color.r, sugar.color.g, sugar.color.b, 1f);
        }


        if (GMScript1.coffeeSeeds < 2)
        {
            coffeeText.color = new Color(1, 0.6f, 0.6f);
            coffee.color = new Color(coffee.color.r, coffee.color.g, coffee.color.b, 0.6f);
        }
        else
        {
            coffeeText.color = Color.white;
            coffee.color = new Color(coffee.color.r, coffee.color.g, coffee.color.b, 1);
        }


       
    }
}
