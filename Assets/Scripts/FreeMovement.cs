using UnityEngine;

public class FreeMovement : MonoBehaviour
{
    public float moveSpeed;
    public float maxSpeed = 5f;
    public float impulseStrength = 1f;
    public float pushStrength = 2f;

    public float attackRange = 0.5f;
    public float pushRange = 0.5f;
    public LayerMask enemyLayers;

    public AudioManager audio;
    public Animator anim;
    public Transform player;
    public Transform attack;
    public Transform attackAnchor;

    private void Start()
    {
        moveSpeed = 0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            moveSpeed = maxSpeed;
            player.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = attackAnchor.position;
            player.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveSpeed = maxSpeed;
            player.position -= new Vector3(-Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, 0.0f);
            attack.transform.position = attackAnchor.position;
            player.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveSpeed = maxSpeed;
            player.position += new Vector3(0.0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed = maxSpeed;
            player.position -= new Vector3(0.0f, -Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0.0f);

        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            moveSpeed = 0f;
        }

        if (moveSpeed > 0)
        {
            anim.SetBool("Moving", true);
            audio.Play("feet");
        }

        else anim.SetBool("Moving", false);
        audio.Stop("feet");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }

        if (Input.GetKey(KeyCode.L))
        {
            PushAway();
        }
    }

    void Dash()
    {
        anim.SetTrigger("Dash");
        Vector3 newPos = player.position;
        if (Input.GetKey(KeyCode.W))
            newPos.y += impulseStrength;
        if (Input.GetKey(KeyCode.A))
            newPos.x -= impulseStrength;
        if (Input.GetKey(KeyCode.D))
            newPos.x += impulseStrength;
        if (Input.GetKey(KeyCode.S))
            newPos.y -= impulseStrength;

        player.position = newPos;
    }

    void PushAway()
    {
        Collider2D[] pushEnemies = Physics2D.OverlapCircleAll(player.position, pushRange, enemyLayers);

        foreach(Collider2D enemy in pushEnemies)
        {
            Vector3 direction = player.position - enemy.transform.position;

            direction.Normalize();

            enemy.transform.position += direction * pushStrength;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(player.position, pushRange);
    }
}