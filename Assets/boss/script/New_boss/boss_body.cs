using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_body : MonoBehaviour
{

    private void Start()
    {
        anim = GetComponent<Animator>();

    }
    public float HP = 100;
    private Animator anim;
    bool flag = true;
    void Update()
    {
        if (HP <= 0)
        {
            if (flag)
            {
                anim.SetTrigger("z");
                flag = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Bullet"))
        {
            HP = HP - 1;
            Debug.Log(HP);
        }
    }
}
