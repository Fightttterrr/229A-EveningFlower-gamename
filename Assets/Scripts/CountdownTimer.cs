using UnityEngine;
using TMPro; // ใช้กับ TextMeshPro

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 300f; // 5 นาที (300 วินาที)
    public TextMeshProUGUI timerText; // UI Text แสดงเวลา
    public GameObject gameOverUI; // UI ที่จะแสดงเมื่อแพ้

    private bool isGameOver = false;

    void Start()
    {
        gameOverUI.SetActive(false); // ซ่อน UI แพ้ตอนเริ่มเกม
    }

    void Update()
    {
        if (!isGameOver)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // ลดเวลาลงเรื่อยๆ
                UpdateTimerDisplay();
            }
            else
            {
                GameOver(); // เรียกใช้เมื่อเวลาหมด
            }
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        isGameOver = true;
        timeRemaining = 0;
        timerText.text = "00:00"; // ตั้งค่าให้เหลือ 0 วินาที
        gameOverUI.SetActive(true); // แสดง UI แพ้
        Debug.Log("Game Over!");
    }
}
