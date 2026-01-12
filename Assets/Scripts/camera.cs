using Unity.Cinemachine;
using UnityEngine;

public class camera : MonoBehaviour
{
    public CinemachineCamera Camera;
    private Vector2 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void MouseGeser()
    {
        mousePos = Event.current.mousePosition;
        Quaternion rotation = new Quaternion(mousePos.x, mousePos.y, Camera.transform.position.z, 0);
        Camera.Follow.localRotation = rotation;
        
    }


    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
