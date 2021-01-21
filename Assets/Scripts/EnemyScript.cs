using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Animator anim;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    int damageReceived = 10;

    int damageDealt;

    void Start()
    {
        this.damageDealt = 10;
        this.enabled = true;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage()
    {
        currentHealth -= damageReceived;

        healthBar.SetHealth(currentHealth);

        //Play hurt animation

        if (currentHealth <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Dead");

        //Death animation        

        Destroy(this.gameObject);
    }
}
