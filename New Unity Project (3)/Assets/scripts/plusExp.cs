using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusExp : MonoBehaviour
{
    public void plusExperience()
    {
        GMScript1.exp += 500;
    }
    public void plusGold()
    {
        GMScript1.money += 500;
    }
    public void plusCarrot()
    {
        GMScript1.carrotSeeds += 500;
    }
    public void plusJuice()
    {
        GMScript1.cherryJuice += 500;
    }
}
