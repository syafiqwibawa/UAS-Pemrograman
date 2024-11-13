using UnityEngine;

public class MainMenuAudio : MonoBehaviour
{
    private void Start()
    {
        // Mulai audio di main menu
        GetComponent<AudioSource>().Play();
    }

    private void OnDisable()
    {
        // Berhenti saat scene berganti
        GetComponent<AudioSource>().Stop();
    }
}
