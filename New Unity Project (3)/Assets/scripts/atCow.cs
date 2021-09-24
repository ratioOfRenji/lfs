using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atCow : MonoBehaviour
{
    public int walk = 1;
    public bool mustPatrol;

    private bool mustTurn;

    void Start()
    {


    }

    void Update()
    {


    }
    void FixedUpdate()

    {
        if (GMScript1.korovuPokormili2 == false)
        {
            transform.Translate(new Vector2(walk, 0) * Time.deltaTime);
        }

        {
            transform.Translate(new Vector2(0, 0) * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        Flip();


    }

    void Flip()
    {

        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walk *= -1;

    }
}
