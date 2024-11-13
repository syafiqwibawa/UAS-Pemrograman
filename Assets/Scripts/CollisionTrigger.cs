using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger : MonoBehaviour
{
    // Nama scene yang akan dibuka setelah tabrakan
    public string congratulationSceneName = "Congratulation";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Mengecek apakah objek yang menabrak memiliki tag "Player"
        if (collision.CompareTag("Player"))
        {
            // Memuat scene Congratulation
            SceneManager.LoadScene("Congratulation");
        }
    }
}
