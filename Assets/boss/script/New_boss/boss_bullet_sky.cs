using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_bullet_sky : MonoBehaviour
{
    public GameObject explosionPrefab;

	public GameObject damage_effect;

	public Transform firePos;

	public Transform firePos_1;

	public float speed = 1f;

    //하늘에서 떨어지는 보스 전용 돌에게 주는 스크립
    // 땅에 충돌하면 this Object 삭제 + 이펙트 생성_삭제 + 밑으로 돌이 떨어
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = speed * Time.deltaTime;
        transform.Translate(0, -moveX, 0);
    }
    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag.Equals("Ground"))
        //부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
        {
            Instantiate(explosionPrefab, firePos.transform.position, Quaternion.identity);
            Destroy(this.gameObject, 0.001f);


        }

        else if (other.gameObject.tag.Equals("Player"))
		//부딪힌 객체의 태그를 비교해서 적인지 판단합니다.
		{
			Instantiate(damage_effect, firePos_1.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
