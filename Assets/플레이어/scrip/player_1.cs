using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1 : MonoBehaviour
{
    private Animator anim;
    [SerializeField] float scale;

    public float moveSpeed = 1f;
    public float jumpPower = 1f;

    Rigidbody2D rigid;

    Vector3 movement;
    bool isGrounnd;
    bool isJumping;

    [SerializeField] Transform pos;
    [SerializeField] float checkRadius;
    [SerializeField] LayerMask isLayer;

    public int jumpCount;
    int jumpCnt;

    public float HP = 10;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jumpCnt = jumpCount;
    }
    void Update()
    {
        jump();
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetBool("attack", true);
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            anim.SetBool("attack", false);
        }
    }

    private void FixedUpdate()
    {
        Move();
        float hor = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2(hor * 3, rigid.velocity.y);        
    }
    void jump()
    {
        isGrounnd = Physics2D.OverlapCircle(pos.position, checkRadius, isLayer);

        if (isGrounnd == true && Input.GetKeyDown(KeyCode.Z) && jumpCnt > 0)
        {
            rigid.velocity = Vector2.up * jumpPower;
        }
        if (isGrounnd == false && Input.GetKeyDown(KeyCode.Z) && jumpCnt > 0)
        {
            rigid.velocity = Vector2.up * jumpPower;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            jumpCnt--;
        }
        if (isGrounnd)
        {
            isJumping = false;
            jumpCnt = jumpCount;
        }
        else if (isGrounnd != true)
        {
            isJumping = true;
        }
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(-scale, scale, 0);
            if (isJumping == false)
            {
                anim.SetBool("move", true);
            }
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(scale, scale, 0);
            if (isJumping == false)
            {
                anim.SetBool("move", true);
            }
        }
        else if (Input.GetAxisRaw("Horizontal") == 0)
        {
            anim.SetBool("move", false);
        }
        transform.position += moveVelocity * moveSpeed * Time.deltaTime;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Enemy"))
        {
            HP -= 1;
            Debug.Log(HP);
        }
    }

}