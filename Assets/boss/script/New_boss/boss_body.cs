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
    void Update()
    {
        if (HP <= 0)
        {
            anim.SetTrigger("die");
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
