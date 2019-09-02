using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator anim;
    public bool[] info = new bool[10];
    public bool at_flag;

    private float count_Time = 0;

    [SerializeField]
    private float at_Time;
    private int ran;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        info[0] = anim.GetCurrentAnimatorStateInfo(0).IsTag("idle");
        info[1] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at1");
        info[2] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at2");
        info[3] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at3");
        at_flag = false;
    }

    void Update()
    {
        Debug.Log("at_type: " + ran);
        //Debug.Log("time: " + count_Time);
        info[0] = anim.GetCurrentAnimatorStateInfo(0).IsTag("idle");
        info[1] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at1");
        info[2] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at2");
        info[3] = anim.GetCurrentAnimatorStateInfo(0).IsTag("at3");

        if (info[0])
        {
            count_Time += Time.deltaTime;
            
        }

        if (count_Time >= at_Time)
        {
            ran = Random.RandomRange(1, 5);
            //ran = 1;

            if (ran == 1) at1();
            else if (ran == 2) at2();
            else if (ran == 3) at3();
            //else if (ran == 4) at4();

            count_Time = 0;
        }
    }
    private void at1() { anim.SetTrigger("at1"); }
    private void at2() { anim.SetTrigger("at2"); }
    private void at3() { anim.SetTrigger("at3"); }
    private void at4() { anim.SetTrigger("at4"); }



    //    if (!info[0] && !info[1] && !info[2])
    //    {
    //        at_flag = false;
    //    }
    //    if (!at_flag)
    //    {
    //if (count_Time >= at_Time)
    //        {
    //            ran = Random.RandomRange(0, 3);
    //            count_Time = 0;
    //            at_flag = true;

    //        }
    //        else
    //        {
    //            count_Time += Time.deltaTime;
    //        }
    //    }
    //    if (at_flag)
    //    {
    //if (ran == 0) at1();
    //else if (ran == 1) at2();
    //else if (ran == 2) at3();
    //        //랜덤으로 뽑아내서 어찌저찌 한다.
    //    }
}