using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showToolToRemoveObstacle : MonoBehaviour
{
    public GameObject uiToDestroyObstacle;
    private void OnMouseDown()
    {
       
        StartCoroutine(waitBeforeStop());
    }
    IEnumerator waitBeforeStop()
    {
        uiToDestroyObstacle.SetActive(true);
        yield return new WaitForSeconds(3);

        uiToDestroyObstacle.SetActive(false);
    }
}
