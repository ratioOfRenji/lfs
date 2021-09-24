using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class layerSorterAnimals : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = parent.GetComponent<SpriteRenderer>().sortingOrder + 10;
        //this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)(transform.position.x * transform.position.y * -5);
    }
}
