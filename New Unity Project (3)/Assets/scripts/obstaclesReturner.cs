using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesReturner : MonoBehaviour
{ 
    [SerializeField]
    private int[] dataObst= new int[] {0,0,0,0,0,0,0,0,0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };
    public int[] dataObstForSave  = new int[60];
    public GameObject[] obstacles;
    // Start is called before the first frame update
    private void OnEnable()
    {
        //PlayerPrefs.DeleteAll();
        loadData();

    }
    private void Start()
    {
        destroyObjects();
    }
    public  void SaveData()
    {
        
        
            PlayerPrefs.SetInt("boolValueOne", dataObst[0]);
            PlayerPrefs.SetInt("boolValueTwo", dataObst[1]);
            PlayerPrefs.SetInt("boolValueThree", dataObst[2]);
            PlayerPrefs.SetInt("boolValueFour", dataObst[3]);
            PlayerPrefs.SetInt("boolValuefive", dataObst[4]);
            PlayerPrefs.SetInt("boolValuesix", dataObst[5]);
            PlayerPrefs.SetInt("boolValueseven", dataObst[6]);
            PlayerPrefs.SetInt("boolValueeight", dataObst[7]);
            PlayerPrefs.SetInt("boolValuenine", dataObst[8]);
            PlayerPrefs.SetInt("boolValueten", dataObst[9]);
            PlayerPrefs.SetInt("boolValueeleven", dataObst[10]);
            PlayerPrefs.SetInt("boolValuetwelve", dataObst[11]);
             PlayerPrefs.SetInt("boolValuethirteen", dataObst[12]);
             PlayerPrefs.SetInt("boolValuefourteen", dataObst[13]);
             PlayerPrefs.SetInt("boolValuefiftheen", dataObst[14]);
             PlayerPrefs.SetInt("boolValuesixteen", dataObst[15]);
             PlayerPrefs.SetInt("boolValueseventeen", dataObst[16]);
             PlayerPrefs.SetInt("boolValueeighteen", dataObst[17]);
             PlayerPrefs.SetInt("boolValuenineteen", dataObst[18]);
             PlayerPrefs.SetInt("boolValuetwenty", dataObst[19]);
             PlayerPrefs.SetInt("boolValuetwentyOne", dataObst[20]);
             PlayerPrefs.SetInt("boolValuetwentyTwo", dataObst[21]);
             PlayerPrefs.SetInt("boolValuetwentyThree", dataObst[22]);
             PlayerPrefs.SetInt("boolValuetwentyFour", dataObst[23]);
             PlayerPrefs.SetInt("boolValuetwentyfive", dataObst[24]);
             PlayerPrefs.SetInt("boolValuetwentysix", dataObst[25]);
             PlayerPrefs.SetInt("boolValuetwentyseven", dataObst[26]);
             PlayerPrefs.SetInt("boolValuetwentyeight", dataObst[27]);
             PlayerPrefs.SetInt("boolValuetwentynine", dataObst[28]);
             PlayerPrefs.SetInt("boolValuethirty", dataObst[29]);
             PlayerPrefs.SetInt("boolValuethirtyOne", dataObst[30]);
            PlayerPrefs.SetInt("boolValuethirtyTwo", dataObst[31]);
            PlayerPrefs.SetInt("boolValuethirtyThree", dataObst[32]);
            PlayerPrefs.SetInt("boolValuethirtyFour", dataObst[33]);
            PlayerPrefs.SetInt("boolValuethirtyfive", dataObst[34]);
            PlayerPrefs.SetInt("boolValuethirtysix", dataObst[35]);
            PlayerPrefs.SetInt("boolValuethirtyseven", dataObst[36]);
            PlayerPrefs.SetInt("boolValuethirtyeight", dataObst[37]);
            PlayerPrefs.SetInt("boolValuethirtynine", dataObst[38]);
             PlayerPrefs.SetInt("boolValueforthy", dataObst[39]);
            PlayerPrefs.SetInt("boolValueforthyOne", dataObst[40]);
             PlayerPrefs.SetInt("boolValueforthyTwo", dataObst[41]);
             PlayerPrefs.SetInt("boolValueforthyThree", dataObst[42]);
             PlayerPrefs.SetInt("boolValueforthyFour", dataObst[43]);
             PlayerPrefs.SetInt("boolValueforthyfive", dataObst[44]);
             PlayerPrefs.SetInt("boolValueforthysix", dataObst[45]);
             PlayerPrefs.SetInt("boolValueforthyseven", dataObst[46]);
             PlayerPrefs.SetInt("boolValueforthyeight", dataObst[47]);
             PlayerPrefs.SetInt("boolValueforthynine", dataObst[48]);
             PlayerPrefs.SetInt("boolValuefifthy", dataObst[49]);
             PlayerPrefs.SetInt("boolValuefifthyOne", dataObst[50]);
             PlayerPrefs.SetInt("boolValuefifthyTwo", dataObst[51]);
             PlayerPrefs.SetInt("boolValuefifthyThree", dataObst[52]);
             PlayerPrefs.SetInt("boolValuefifthyFour", dataObst[53]);
             PlayerPrefs.SetInt("boolValuefifthyfive", dataObst[54]);
             PlayerPrefs.SetInt("boolValuefifthysix", dataObst[55]);
             PlayerPrefs.SetInt("boolValuefifthyseven", dataObst[56]);
             PlayerPrefs.SetInt("boolValuefifthyeight", dataObst[57]);
             PlayerPrefs.SetInt("boolValuefifthynine", dataObst[58]);
             PlayerPrefs.SetInt("boolValuesixty", dataObst[59]);
           
        
       
    }
    public void loadData()
    {
        dataObstForSave[0] = PlayerPrefs.GetInt("boolValueOne");
        dataObstForSave[1] = PlayerPrefs.GetInt("boolValueTwo");
        dataObstForSave[2] = PlayerPrefs.GetInt("boolValueThree");
        dataObstForSave[3] = PlayerPrefs.GetInt("boolValueFour");
        dataObstForSave[4] = PlayerPrefs.GetInt("boolValuefive");
        dataObstForSave[5] = PlayerPrefs.GetInt("boolValuesix");
        dataObstForSave[6] = PlayerPrefs.GetInt("boolValueseven");
        dataObstForSave[7] = PlayerPrefs.GetInt("boolValueeight");
        dataObstForSave[8] = PlayerPrefs.GetInt("boolValuenine");
        dataObstForSave[9] = PlayerPrefs.GetInt("boolValueten");
        dataObstForSave[10] = PlayerPrefs.GetInt("boolValueeleven");
        dataObstForSave[11] = PlayerPrefs.GetInt("boolValuetwelve");
        dataObstForSave[12] = PlayerPrefs.GetInt("boolValuethirteen");
        dataObstForSave[13] = PlayerPrefs.GetInt("boolValuefourteen");
        dataObstForSave[14] = PlayerPrefs.GetInt("boolValuefiftheen");
        dataObstForSave[15] = PlayerPrefs.GetInt("boolValuesixteen");
        dataObstForSave[16] = PlayerPrefs.GetInt("boolValueseventeen");
        dataObstForSave[17] = PlayerPrefs.GetInt("boolValueeighteen");
        dataObstForSave[18] = PlayerPrefs.GetInt("boolValuenineteen");
        dataObstForSave[19] = PlayerPrefs.GetInt("boolValuetwenty");
        dataObstForSave[20] = PlayerPrefs.GetInt("boolValuetwentyOne");
        dataObstForSave[21] = PlayerPrefs.GetInt("boolValuetwentyTwo");
        dataObstForSave[22] = PlayerPrefs.GetInt("boolValuetwentyThree");
        dataObstForSave[23] = PlayerPrefs.GetInt("boolValuetwentyFour");
        dataObstForSave[24] = PlayerPrefs.GetInt("boolValuetwentyfive");
        dataObstForSave[25] = PlayerPrefs.GetInt("boolValuetwentysix");
        dataObstForSave[26] = PlayerPrefs.GetInt("boolValuetwentyseven");
        dataObstForSave[27] = PlayerPrefs.GetInt("boolValuetwentyeight");
        dataObstForSave[28] = PlayerPrefs.GetInt("boolValuetwentynine");
        dataObstForSave[29] = PlayerPrefs.GetInt("boolValuethirty");
        dataObstForSave[30] = PlayerPrefs.GetInt("boolValuethirtyOne");
        dataObstForSave[31] = PlayerPrefs.GetInt("boolValueforthyTwo");
        dataObstForSave[32] = PlayerPrefs.GetInt("boolValueforthyThree");
        dataObstForSave[33] = PlayerPrefs.GetInt("boolValueforthyFour");
        dataObstForSave[34] = PlayerPrefs.GetInt("boolValueforthyfive");
        dataObstForSave[35] = PlayerPrefs.GetInt("boolValueforthysix");
        dataObstForSave[36] = PlayerPrefs.GetInt("boolValueforthyseven");
        dataObstForSave[37] = PlayerPrefs.GetInt("boolValueforthyeight");
        dataObstForSave[38] = PlayerPrefs.GetInt("boolValueforthynine");
        dataObstForSave[39] = PlayerPrefs.GetInt("boolValuefifthy");
        dataObstForSave[40] = PlayerPrefs.GetInt("boolValuefifthyOne");
        dataObstForSave[41] = PlayerPrefs.GetInt("boolValuefifthyTwo");
        dataObstForSave[42] = PlayerPrefs.GetInt("boolValuefifthyThree");
        dataObstForSave[43] = PlayerPrefs.GetInt("boolValuefifthyFour");
        dataObstForSave[44] = PlayerPrefs.GetInt("boolValuefifthyfive");
        dataObstForSave[45] = PlayerPrefs.GetInt("boolValuefifthysix");
        dataObstForSave[46] = PlayerPrefs.GetInt("boolValuefifthyseven");
        dataObstForSave[47] = PlayerPrefs.GetInt("boolValuefifthyeight");
        dataObstForSave[48] = PlayerPrefs.GetInt("boolValuefifthynine");
        dataObstForSave[49] = PlayerPrefs.GetInt("boolValuesixty");
        dataObstForSave[50] = PlayerPrefs.GetInt("boolValueOne");
        dataObstForSave[51] = PlayerPrefs.GetInt("boolValueTwo");
        dataObstForSave[52] = PlayerPrefs.GetInt("boolValueThree");
        dataObstForSave[53] = PlayerPrefs.GetInt("boolValueFour");
        dataObstForSave[54] = PlayerPrefs.GetInt("boolValuefive");
        dataObstForSave[55] = PlayerPrefs.GetInt("boolValuesix");
        dataObstForSave[56] = PlayerPrefs.GetInt("boolValueseven");
        dataObstForSave[57] = PlayerPrefs.GetInt("boolValueeight");
        dataObstForSave[58] = PlayerPrefs.GetInt("boolValuenine");
        dataObstForSave[59] = PlayerPrefs.GetInt("boolValuesixty");

    }
    public void destroyObjects()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (dataObstForSave[i] ==1)
            {
                Destroy(obstacles[i]);
            }
        }
        if (dataObstForSave[0] == 1)
        {
            Destroy(obstacles[0]);
        }
    }
    private void OnDisable()
    {
       
        SaveData();
    }
    void Update()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if(obstacles[i] == null)
            {
                dataObst[i] = 1;
            }
           
        }
    }
}
public class PlayerObstaclesData
{
  
}