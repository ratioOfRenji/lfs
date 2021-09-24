using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Transform[] moveSpots;
    private int randomSpot;
    private float waitTime;
    public float startWaitTime;
    private bool needToFlip;
    public Sprite normal;
    public Sprite fliped;
    public Transform animal;
    public GameObject animalImage;
    public Animator anim;
    private bool idleState;
    public GameObject head;
    public Sprite head1;
    public Sprite head2;

    // Start is called before the first frame update
    void Start()
    {
        
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
               
            }
        }
        if(this.gameObject.transform.position.x > moveSpots[randomSpot].position.x) 
        {
            // animalImage.GetComponent<SpriteRenderer>().sprite = fliped;
            anim.Play("sheep animation");

        }
        if (this.gameObject.transform.position.x < moveSpots[randomSpot].position.x)
        {
            // animalImage.GetComponent<SpriteRenderer>().sprite = normal;
            anim.Play("sheep animation flipped");
        }
        if (this.gameObject.transform.position.x == moveSpots[randomSpot].position.x)
        {
            anim.Play("idle 2");
        }
    }

}
