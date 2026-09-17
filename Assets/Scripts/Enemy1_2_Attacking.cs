using System.Collections;
using UnityEngine;

public class Enemy1_2_Attacking : MonoBehaviour
{
    public Transform Launch_point;
    public GameObject shot_enemy;
    public float wait_time;
        public AudioSource AudioSource;
    public AudioClip shot_Audio;

    public IEnumerator Attack()
    {
         while(true)
        {
            if(PlayerHealth.Instance==null || PlayerHealth.Instance.is_Die)
            {
               yield break;
            }
            Instantiate(shot_enemy, Launch_point.position, Launch_point.rotation);
            AudioSource.PlayOneShot(shot_Audio);
            yield return new WaitForSeconds(wait_time);

        }
    }
}
