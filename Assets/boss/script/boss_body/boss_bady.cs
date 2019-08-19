using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_bady : MonoBehaviour
{

    private void Start()
    {
        anim = GetComponent<Animator>();

    }


    public float HP = 100;
    private Animator anim;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            anim.SetTrigger("die");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    //rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
    //Collider2D other로 부딪힌 객체를 받아옵니다.
    {
        if (other.gameObject.tag.Equals("Bullet"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            HP = HP - 1;
            Debug.Log(HP);

        }
    }


}
