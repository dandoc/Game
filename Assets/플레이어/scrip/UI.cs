using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;

    private player_1 player;
    private GameObject boss;
 
    private float maxHp=10;
    private float curHp=10;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player_no.1 3").GetComponent<player_1>();
        boss = GameObject.Find("boss_no.4");


        //maxHp = player.HP;
        curHp = player.HP;
        
        hpbar.value = (float)curHp / (float)maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        showHP();


    }

    public void showHP()
    {
        curHp = player.HP;
        hpbar.value = (float)curHp / (float)maxHp;
        Debug.Log(curHp);
    }

}