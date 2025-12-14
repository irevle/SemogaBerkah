using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class camera : MonoBehaviour
{
    public Transform target; // Assign the moving object in the Inspector
    public Vector3 offset = new Vector3(0f, 2f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
