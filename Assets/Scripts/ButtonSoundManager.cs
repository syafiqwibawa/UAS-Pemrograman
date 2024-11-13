using UnityEngine;
using UnityEngine.UI;

public class ButtonSoundManager : MonoBehaviour
{
    public static ButtonSoundManager instance;

    [SerializeField] private AudioClip clickSound;
    private AudioSource audioSource;

    private void Awake()
    {
        // Pastikan hanya ada satu instance ButtonSoundManager
        if (instance == null)
        {
            instance = this;
            // Hapus atau komentari baris berikut agar tidak bertahan antar scene
            // DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Fungsi untuk memainkan suara klik
    public void PlayClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
