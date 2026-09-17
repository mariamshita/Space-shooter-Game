using System.Collections;
using System.Drawing;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //public GameObject Enemy_1;
    //public GameObject Enemy_2;
    //public GameObject Enemy_3;


    //public Transform [] Enemy_1_points;
    //public Transform[] Enemy_2_points;
    //public Transform[] Enemy_3_points;


    //public float Min = 1 , Max=3;


    //private void Start()
    //{
    //    StartCoroutine(spownEnemy1());
    //    StartCoroutine(spownEnemy2());
    //    StartCoroutine(spownEnemy3());
    //}

    //private IEnumerator spownEnemy1()
    //{
    //    foreach(Transform point in Enemy_1_points)
    //    {
    //        Instantiate(Enemy_1, point.position, Quaternion.identity);
    //    }
    //    yield return null;
    //}
    //private IEnumerator spownEnemy2()
    //{
    //    foreach (Transform point in Enemy_2_points)
    //    {
    //        Instantiate(Enemy_2, point.position, Quaternion.identity);
    //    }
    //    yield return null;
    //}
    //private IEnumerator spownEnemy3()
    //{
    //    foreach (Transform point in Enemy_3_points)
    //    {
    //        Instantiate(Enemy_3, point.position, Quaternion.identity);
    //    }
    //    yield return null;
    //}












    public GameObject[] Enemy;
    public GameObject[] point;
    public float wait_time;
    public float min;
    public float max;

    private void Start()
    {
        StartCoroutine(Enumerator());
    }
    public IEnumerator Enumerator()
    {
        while (true)
        {
            wait_time = Random.Range(min, max);
            yield return new WaitForSeconds(wait_time);
            int random_enemy = Random.Range(0, Enemy.Length);
            int random_point = Random.Range(0, point.Length);

            Instantiate
                (
                Enemy[random_enemy]
                , point[random_point].transform.position
                , Quaternion.identity
                                );
        }
    }
}
