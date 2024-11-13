using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button settingsButton;
    public Button quitButton;
    public Button backButton;  // Tombol untuk kembali
    public GameObject settingsPanel;  // Panel untuk pengaturan
    public GameObject mainMenuPanel;  // Panel untuk menu utama (opsional)

    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        settingsButton.onClick.AddListener(OpenSettings);
        quitButton.onClick.AddListener(QuitGame);
        backButton.onClick.AddListener(CloseSettings);

        // Pastikan panel pengaturan tidak terlihat saat mulai
        settingsPanel.SetActive(false);
        mainMenuPanel.SetActive(true); // Pastikan menu utama terlihat
    }

    void PlayGame()
    {
        SceneManager.LoadScene("Gameplay"); // Ganti dengan nama scene permainan kamu
    }

    void OpenSettings()
    {
        settingsPanel.SetActive(true); // Tampilkan panel pengaturan
        mainMenuPanel.SetActive(false); // Sembunyikan menu utama
    }

    void CloseSettings()
    {
        settingsPanel.SetActive(false); // Sembunyikan panel pengaturan
        mainMenuPanel.SetActive(true); // Tampilkan kembali menu utama
    }

    void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        // Jika dijalankan di Unity Editor
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
