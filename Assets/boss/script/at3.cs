using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class at3 : MonoBehaviour
{
    //보스 오른쪽 팔이 땅에 충돌할 경우 한번 firepos_sky에서 boss_firepos를 발public GameObject bullet;
    public bool at3_TF = false;
    public int a = 0;
    private void Update()
    {
        Debug.Log("a, "+a);
        Debug.Log("TF, "+GameObject.Find("boss_no.4").GetComponent<boss_moving>().info[2]);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.Find("boss_no.4").GetComponent<boss_moving>().info[2])
        {
            if (other.gameObject.tag.Equals("Ground"))
            {
                plus();
                at3_TF = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (GameObject.Find("boss_no.4").GetComponent<boss_moving>().info[2])
        {
            if (other.gameObject.tag.Equals("Ground"))
            {
                at3_TF = false;
            }
        }
    }
    public void plus()
    {
        a++;
    }
}
