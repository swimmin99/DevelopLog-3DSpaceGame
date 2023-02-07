using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class citizen_controller : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float range = 0.01f;
    public Vector2 moveSpot;
    public float speed = 0.1f;

    public Animator animator;

    public float waitTime;
    public float startwaitTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        moveSpot = new Vector2(UnityEngine.Random.Range(transform.position.x - range, transform.position.x + range), transform.position.y);
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, moveSpot) < 0.1f)
        {
            if (waitTime <= 0)
            {
              animator.SetBool("isMoving", true);
                moveSpot = new Vector2(UnityEngine.Random.Range(transform.position.x - range, transform.position.x + range), transform.position.y);
                waitTime = startwaitTime;
            }
            else
            {
                animator.SetBool("isMoving", false);
                waitTime -= Time.deltaTime;
            }


        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpot, speed * Time.deltaTime);
            if (moveSpot.x < transform.position.x)
                spriteRenderer.flipX = true;
            else
                spriteRenderer.flipX = false;
        }
    }
}
