using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colidersDisabler : MonoBehaviour
{
    public Component[] circleColiders;

    void Start()
    {
        
    }
    public void ColiderDisaibler()
    {
        circleColiders = GetComponentsInChildren<CircleCollider2D>();

        foreach (CircleCollider2D coliderToDisable in circleColiders)
            coliderToDisable.enabled = false;
    }

    public void ColiderEnaibler()
    {
        circleColiders = GetComponentsInChildren<CircleCollider2D>();

        foreach (CircleCollider2D coliderToDisable in circleColiders)
            coliderToDisable.enabled = true;
    }
}
