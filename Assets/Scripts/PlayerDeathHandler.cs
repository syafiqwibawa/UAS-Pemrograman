using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    public float fallThresholdY = -10f; // Koordinat Y di mana mobil dianggap jatuh
    private bool isDead = false;        // Status kematian player

    void Update()
    {
        // Cek jika mobil jatuh di bawah threshold Y
        if (transform.position.y < fallThresholdY && !isDead)
        {
            TriggerGameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Cek jika mobil menyentuh platform berbahaya
        if (collision.gameObject.CompareTag("DeadlyPlatform") && !isDead)
        {
            TriggerGameOver();
        }
    }

    void TriggerGameOver()
    {
        isDead = true;
        SceneManager.LoadScene("Game Over"); // Ganti dengan nama scene Game Over
    }

    void RestartGame()
    {
        // Reset timer
        GameObject.Find("GameTimerManager").GetComponent<GameTimer>().ResetTimer();
        // Muat ulang scene permainan
        SceneManager.LoadScene("Gameplay"); // Ganti dengan nama scene permainan kamu
    }
}
