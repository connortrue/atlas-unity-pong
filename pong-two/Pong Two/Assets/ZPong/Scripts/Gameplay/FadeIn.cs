using UnityEngine;

public class FadeIn
    : MonoBehaviour
{
    public float fadeSpeed = 1f;

    void Update()
    {
        // Fade in the object
        Color color = GetComponent<Renderer>().material.color;
        color.a += fadeSpeed * Time.deltaTime;
        GetComponent<Renderer>().material.color = color;

        // Disable the object once it's fully visible
        if (color.a >= 1f)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }

    public void FadeInEffect()
    {
        GetComponent<Renderer>().enabled = true;
    }
}