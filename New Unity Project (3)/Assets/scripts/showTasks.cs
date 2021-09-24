using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTasks : MonoBehaviour
{
    public GameObject tasksUi;



    private float lastClickTime;
    private const float DOubleClick = 0.2f;

    private void OnMouseUp()
    {

        if (gameObject.name == "доска объявлений")
        {
            
            


               

                 tasksUi.SetActive(true);
                
               
            
        }
    }
}
