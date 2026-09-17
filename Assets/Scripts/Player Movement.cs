using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 5;
    public float min_x = -32.8f;
    public float max_x = 32.8f;
    public float min_y = -18;
    public float max_y = 0;

    private void Update()
    {
        Vector2 move_direction = Vector2.zero;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            move_direction.y += 1;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            move_direction.y -= 1;
        }
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            move_direction.x -= 1;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            move_direction.x += 1;
        }

        Vector3 new_position = player.position + (Vector3)(move_direction.normalized * speed * Time.deltaTime);

        new_position.x = Mathf.Clamp(new_position.x, min_x, max_x);
        new_position.y = Mathf.Clamp(new_position.y, min_y, max_y);

        player.position = new_position;
    }
}