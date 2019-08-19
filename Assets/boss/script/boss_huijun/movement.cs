using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Animator anim;

    private float timeSpan;  //경과 시간을 갖는 변수
    private float checkTime;  // 특정 시간을 갖는 변수

    public GameObject bullet;
    public Transform firePos;

    void Start()
    {
        anim = GetComponent<Animator>();
        timeSpan = 0.0f;
        checkTime = 5.0f;  // 특정시간을 5초로 지정
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            at1();
        }
    }
    private void at1()
    {
        anim.SetTrigger("at1");
    }

    private void at2()
    {

    }

    private void at3() // at1+at2
    {

    }
}