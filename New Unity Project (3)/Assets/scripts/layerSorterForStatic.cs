using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerSorterForStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)(transform.position.y * -10);
        //this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)(transform.position.x * transform.position.y * -5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
