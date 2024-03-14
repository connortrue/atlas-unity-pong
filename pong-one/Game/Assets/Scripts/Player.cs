using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public float speed = 10f;

    void Update()
    {
        float move = 0;
        if (Input.GetKey(upKey))
        {
            move = 1;
        }
        else if (Input.GetKey(downKey))
        {
            move = -1;
        }

        Vector2 paddlePos = transform.position;
        paddlePos.y += move * speed * Time.deltaTime;
        transform.position = paddlePos;
    }
}
