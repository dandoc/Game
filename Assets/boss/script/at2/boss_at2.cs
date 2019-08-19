using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_at2 : MonoBehaviour
{
    //보스 오른쪽 팔이 땅에 충돌할 경우 한번 firepos_sky에서 boss_firepos를 발public GameObject bullet;
    public bool at2_TF = false;
    public int a = 0;
    private void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.Find("boss_no.4").GetComponent<boss_moving>().info[1])
        {
            if (other.gameObject.tag.Equals("Ground"))
            {
                plus();
                at2_TF = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (GameObject.Find("boss_no.4").GetComponent<boss_moving>().info[1])
        {
            if (other.gameObject.tag.Equals("Ground"))
            {
                at2_TF = false;
            }
        }
    }
    public void plus()
    {
        a++;
    }
}

