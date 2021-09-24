using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class layerSorter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)(transform.position.y * -10);
        //this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)(transform.position.x * transform.position.y * -5);
    }
}
