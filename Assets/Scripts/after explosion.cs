using UnityEngine;

public class afterexplosion : MonoBehaviour
{
    void Start()
    {
        Animator animator = GetComponent<Animator>();
        float length = animator.GetCurrentAnimatorStateInfo(0).length;
        Destroy(gameObject, length);
    }

}
