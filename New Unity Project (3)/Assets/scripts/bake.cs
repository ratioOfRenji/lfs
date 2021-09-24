using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bake : MonoBehaviour
{
    public GameObject Galothka;
    public GameObject wheat;
    public GameObject milk;
    public Transform teleportTarget1;
    public Transform teleportTarget2;

    public void bakeWheatBread()
    {
        wheat.transform.position = teleportTarget1.transform.position;
        milk.transform.position = teleportTarget2.transform.position;
    }
}
