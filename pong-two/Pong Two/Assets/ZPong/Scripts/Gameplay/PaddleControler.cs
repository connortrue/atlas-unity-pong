using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0, moveVertical, 0) * speed * Time.deltaTime;
        transform.Translate(movement);

        // Spin the paddle based on its movement
        float rotation = moveVertical * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, rotation);
    }
}