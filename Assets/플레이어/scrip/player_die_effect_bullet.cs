using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_die_effect_bullet : MonoBehaviour
{
    private float time;

    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1)
        {
            Destroy(this.gameObject);
        }


    }
}
