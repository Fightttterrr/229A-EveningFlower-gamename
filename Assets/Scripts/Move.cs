using UnityEngine;

public class Move : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.D))
        {
            CalculateForceD();
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            CalculateForceA();
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            CalculateForceW();
        }
        
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CalculateForceS();
        }
        
    }

    void CalculateForceD()
    {
        mass = rb.mass;
        force = mass * acceleration;
        rb.AddForce(new Vector3(force, 0, 0));
    }
    
    void CalculateForceA()
    {
        mass = rb.mass;
        force = mass * acceleration;
        rb.AddForce(new Vector3(-force, 0, 0));
    }
    
    void CalculateForceW()
    {
        mass = rb.mass;
        force = mass * acceleration;
        rb.AddForce(new Vector3(0, 0, force));
    }
    
    void CalculateForceS()
    {
        mass = rb.mass;
        force = mass * acceleration;
        rb.AddForce(new Vector3(0, 0, -force));
    }
    
}
