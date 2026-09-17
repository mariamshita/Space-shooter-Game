using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public static score instance;
    public TextMeshProUGUI text;
    public int current_score;


   public Transform bomb_point;
    public GameObject bomb;

    private void Awake()
    {
        instance = this;
        current_score = 0;
        text.text = current_score + " " ;
    }
    public void Increase_score()
    {
        current_score += 1;
        text.text = current_score+" ";

        if (current_score == 10)
        {
            Instantiate(bomb, bomb_point.position, bomb_point.rotation);
        }
    }
   
}
