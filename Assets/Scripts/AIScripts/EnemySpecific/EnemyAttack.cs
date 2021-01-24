using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float timeBetweenAttacks = 0.5f, timer;
    public GameObject player;
    public Animator anim;
    float distance = 2f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        MovementAnimation();
        timer += Time.deltaTime;
        bool attack = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Program>().attack;

        if (timer >= timeBetweenAttacks && attack == true)
        {
            Attack();
        }
        else
        {

        }
    }

    void Attack()
    {
        timer = 0;
        //Run animation

        //if()
        if (player.GetComponentInChildren<PlayerAttack>().currentHealth > 0)
        {
            anim.SetTrigger("Attack");
            player.GetComponentInChildren<PlayerAttack>().currentHealth -= 10;
            player.GetComponentInChildren<HealthBar>().slider.value -= 10;
        }
        else if(player.GetComponentInChildren<PlayerAttack>().currentHealth <= 0)
        {
            Destroy(player);
        }
    }

    void MovementAnimation()
    {
        bool moving = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Program>().following;

        if (moving == true)
        {
            anim.SetBool("Moving", true);
        }
        else anim.SetBool("Moving", false);
    }
}
