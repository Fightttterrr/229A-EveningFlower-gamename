using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstPersonCamera;   // กล้องมุมมองบุคคลที่ 1
    public Camera thirdPersonCamera;   // กล้องมุมมองบุคคลที่ 3
    public KeyCode switchKey = KeyCode.C; // ปุ่มสลับมุมมอง (C)

    private bool isFirstPerson = true; // เริ่มต้นเป็นมุมมองบุคคลที่ 1

    void Start()
    {
        // ตั้งค่ากล้องเริ่มต้น
        firstPersonCamera.enabled = true;
        thirdPersonCamera.enabled = false;
    }

    void Update()
    {
        // เช็คว่าผู้เล่นกดปุ่มที่กำหนดหรือไม่
        if (Input.GetKeyDown(switchKey))
        {
            ToggleCamera();
        }
    }

    void ToggleCamera()
    {
        isFirstPerson = !isFirstPerson; // สลับสถานะ

        firstPersonCamera.enabled = isFirstPerson;
        thirdPersonCamera.enabled = !isFirstPerson;
    }
}