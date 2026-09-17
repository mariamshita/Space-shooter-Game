using UnityEngine;

public class BulletsMovement : MonoBehaviour
{
    public float shot_speed = 10;
    public float life_time = 3;

    private Rigidbody2D Rigidbody;
    public AudioSource AudioSource;
    public AudioClip die_Audoi;

    public GameObject explosion_effect;


    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, life_time);
    }
    private void FixedUpdate()
    {                                           //   (1,0)
        Rigidbody.MovePosition(Rigidbody.position + Vector2.up * shot_speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            AudioSource.PlayOneShot(die_Audoi);
            if (explosion_effect != null)
            {
                Instantiate(explosion_effect, collision.transform.position, Quaternion.identity);
            }
            Destroy(collision.gameObject);

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            Destroy(gameObject , die_Audoi.length);

            if (score.instance != null)
            {
                score.instance.Increase_score();
            }
        }

    }
}

