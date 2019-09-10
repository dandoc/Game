using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    public float del_time;
    private bool flag;

    private float count_time = 0f;

    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && !flag)
        {
            Fire();
            flag = true;
        }

        if(flag == true)
        {
            count_time += Time.deltaTime;
            if (count_time >= del_time)
            {
                count_time = 0;
                flag = false;
                
            }
        }
    }

    void Fire()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);

    }
}
