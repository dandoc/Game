using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_attack : MonoBehaviour
{
    public bool at2_TF = false;
    public int a = 0;

    public GameObject bullet;
    public Transform firePos;
    private void Start()
    {

    }

    private void Update()
    {
        //Debug.Log(GameObject.Find("boss_no.4").GetComponent<boss_moving>().info[0]);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Ground"))
        {
            if (GameObject.Find("boss_no.4").GetComponent<movement>().info[1])
            {
                Instantiate(bullet, firePos.transform.position, Quaternion.identity);
            }
            else if (GameObject.Find("boss_no.4").GetComponent<movement>().info[3])
            {
                Instantiate(bullet, firePos.transform.position, Quaternion.identity);
                plus();
                at2_TF = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (GameObject.Find("boss_no.4").GetComponent<movement>().info[1])
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