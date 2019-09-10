using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_at4 : MonoBehaviour
{
    public Transform firePos_at4_effect_1;
    public Transform firePos_at4_effect_2;
    public GameObject at4_effect_1;
    public GameObject at4_effect_2;

    bool at4_attack;
    private float count_Time = 0;
 

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("at4"))
        {
            at4_attack = true;

            count_Time += Time.deltaTime;

            if (at4_attack)
            {
                Instantiate(at4_effect_1, firePos_at4_effect_1.transform.position, Quaternion.identity);
                if (count_Time >= 0.03)
                {
                    Instantiate(at4_effect_2, firePos_at4_effect_2.transform.position, Quaternion.identity);
                    at4_attack = false;
                }
                at4_attack = false;
            }

        }
    }

    void Start()
    {
        
    }
}
