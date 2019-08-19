using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class at_3_clone : MonoBehaviour
{
    public float speed = 10;
    public GameObject bullet;
    public Transform firePos;

    public float del_time;

    public float count_time = 0f;
    public bool flag = false;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameObject.Find("왼").GetComponent<at3>().a % 2 == 1)
        {
            if (GameObject.Find("왼").GetComponent<at3>().at3_TF)
            {
                count_time += Time.deltaTime;
            }
            else if (!GameObject.Find("왼").GetComponent<at3>().at3_TF)
            {
                count_time = 0;
            }
            if (count_time >= del_time)
            {
                Debug.Log(count_time);
                Fire();
                count_time = 0f;
            }
        }
    }

    void Fire()
    {

        Instantiate(bullet, firePos.position, firePos.rotation);

    }
}
