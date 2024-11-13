using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformTrap : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Mengecek apakah objek yang menabrak adalah player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Memanggil fungsi untuk membunuh player atau mereset scene
            KillPlayer();
        }
    }

    void KillPlayer()
    {
        // Bisa ditambahkan efek atau animasi kematian di sini
        Debug.Log("Player Mati!");

        // Mereset scene saat ini untuk memulai ulang
        SceneManager.LoadScene("Game Over");
    }
}
