using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_body : MonoBehaviour
{
    public GameObject traceTarget;



    private void Start()
    {
        anim = GetComponent<Animator>();

    }


    public float HP = 100;
    private Animator anim;


    void Update()
    {
        if (HP <= 0)
        {
            anim.SetTrigger("die");
        }

        if(HP <= 80)
        {
            moving();
        }

        //타겟으로 하여 플레이어 쪽으로 몸 돌림
        Vector3 playerPos = traceTarget.transform.position;

        if(playerPos.x < transform.position.x)
        {
            transform.localScale = new Vector3(2, 2, 1);

        }

        else if(playerPos.x > transform.position.x)
        {
            transform.localScale = new Vector3(-2, 2, 1);
        }

    }

    void moving()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    //rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
    //Collider2D other로 부딪힌 객체를 받아옵니다.
    {
        if (other.gameObject.tag.Equals("Bullet"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            HP = HP - 1;
            Debug.Log("boss HP : ");
            Debug.Log(HP);

        }
    }


}
