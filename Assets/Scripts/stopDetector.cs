using UnityEngine;

public class stopDetector: MonoBehaviour
{
    public float stopThreshold = 0.1f;
    public float timeToStop = 1.0f;

    private Rigidbody rb;
    private float stopTimer = 0f;
    private bool hasStopped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.linearVelocity.magnitude < stopThreshold)
        {
            stopTimer += Time.deltaTime;

            if (stopTimer >= timeToStop && !hasStopped)
            {
                hasStopped = true;
                OnBallStopped();
            }
        }
        else
        {
            stopTimer = 0f;
        }
    }

    void OnBallStopped()
    {
        collision bc = GetComponent<collision>();
        int finalScore = bc.GetScore();
        Debug.Log("Final Score: " + finalScore);
    }
}