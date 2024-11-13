using UnityEngine;
using UnityEngine.SceneManagement; // Diperlukan jika Anda ingin memuat ulang scene
using UnityEngine.UI; // Diperlukan jika Anda menggunakan UI

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Referensi ke UI pause menu
    private bool isPaused = false;
    private void Start()
    {
        // Pastikan game dimulai dalam keadaan tidak paused
        Resume();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Menyembunyikan pause menu
        Time.timeScale = 1f; // Mengatur waktu ke normal
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // Menampilkan pause menu
        Time.timeScale = 0f; // Menghentikan waktu
        isPaused = true;
    }

    public void QuitGame()
    {
        // Jika game dijalankan di build, keluar dari aplikasi
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;  // Menyudahi game di editor
#else
        Application.Quit();  // Keluar dari aplikasi di build
#endif
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Mengembalikan waktu ke normal sebelum restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Memuat ulang scene saat ini
    }
}
