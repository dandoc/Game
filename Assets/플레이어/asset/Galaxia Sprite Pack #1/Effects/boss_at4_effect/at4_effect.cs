using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class at4_effect_1 : MonoBehaviour
{
    private float count_Time = 0;

    void Start()
    {


    }

    void Update()
    {
        transform.localScale = new Vector3(0, 0, 0);

        count_Time += Time.deltaTime;
        if(count_Time >= 0.4)
        {

            Destroy(this.gameObject);

        }


    }

}
