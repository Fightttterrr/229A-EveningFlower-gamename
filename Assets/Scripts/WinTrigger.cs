using UnityEngine;
using TMPro; 
public class WinTrigger : MonoBehaviour
{
    public GameObject winTextUI;

    private void Start()
    {
        winTextUI.SetActive(false); // ซ่อน UI ตอนเริ่มเกม
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าเป็นผู้เล่นไหม
        {
            winTextUI.SetActive(true); // แสดง UI เมื่อชนกับจุด
            Debug.Log("You Win!");
        }
    }
}