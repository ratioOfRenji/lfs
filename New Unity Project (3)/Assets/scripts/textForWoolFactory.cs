using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textForWoolFactory : MonoBehaviour
{
    public Text text;

    public Text cheeseText;
    //public Text butterText;
    //public Text yogurtText;

    public Image cheese;
    //public Image butter;
    //public Image yogurt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cheeseText.text = (GMScript1.wool + " / 2 ").ToString();
        //butterText.text = (GMScript1.cowMilk + " / 2 ").ToString();
        //yogurtText.text = (GMScript1.cowMilk + " / 2 ").ToString();

        if (GMScript1.goatMilk < 2)
        {
            cheeseText.color = new Color(1, 0.6f, 0.6f);
            cheese.color = new Color(cheese.color.r, cheese.color.g, cheese.color.b, 0.6f);
        }
        else
        {
            cheeseText.color = Color.white;
            cheese.color = new Color(cheese.color.r, cheese.color.g, cheese.color.b, 1f);
        }


        //if (GMScript1.cowMilk < 2)
        //{
        //    butterText.color = new Color(1, 0.6f, 0.6f);
        //    butter.color = new Color(butter.color.r, butter.color.g, butter.color.b, 0.6f);
        //}
        //else
        //{
        //    butterText.color = Color.white;
        //    butter.color = new Color(butter.color.r, butter.color.g, butter.color.b, 1);
        //}


        //if (GMScript1.cowMilk < 2)
        //{
        //    yogurtText.color = new Color(1, 0.6f, 0.6f);
        //    yogurt.color = new Color(yogurt.color.r, yogurt.color.g, yogurt.color.b, 0.6f);
        //}
        //else
        //{
        //    yogurtText.color = Color.white;
        //    yogurt.color = new Color(yogurt.color.r, yogurt.color.g, yogurt.color.b, 1);
        //}

    }
}
