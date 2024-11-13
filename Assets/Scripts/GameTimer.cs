using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Text timerText; // Text UI untuk menampilkan waktu
    private float timeElapsed; // Waktu yang telah berlalu
    private bool isGameRunning = true; // Status permainan

    void Start()
    {
        timeElapsed = 0f; // Inisialisasi waktu
                          // Mulai timer saat permainan dimulai
        GameObject.Find("GameTimer").GetComponent<GameTimer>().StartTimer();
    }

    void Update()
    {
        if (isGameRunning)
        {
            timeElapsed += Time.deltaTime; // Tambahkan waktu yang berlalu
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // Tampilkan waktu dalam format menit:detik
        float minutes = Mathf.FloorToInt(timeElapsed / 60);
        float seconds = Mathf.FloorToInt(timeElapsed % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StopTimer()
    {
        isGameRunning = false; // Hentikan timer
    }

    public void StartTimer()
    {
        isGameRunning = true; // Mulai timer
    }

    public void ResetTimer()
    {
        timeElapsed = 0f; // Reset waktu
        UpdateTimerDisplay(); // Perbarui tampilan
    }

    void RestartGame()
    {
        GameObject.Find("GameTimer").GetComponent<GameTimer>().StopTimer(); // Hentikan timer saat merestart
        SceneManager.LoadScene("Gameplay"); // Ganti dengan nama scene permainan kamu
    }
}
