using UnityEngine;

public class AddForceToBall : MonoBehaviour
{
    public float forceAmount = 50f;

    void Start()
    {
        // เพิ่มแรงในแกน Z ไปข้างหน้า
        GetComponent<Rigidbody>().AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
    }
}
