using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    public Transform ball;
    public float speed = 10f;

    void Update()
    {
        float move = 0;
        if (ball.position.y > transform.position.y)
        {
            move = 1;
        }
        else if (ball.position.y < transform.position.y)
        {
            move = -1;
        }

        Vector2 paddlePos = transform.position;
        paddlePos.y += move * speed * Time.deltaTime;
        transform.position = paddlePos;
    }
}
