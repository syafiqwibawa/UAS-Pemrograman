using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public Button restartButton; // Tombol restart yang akan kita atur
    public Button mainMenuButton; // Tombol untuk kembali ke menu utama

    void Start()
    {
        // Tambahkan listener pada tombol restart
        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    void RestartGame()
    {
        // Muat ulang scene utama (ganti dengan nama scene utama kamu)
        SceneManager.LoadScene("Gameplay"); // Ganti dengan nama scene utama kamu
    }

    void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu"); // Ganti dengan nama scene menu utama kamu
    }
}
