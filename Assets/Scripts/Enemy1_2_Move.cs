using UnityEngine;

public class Enemy1_2_Move : MonoBehaviour
{
    public Transform Enemy;
    public float speed ; //3
    public float stop_at_y ; //15
    public float min_x;
    public float max_x;
    private float temp_x;
    private Rigidbody2D Rigidbody2D;
    public bool is_stopped = false;
    public Enemy1_2_Attacking Enemy1_Attacking;
    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        temp_x= Random.Range(min_x,max_x);
        transform.position = new Vector3(temp_x, transform.position.y , transform.position.z);
    }
    private void FixedUpdate()
    {
        if (!is_stopped) 
        {
           
            if(Rigidbody2D.position.y > stop_at_y) 
            { 
              Rigidbody2D.MovePosition(Rigidbody2D.position + Vector2.down * speed * Time.fixedDeltaTime);
            }
            else
            {
                is_stopped = true;
                Enemy1_Attacking.StartCoroutine(Enemy1_Attacking.Attack());
            }
        }   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.Instance.TakeDamage(10);
        }
    }
   }
