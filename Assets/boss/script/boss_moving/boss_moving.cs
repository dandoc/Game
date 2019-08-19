using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_moving : MonoBehaviour
{
    public float movepower = 1f;

    public Animator anim;
    Vector3 movement;
    int movementFlag = 0;
    public bool[] info = new bool[10];

    Random r = new Random();

    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        info[0] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at1");
        info[1] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at2");
        info[2] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at3");
    }

    private void Update()
    {
        info[0] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at1");
        info[1] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at2");
        info[2] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at3");




        if (Input.GetKey(KeyCode.J))
        {
            anim.SetTrigger("at1");
        }
        if (Input.GetKey(KeyCode.K))
        {
            anim.SetTrigger("at2");
        }
        if (Input.GetKey(KeyCode.L))
        {
            anim.SetTrigger("at3");
        }
    }
}
