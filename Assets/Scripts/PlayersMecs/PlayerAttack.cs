using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator anim;

    public AudioManager audio;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        //Play hurt animation

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Animaçao de ataque
        anim.SetTrigger("Attack");
        
        audio.Play("swipe");
        //Detect enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyScript>().TakeDamage();
        }
    }

    void Die()
    {
        Debug.Log("Dead");

        //Death animation        

        this.gameObject.SetActive(false);
    }

    private void OnDrawGizmos()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Ondas")
        {
            TakeDamage(10);
        }
    }
}