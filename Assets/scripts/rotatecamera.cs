using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecamera : MonoBehaviour
{
    public float speed;
    public Vector3 offset;
    public Transform ball;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 BALLpos = ball.position + offset;
        transform.position = Vector3.Lerp(transform.position, BALLpos, speed * Time.deltaTime);
    }
}
