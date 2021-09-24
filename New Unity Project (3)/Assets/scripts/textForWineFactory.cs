using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textForWineFactory : MonoBehaviour
{

    public Text firstItemText;
    public Text secondImageText;
    public Text thirdImageText;

    public Image firstImage;
    public Image secondImage;
    public Image thirdImage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        firstItemText.text = (GMScript1.grape + " / 3  " ).ToString();
        secondImageText.text = (GMScript1.whiteGrape + " / 3 " ).ToString();
        thirdImageText.text = (GMScript1.pinkGrape + " / 3 " ).ToString();

        if (GMScript1.grape < 3) 
        {
            firstItemText.color = new Color(1, 0.6f, 0.6f);
            firstImage.color = new Color(firstImage.color.r, firstImage.color.g, firstImage.color.b, 0.6f);
        }
        else
        {
            firstItemText.color = Color.white;
            firstImage.color = new Color(firstImage.color.r, firstImage.color.g, firstImage.color.b, 1f);
        }


        if (GMScript1.whiteGrape < 3) 
        {
            secondImageText.color = new Color(1, 0.6f, 0.6f);
            secondImage.color = new Color(secondImage.color.r, secondImage.color.g, secondImage.color.b, 0.6f);
        }
        else
        {
            secondImageText.color = Color.white;
            secondImage.color = new Color(secondImage.color.r, secondImage.color.g, secondImage.color.b, 1);
        }


        if (GMScript1.pinkGrape < 3) 
        {
            thirdImageText.color = new Color(1, 0.6f, 0.6f);
            thirdImage.color = new Color(thirdImage.color.r, thirdImage.color.g, thirdImage.color.b, 0.6f);
        }
        else
        {
            thirdImageText.color = Color.white;
            thirdImage.color = new Color(thirdImage.color.r, thirdImage.color.g, thirdImage.color.b, 1);
        }

    }
}
