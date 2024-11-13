using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float automaticDriveForce = 5f;
    public float jumpForce = 15f;
    public float slopeThreshold = 0.5f;
    private Rigidbody2D rb;
    private bool isOnSlope;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Cek apakah mobil terbalik
        if (transform.up.y > 0) // Hanya bergerak jika mobil tidak terbalik
        {
            // Kontrol manual dengan tombol A dan D
            float moveInput = Input.GetAxis("Horizontal"); // Nilai -1 (A) atau 1 (D)
            rb.AddForce(new Vector2(moveInput * speed, 0), ForceMode2D.Force);

            // Deteksi kemiringan
            isOnSlope = Mathf.Abs(rb.velocity.x) > slopeThreshold && Mathf.Abs(rb.velocity.y) < slopeThreshold;

            // Jika berada di tanjakan/turunan, otomatis dorong mobil
            if (isOnSlope && Mathf.Approximately(moveInput, 0))
            {
                rb.AddForce(new Vector2(transform.localScale.x * automaticDriveForce, 0), ForceMode2D.Force);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Jika mobil melewati tanjakan, berikan efek mencuat
        if (other.CompareTag("Ramp"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce), ForceMode2D.Impulse);
        }
    }
}
