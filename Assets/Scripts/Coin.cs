using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Pastikan Player memiliki tag "Player"
        {
            // Tambahkan koin ke skor
            ScoreManager.Instance.AddCoin();

            // Hancurkan koin setelah dikumpulkan
            Destroy(gameObject);
        }
    }
}
