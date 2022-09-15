using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < SpawnManager.Instance.haider.Count; i++ )
        { 
        if (i % 2 == 0)
        {
        Vector3 lookDirection = ((player.transform.position - transform.position).normalized);
        enemyRb.AddForce((lookDirection) .normalized * speed,ForceMode.Impulse);
             }
        else
        {
            Vector3 lookDirection = (SpawnManager.Instance.haider[i - 1].transform.position - transform.position).normalized;
            enemyRb.AddForce((lookDirection).normalized * speed,ForceMode.Impulse);
        }
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            PlayerController.Instance.ScaleUp();
        }
    }
         }   
}
