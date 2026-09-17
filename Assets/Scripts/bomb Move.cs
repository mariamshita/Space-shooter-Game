using UnityEngine;

public class bombMove : MonoBehaviour
{
    public float speed = 5;
    public float stop_at_y = 6;
    public AudioSource AudioSource;
    public AudioClip bomb_Audio;
    public AudioClip explosion_bomb_Audio;
    public GameObject explosion_Effect;
    public bool has_exploded = false;

    private void Start()
    {
        AudioSource.clip = bomb_Audio;
        AudioSource.loop = true;
        AudioSource.Play();
    }

    private void Update()
    {
        if (has_exploded)
        {
            return;
        }

        if(transform.position.y <= stop_at_y)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else
        {
     Explode();
        }
    }


    private void Explode()
    {
        has_exploded = true;
        AudioSource.Stop();
        AudioSource.loop = false;
        AudioSource.PlayOneShot(explosion_bomb_Audio);

        if(explosion_Effect != null)
        {
            Instantiate(explosion_Effect, transform.position, Quaternion.identity);
        }


        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject, explosion_bomb_Audio.length);
    }

}
