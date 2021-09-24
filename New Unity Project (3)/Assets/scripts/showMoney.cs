
using UnityEngine;
using UnityEngine.UI;

public class showMoney : MonoBehaviour
{
    public Text moneyAmmount;
    public  Text expAmmount;
   

    void Update()
   {
        moneyAmmount.text = GMScript1.money.ToString();
        expAmmount.text = lvlMaster.currentLvl.ToString();
    }
}
