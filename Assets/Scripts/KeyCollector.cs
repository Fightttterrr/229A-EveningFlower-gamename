using UnityEngine;
using TMPro;

public class KeyCollector : MonoBehaviour
{
    public int keyCount = 0; // จำนวนกุญแจที่เก็บได้
    public int totalKeys = 3; // จำนวนกุญแจทั้งหมดที่ต้องเก็บ
    public TextMeshProUGUI keyText; // UI แสดงจำนวนกุญแจ

    void Start()
    {
        UpdateKeyUI(); // อัปเดต UI ตอนเริ่มเกม
    }

    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบว่า Player ชนกับกุญแจหรือไม่
        if (collision.gameObject.CompareTag("Key")) // ถ้า Player ชนกับกุญแจ
        {
            // ตรวจสอบว่าเก็บกุญแจได้ครบตามจำนวนหรือไม่
            if (keyCount < totalKeys) 
            {
                keyCount++; // เพิ่มจำนวนกุญแจ
                UpdateKeyUI(); // อัปเดต UI
                Destroy(collision.gameObject); // ลบกุญแจออกจากฉาก
            }
        }
    }

    void UpdateKeyUI()
    {
        // อัปเดต UI ให้แสดงจำนวนกุญแจ
        keyText.text = "Keys: " + keyCount + "/" + totalKeys; }
}