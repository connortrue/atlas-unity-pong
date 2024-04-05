using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneController : MonoBehaviour
{
    public GameObject ball;
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    public GameObject middleBar;
    public GameObject background;
    public GameObject walls;

    private PlayableDirector timeline;

    void Start()
    {
        // Initialize the Timeline
        timeline = GetComponent<PlayableDirector>();

        // Start the cutscene
        StartCoroutine(PlayCutscene());
    }

    IEnumerator PlayCutscene()
    {
        // Fade in the background
        FadeInEffect(background);
        yield return new WaitForSeconds(1f);

        // Fade in the walls
        FadeInEffect(walls);
        yield return new WaitForSeconds(1f);

        // Fade in the middle bar
        FadeInEffect(middleBar);
        yield return new WaitForSeconds(1f);

        // Fade in the paddles
        FadeInEffect(leftPaddle);
        FadeInEffect(rightPaddle);
        yield return new WaitForSeconds(1f);

        // Drop the ball from the top at a random angle
        DropBall();
    }

    void FadeInEffect(GameObject obj)
    {
        var fadeIn = obj.GetComponent<FadeIn>();
        if (fadeIn != null)
        {
            fadeIn.FadeInEffect();
        }
    }

    void DropBall() 
    {
        // Set the ball's initial position and velocity
        ball.transform.position = new Vector3(0, 10, 0); 
        float angle = Random.Range(30f, 60f); 
        float speed = 10f; 
        Vector3 direction = Quaternion.Euler(0, 0, angle) * Vector3.right;
        ball.GetComponent<Rigidbody>().velocity = direction * speed;
    }
}