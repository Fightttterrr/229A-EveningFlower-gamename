using UnityEngine;

public class CameraSwitcher2 : MonoBehaviour
{
    public Camera frontCamera;       
    public Camera backCamera;        
    public Camera leftCamera;         
    public Camera rightCamera;        

    private Camera currentCamera;     // กล้องที่กำลังใช้งาน

    void Start()
    {
        // ตั้งค่ากล้องเริ่มต้นเป็นมุมมองบุคคลที่ 1
        SetCamera(frontCamera);
    }

    void Update()
    {
        // เช็คการกดปุ่มลูกศร
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetCamera(frontCamera);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetCamera(backCamera);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SetCamera(leftCamera);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetCamera(rightCamera);
        }
    }

    // ฟังก์ชันเพื่อสลับกล้อง
    void SetCamera(Camera newCamera)
    {
        // ปิดกล้องที่ใช้งานอยู่
        if (currentCamera != null)
        {
            currentCamera.enabled = false;
        }

        // เปิดกล้องใหม่
        currentCamera = newCamera;
        currentCamera.enabled = true;
    }
}
