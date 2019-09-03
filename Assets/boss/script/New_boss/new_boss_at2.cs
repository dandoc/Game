using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_boss_at2 : MonoBehaviour
{
 
    public bool at2_TF;
    public int a;

    void Update()
    {
        at2_TF = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.Find("boss_no.4").GetComponent<movement>().info[2] || GameObject.Find("boss_no.4").GetComponent<movement>().info[3])
        {
            if (other.gameObject.tag.Equals("Ground"))
            {
                at2_TF = true;
                a++;
            }
        }
    }
}
