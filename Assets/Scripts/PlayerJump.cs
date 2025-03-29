using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float force; // แรง
    [SerializeField] private float mass;  // มวล
    [SerializeField] private float acceleration; // ความเร่ง

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CalculateForce();
        }

        
    }

    void CalculateForce()
    {
        mass = rb.mass;
        force = mass * acceleration;
        rb.AddForce(new Vector3(force, force, 0));
    }
    
}