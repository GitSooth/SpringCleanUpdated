using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float distance;
    float timeBetweenAttacks = 0.5f, timer;
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
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

        if (player.GetComponentInChildren<PlayerAttack>().currentHealth > 0)
        {
            player.GetComponentInChildren<PlayerAttack>().currentHealth -= 10;
            player.GetComponentInChildren<HealthBar>().slider.value -= 10;
        }
        else if(player.GetComponentInChildren<PlayerAttack>().currentHealth <= 0)
        {
            Destroy(player);
        }
    }
}
