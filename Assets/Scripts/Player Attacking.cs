using System.Collections;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    public Transform point_right;
    public Transform point_left;
    public GameObject shot;
    public AudioSource AudioSource;
    public AudioClip shot_Audio;
  
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Shot());
        }
    }
    private IEnumerator Shot()
    {
                AudioSource.PlayOneShot(shot_Audio);
            Instantiate(shot, point_left.position , point_left.rotation);
            Instantiate(shot, point_right.position , point_right.rotation);
            yield return new WaitForSeconds(1);
    }

   
}    

