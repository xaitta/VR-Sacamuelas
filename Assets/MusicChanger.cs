using UnityEngine;

public class AudioSwitcher : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component
    public AudioClip gameStartedClip;  // The audio clip to play when the game is started
    public AudioClip gameNotStartedClip;  // The audio clip to play when the game is not started
    public OpenMouth openMouthScript;
    // Update is called once per frame
    void Update()
    {
        // Check the value of isGameStarted and switch the audio clip if needed
        if (openMouthScript.isGameStarted && audioSource.clip != gameStartedClip)
        {
            SwitchAudioClip(gameStartedClip);
        }
        else if (!openMouthScript.isGameStarted && audioSource.clip != gameNotStartedClip)
        {
            SwitchAudioClip(gameNotStartedClip);
        }
    }

    // Method to switch the audio clip
    void SwitchAudioClip(AudioClip newClip)
    {
        audioSource.clip = newClip;
        audioSource.Play();
    }
}
