using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_at3 : MonoBehaviour
{

    public float movepower = 20f;
    private Animator animator;
    Vector3 movement;
    public Transform Player_position;

    Vector3 dir;

    bool at3 = false;

    bool angle_L = false;

    bool angle_R = false;

    bool at3_move_R = false;
    bool at3_move_L = false;

    int count = 0;
    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.L))
        {
            at3 = false;
            animator.SetBool("at3", false);
            angle_L = false;
            angle_R = false;
        }

        Debug.Log(count);
    }


    private void FixedUpdate()
    {
        Vector3 dir = Player_position.position - transform.position; //if(dir == +){오른쪽}  else if(dir == -){왼쪽}
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        if (count >= 18 & count <= 21)
        {
            at3 = true;

            if (angle < 0)
            {
                at3_move_L = true;
                at3_move_R = false;
            }

            else if (angle > 0)
            {
                at3_move_L = false;
                at3_move_R = true;
            }
            if (count >= 18 & count <= 21)
            {
                count += 4;
            }
        }

        if (at3 == true)
        {
            Move();

        }
    }
    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (at3_move_L == true)
        {
            moveVelocity = Vector3.left;
            animator.SetBool("at3", true);
        }

        else if (at3_move_R == true)
        {
            moveVelocity = Vector3.right;
            animator.SetBool("at3", true);
        }
        transform.position += moveVelocity * movepower * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Ground"))
        {
            at3 = false;
            animator.SetBool("at3", false);
            angle_L = false;
            angle_R = false;
            at3_move_R = false;
            at3_move_L = false;
            count += 1;

            if (count >= 24)
            {
                count = 0;

            }
        }
    }
}

