using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woolTeleporter : MonoBehaviour
{
    public GameObject Galothka;
    public GameObject wool;
    public GameObject nitki;
    public Transform teleportTarget1;
    public Transform teleportTarget2;

    public void woolTeleportator()
    {
        wool.transform.position = teleportTarget1.transform.position;
        nitki.transform.position = teleportTarget2.transform.position;
    }
}
