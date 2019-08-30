using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_firepos : MonoBehaviour
{

    //위에서 돌 비가 떨어지는 장소
    //돌 소환 장

    public float speed = 10;

    public GameObject bullet;
    public Transform firePos;

    public float del_time = 1f;

    private float count_time = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = speed * Time.deltaTime;
        transform.Translate(-moveX, 0, 0);

        Fire();
        count_time += Time.deltaTime;

        if (count_time >= del_time)
        {
            count_time = 0f;

        }

    }

    void Fire()
    {
        if (count_time == 0f)
        {

            Instantiate(bullet, firePos.position, firePos.rotation);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    //rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
    //Collider2D other로 부딪힌 객체를 받아옵니다.
    {
        if (other.gameObject.tag.Equals("Ground"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            Destroy(this.gameObject);

        }
    }
}
