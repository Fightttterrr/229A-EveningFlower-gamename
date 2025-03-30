using UnityEngine;

public class AutoMoveAndRotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 200, 0); // ความเร็วหมุนรอบตัวเอง
    public float moveForce = 5f; // แรงเคลื่อนที่
    public float moveDuration = 2f; // ระยะเวลาที่เคลื่อนที่ไปข้างหน้าและถอยกลับ

    private Rigidbody rb;
    private bool movingForward = true; // เช็คทิศทาง
    private float timer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 1f; // ป้องกันการสะสมแรง
    }

    void FixedUpdate()
    {
        // ทำให้วัตถุหมุนรอบตัวเอง
        transform.Rotate(rotationSpeed * Time.deltaTime);

        // ควบคุมเวลาเปลี่ยนทิศทาง
        timer += Time.deltaTime;
        if (timer >= moveDuration)
        {
            movingForward = !movingForward; // สลับทิศทาง
            timer = 0f;
            rb.velocity = Vector3.zero; // รีเซ็ตความเร็วก่อนเพิ่มแรงใหม่
        }

        // ใช้ AddForce ไปข้างหน้าหรือถอยหลัง
        Vector3 forceDirection = movingForward ? transform.forward : -transform.forward;
        rb.AddForce(forceDirection * moveForce, ForceMode.Force);
    }
}

