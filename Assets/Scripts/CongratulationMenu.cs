using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratulationMenu : MonoBehaviour
{
    // Fungsi untuk dipanggil oleh tombol
    public void GoToMainMenu()
    {
        // Masukkan nama scene Main Menu di sini
        SceneManager.LoadScene("Main Menu");
    }
}
