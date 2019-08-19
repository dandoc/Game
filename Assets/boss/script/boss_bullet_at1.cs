using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_bullet_at1 : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject damage_effect;
    public Transform firePos;
    public float time = 0f;
    public int damage = 10;
    public float speed = 10;
    public float DestroyTime = 2f;
    public float del_time = 1f; // 딜레이 시간 설정 값
    private float count_time = 0f;

    private void Update()
    {
        float moveX = speed * Time.deltaTime;
        transform.Translate(-moveX, 0, 0);
        Destroy(this.gameObject, 3f);
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
            Instantiate(explosionPrefab, this.transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            Instantiate(damage_effect, firePos.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}