using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Camera[] cameras;
    [SerializeField] private Collider[] triggers;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(mH * speed, rb.velocity.y, mV * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggers[0].CompareTag("CameraTP"))
        {
            cameras[0].gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bounce"))
        {
            rb.AddForce(new Vector3(0f, 10f, 0f), ForceMode.Impulse);
        }
    }
}
