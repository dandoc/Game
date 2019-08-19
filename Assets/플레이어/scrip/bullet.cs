using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject explosionPrefab;

    public Transform bullets;

    public float time = 0f;

    public int damage = 10;

    public float speed = 2;

    public float DestroyTime = 0.03f;

   
    void Start()
    {
        
	}

    private void Update()
    {
        float moveX = speed * Time.deltaTime;
        transform.Translate(moveX, 0, 0);
        time += Time.deltaTime;
        if (time >= 0.8f)
        {
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
        }
        Destroy(this.gameObject, DestroyTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    //rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
    //Collider2D other로 부딪힌 객체를 받아옵니다.
    {
        if (other.gameObject.tag.Equals("Ground") || other.gameObject.tag.Equals("Enemy"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            //자신을 파괴합니다.
        }
    }




}
