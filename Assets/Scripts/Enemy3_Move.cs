using UnityEngine;

public class Enemy3_Move : MonoBehaviour
{
    public Transform Enemy3;
    public Transform player;
    public float speed = 5;
    private Rigidbody2D Rigidbody2D;
    
    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").transform;

    }
    private void LateUpdate()
    {
        if (player == null || PlayerHealth.Instance.is_Die)
        {
            return;
        }
        
        Vector2 direction = (player.position - Enemy3.position).normalized;
        Rigidbody2D.MovePosition(Rigidbody2D.position + direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.Instance.TakeDamage(40);
            Destroy(gameObject);
        }
    }
}
