using UnityEngine;

public class ZombieShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float shootInterval = 2f;
    public float detectionRange = 5f;

    private Transform player;
    private float shootTimer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(
            transform.position,
            player.position
        );

        if (distance <= detectionRange)
        {
            shootTimer += Time.deltaTime;

            if (shootTimer >= shootInterval)
            {
                Shoot();
                shootTimer = 0f;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(
        bulletPrefab,
        firePoint.position,
        Quaternion.identity
    );

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(10f, 0f);
    }
}