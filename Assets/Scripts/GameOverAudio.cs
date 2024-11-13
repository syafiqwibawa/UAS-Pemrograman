using UnityEngine;

public class GameOverAudio : MonoBehaviour
{
    public AudioClip gameOverSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = gameOverSound;
        audioSource.Play();
    }
}
