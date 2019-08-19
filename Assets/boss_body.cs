using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_body : MonoBehaviour
{

    public float HP = 100f;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if( HP <= 0f)
        {
            anim.SetTrigger("die");

        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            HP = HP - 1f ;
            Debug.Log(HP);
        }
    }
}
