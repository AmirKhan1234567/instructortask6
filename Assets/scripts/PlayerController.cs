using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    public float speed = 5.0f;
    private Rigidbody PlayerRb;
    private GameObject POINT;
    public bool hasPowerUP;
    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        POINT = GameObject.Find("focal point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        PlayerRb.AddForce(Vector3.forward * forwardInput * speed, ForceMode.Impulse);
        float horizontalInput = Input.GetAxis("Horizontal");
        PlayerRb.AddForce(Vector3.right * horizontalInput * speed, ForceMode.Impulse);
    }
    public void ScaleUp()
    {
        transform.localScale = transform.localScale + new Vector3(0.5f, 0.5f, 0.5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUP = true;
            Destroy(other.gameObject);
        }

    }
}
