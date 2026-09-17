using UnityEngine;

public class Bullets_enemy1_2 : MonoBehaviour
{
    public float speed;
    public float life_time;
    private Rigidbody2D Rigidbody2D;
       private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, life_time);
           }
    private void FixedUpdate()
    {
        Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.down * speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  print("m");
        if (collision.gameObject.CompareTag("Player"))
        {
          
            if (PlayerHealth.Instance != null)
            {
                PlayerHealth.Instance.TakeDamage(5);
            }
            Destroy(gameObject);
        }

        //if (collision.gameObject.CompareTag("boundary"))
        //{
        //    Destroy(gameObject);
        //}
    }
}