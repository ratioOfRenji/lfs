using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colllisionCheck : MonoBehaviour
{
    public static bool colision;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        colision = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        colision = false;
    }
}
