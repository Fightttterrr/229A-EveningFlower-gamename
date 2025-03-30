using UnityEngine;
using TMPro;

public class KeyCollector : MonoBehaviour
{
    public int keyCount = 0; // จำนวนกุญแจที่เก็บได้
    public int totalKeys = 3; // จำนวนกุญแจทั้งหมด
    public TextMeshProUGUI keyText; // UI แสดงจำนวนกุญแจ

    void Start()
    {
        UpdateKeyUI(); // อัปเดต UI ตอนเริ่มเกม
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ชนกับ: " + collision.gameObject.name); // ตรวจสอบว่า Player ชนกับอะไร

        if (collision.gameObject.CompareTag("Key")) // ถ้า Player ชนกุญแจ
        {
            Debug.Log("เก็บกุญแจ!"); // ขึ้นข้อความนี้เมื่อเก็บกุญแจ
            if (keyCount < totalKeys) // ถ้ายังเก็บไม่ครบ
            {
                keyCount++; // เพิ่มจำนวนกุญแจ
                UpdateKeyUI(); // อัปเดต UI
                Destroy(collision.gameObject); // ลบกุญแจออกจากฉาก
            }
        }
    }

    void UpdateKeyUI()
    {
        keyText.text = "Keys: " + keyCount + "/" + totalKeys;
    }
}