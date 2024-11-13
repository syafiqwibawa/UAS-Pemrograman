using UnityEngine;

public class CongratulationAudio : MonoBehaviour
{
    public AudioClip congratulationSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = congratulationSound;
        audioSource.Play();
    }
}
