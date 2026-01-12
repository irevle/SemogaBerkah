using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float requiredSpeed = 5f;   // threshold to destroy
    public float speedPenalty = 3f;     // how much speed boulder loses
    public Rigidbody rb;
    public Object boulder;
    public void HitByBoulder(float boulderSpeed)
    {
        if (boulderSpeed >= requiredSpeed)
        {
            Destroy(gameObject); // obstacle breaks
        }
    }

    public void FixedUpdate()
    {
        HitByBoulder(rb.linearVelocity.magnitude);
    }
}