using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_at2 : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.Find("오").GetComponent<new_boss_at2>().a % 2 == 0)
        {
            if (GameObject.Find("오").GetComponent<new_boss_at2>().at2_TF)
            {
                Fire();
            }
        }
    }

    void Fire()
    {

        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
}
