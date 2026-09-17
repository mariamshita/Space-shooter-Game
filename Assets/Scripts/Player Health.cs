using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Max_Health = 100;
    private int Current_Health;

    public Image Slider;
    public TextMeshProUGUI text;
    public bool is_Die = false;
    public AudioSource AudioSource;
    public AudioClip Hit_Audio;
    public AudioClip Die_Audio;
    public static PlayerHealth Instance;

    public GameObject effect;
    public bool has_exploded = false;


    //public float explosion_duration = 0.11f;

    private void Awake()
    {
        Instance=this;
        Current_Health = Max_Health;
        Slider.fillAmount = 1;
        text.text = Current_Health + "%";

    }
    public void TakeDamage(int Damage)
    {
              
        AudioSource.PlayOneShot(Hit_Audio);
        Current_Health -= Damage;
        
        if (Current_Health <= 0 || is_Die)
        {
            has_exploded = true;
            Current_Health = 0;
            is_Die = true;
            die();
        }
        
        Slider.fillAmount = (float) Current_Health / Max_Health;
        text.text = Current_Health + "%";
        
        
    }
    
    public void die()
    {

        AudioSource.PlayOneShot(Die_Audio);

        if (effect != null)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
        }

        GetComponentInChildren<SpriteRenderer>().enabled=false;
        GetComponent<Collider2D>().enabled = false;
        

        //  float wait_time = Mathf.Max(Die_Audio.length, explosion_duration);
        Invoke(nameof(GoToGameOverScreen), Die_Audio.length);


        Destroy(gameObject, Die_Audio.length);
    }
    private void GoToGameOverScreen()
    {
        SceneManager.LoadScene("GameOverScreen");
    }


}
