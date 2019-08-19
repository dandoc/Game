using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;

    public float del_time = 0.001f;

    private float count_time = 0f;

   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            Fire();
            count_time += Time.deltaTime;
  
        }

        if(count_time >= del_time)
        {
            count_time = 0f;
        
        }
    }

    void Fire()
    {
        if(count_time == 0f)
        {

            Instantiate(bullet, firePos.position, firePos.rotation);

        }

    }
}
