using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Nama scene berikutnya
    public string nextSceneName;

    // Pindah ke scene berikutnya saat menabrak objek dengan tag tertentu
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Cek apakah objek yang ditabrak memiliki tag "TargetObject" (ubah sesuai kebutuhan)
        if (collision.CompareTag("Player"))
        {
            // Pindah ke scene berikutnya
            SceneManager.LoadScene("Gameplay 2");
        }
    }
}
