using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private bool onGround;
    [SerializeField]
    Transform iniRay;
    private SpriteRenderer spr;
    private MovementBehaviour mvb;
    private NewControls nc;
    private FlipAndRotate far;
    private AudioSource audioSource;
    [SerializeField]
    private GameObject objectAnimation;
    private Animator magicAnimation;


    // Start is called before the first frame update
    void Start()
    {
        magicAnimation = objectAnimation.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        far = GetComponent<FlipAndRotate>();
        nc = GetComponent<NewControls>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
        mvb = GetComponent<MovementBehaviour>();

    }

    // Update is called once per frame
    void Update()
    {

        if (nc.moveValue < 0)
        {
            mvb.MoveRB2D(new Vector2(-1, rb.velocity.y));
            anim.SetInteger("State", 1);
            spr.flipX = false;
        }
        else if (nc.moveValue > 0)
        {
            mvb.MoveRB2D(new Vector2(1, rb.velocity.y));
            anim.SetInteger("State", 1);
            spr.flipX = true;
        }
        else
        {
            anim.SetInteger("State", 0);        }
        if (nc.moveValue ==0)
        {
            mvb.MoveRB2D(new Vector2(0,rb.velocity.y));
        }

        if (nc.jump)
        {
            far.FlipY();
             mvb.Jump();
            audioSource.Play();
            magicAnimation.SetTrigger("Gravity");
        }


/*        RaycastHit2D hit;
        Debug.DrawRay(iniRay.position, Vector2.down, Color.red, 0.05f);
        hit = Physics2D.Raycast(iniRay.position, Vector2.down, 0.05f);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.name.Contains("platform"))
            {
                onGround = true;
            }
            else
            {
                onGround = false;
            }                                                       
        }
        else
        {
            onGround = false;
        }*/

    }




}
