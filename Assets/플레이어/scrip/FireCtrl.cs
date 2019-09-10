using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    public float del_time;

    private float count_time = 0f;
    private bool flag;
   
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            count_time += Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.X) && flag == false)
        {
            flag = true;
            Fire();
        }

        if(count_time >= del_time)
        {
            count_time = 0f;
            flag = false;
        
        }
    }

    void Fire()
    {
        if(flag)
        {

            Instantiate(bullet, firePos.position, firePos.rotation);

        }

    }
}
