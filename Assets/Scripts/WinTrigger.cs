using UnityEngine;
using UnityEngine.SceneManagement;
public class WinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าเป็นผู้เล่นไหม
        {
            SceneManager.LoadScene("Ending");
        }
    }
}